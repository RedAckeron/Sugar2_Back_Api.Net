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
    public class CustomerAdresseRepo:ICustomerAdresseRepo
	{
		TextColor TextColor = new TextColor("", "", "", "");

		private string _connectionString;
		
		//private readonly IDbConnection _connection;
		
		public CustomerAdresseRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
        }

	#region Create
		public int Create(CustomerAdresse CA)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_CustomerAdresse_Create", true, new { CA.IdCustomer,CA.AdrInfo,CA.AdrRue,CA.AdrNo,CA.AdrVille,CA.AdrCp,CA.AdrPays});
					DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation d une adresse pour le client {CA.IdCustomer}" });

					TextColor.Write("customer", "create", $"Creation d une adresse pour le client {CA.IdCustomer} ", "green");
					return rows;
				}
				catch (Exception ex)
				{
					TextColor.Write("customer", "create", ex.Message, "red");
					return 0;
				}
			}
		}
        #endregion



        #region ReadAllOfCustomer
        public List<CustomerAdresse> ReadAllOfCustomer(int IdCust)
        {
            List<CustomerAdresse> CustomerAdresses = new List<CustomerAdresse>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_CustomerAdresse_Read @IdCust={@IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    CustomerAdresses.Add(CustomerMapper.DataToCustomerAdresse(reader));

                                }
                                TextColor.Write("customer", "ReadAllOfCustomer", $"Récuperation de {CustomerAdresses.Count} adresses pour le client {IdCust}", "green");

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("customer", "ReadAllOfCustomer", ex.Message, "orange");
            }
            return CustomerAdresses;

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

    }
}
