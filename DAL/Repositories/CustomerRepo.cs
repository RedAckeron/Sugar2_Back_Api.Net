using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using ToolBox;
using Tools.Ado;

namespace DAL.Repositories
{
    public class CustomerRepo:ICustomerRepo
	{
		TextColor TextColor = new TextColor("", "", "", "");

		private string _connectionString;
		
		//private readonly IDbConnection _connection;
		
		public CustomerRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
        }

	#region Create
		public int Create(Customer C)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					object result=null;
                    // public static object? ExecuteScalar(this IDbConnection connection, string query, bool isStoredProcedure = false, object? parameters = null)

                    result = DbConnectionExtensions.ExecuteScalar(dbConnection, "SP_Customer_Create", true, new { C.FirstName, C.LastName, C.Email, C.Call1, C.Call2, C.AddByUser });
					DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation du customer {C.FirstName} {C.LastName}" });

					TextColor.Write("customer", "create", $"Creation du customer {C.FirstName} {C.LastName} ID: {(int)result}" , "green");
					return (int)result;
				}
				catch (Exception ex)
				{
					TextColor.Write("customer", "create", ex.Message, "red");
					return 0;
				}
			}
		}
	#endregion
	#region Read
		public Customer? Read(int IdCust)
		{
			Customer Customer= null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
					Customer = dbConnection.ExecuteReader("SP_Customer_Read", dr => dr.DataToCustomer(), true, new { IdCust=IdCust }).SingleOrDefault();
					if (Customer != null)
					{
						TextColor.Write("customer", "read", $"Lecture du client {Customer.FirstName} {Customer.LastName}", "green");
					}
					else TextColor.Write("customer", "read", "Il n existe aucun customer avec l ID " + IdCust, "orange");
				}
			}
			catch (Exception ex)
			{
				TextColor.Write("customer", "read", ex.Message, "orange");
			}
			return Customer;
		}
	#endregion
	#region Update
		public int Update(Customer C)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				{ }
				dbConnection.Open();
				try
				{
					int result = 0;
					result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Customer_Update", true, new {C.Id, C.FirstName, C.LastName});
					TextColor.Write("0000000customer", "update", $"Mise a jours du customer {C.Id} OK", "green");
					return result;
				}
				catch (Exception ex)
				{
					TextColor.Write("customer", "update", ex.Message, "orange");
					return 0;
				}
			}
		}
	#endregion
	#region Delete
		public int Delete(int IdCust)
		{
			return 0;
		}
    #endregion
    #region FindCustomer
        public List<Customer> FindCustomer(string cust)
		{
            List<Customer> Customers = new List<Customer>();
			try
			{
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
                using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                    using (SqlCommand cmd = cnx.CreateCommand())
						{
						cmd.CommandText = $"Exec SP_Customer_FindCustomer @Customer='%{@cust}%';";
						cmd.Parameters.AddWithValue("cust", @cust);
							
							cnx.Open();
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								while (reader.Read())
								{
									Customers.Add(CustomerMapper.DataToFindCustomer(reader));
									
                                }
                            TextColor.Write("customer", "FindCustomer", $"Récuperation de {Customers.Count} customer avec le mot {cust}" , "green");

                            }
                        }
                    }
				}
			}
        catch (Exception ex)
			{
				TextColor.Write("customer", "FindCustomer", ex.Message, "orange");
			}
        return Customers;

		}
        #endregion
    #region ReadLastCustomer
        public List<Customer> ReadLastCustomer()
        {
            List<Customer> Customers = new List<Customer>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Customer_ReadLastCustomer;";
                            //cmd.Parameters.AddWithValue("cust", @cust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Customers.Add(CustomerMapper.DataToFindCustomer(reader));
								}
                                TextColor.Write("customer", "ReadLastCustomer", $"Récuperation des 20 derniers clients encodé", "green");

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("customer", "FindCustomer", ex.Message, "orange");
            }
            return Customers;
        }
        #endregion
    }
}
