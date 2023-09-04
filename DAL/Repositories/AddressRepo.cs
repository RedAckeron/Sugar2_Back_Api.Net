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
    public class AddressRepo:IAddressRepo
	{
		TextColor TextColor = new TextColor("", "", "", "");

		private string _connectionString;
		
		//private readonly IDbConnection _connection;
		
		public AddressRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
        }

	#region CreateCustomerAddress
		public int CreateCustomerAddress(CustomerAddressDal CA)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Address_CreateCustomerAddress", true, new { CA.IdCustomer,CA.AdrInfo,CA.AdrRue,CA.AdrNo,CA.AdrVille,CA.AdrCp,CA.AdrPays});
					DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation d une adresse pour le client ****** a corriger ******" });

					TextColor.Write("Address", "create", $"Creation d une adresse pour le client ******* a corriger ****** ", "green");
					return rows;
				}
				catch (Exception ex)
				{
					TextColor.Write("Address", "create", ex.Message, "red");
					return 0;
				}
			}
		}
        #endregion

    #region ReadCustomerAddress
        public CustomerAddressDal ReadCustomerAddress(int IdAdr)
			{
            CustomerAddressDal CA = null;
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    try 
                    {
                        dbConnection.Open();
                        CA = dbConnection.ExecuteReader("SP_Address_ReadCustomerAddress", dr => dr.DataToCustomerAdresse(), true, new { IdAdr }).SingleOrDefault();
                        TextColor.Write("Address", "read", $"Lecture de l adresse {CA.AdrInfo} du client {CA.IdCustomer}", "green");
                        return CA;
                    }
                    catch (Exception ex)
                    {
                        TextColor.Write("Address", "read", ex.Message, "orange");
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Address", "read", ex.Message, "red");
            }
            return CA;
        }
	#endregion

	#region ReadCustomerAllAddress
		public List<CustomerAddressDal> ReadCustomerAllAddress(int IdCust)
        {
            List<CustomerAddressDal> CustomerAdresses = new List<CustomerAddressDal>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Address_ReadCustomerAllAddress @IdCust={@IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    CustomerAdresses.Add(AddressMapper.DataToCustomerAdresse(reader));

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
    
	#region UpdateCustomerAddress
        public int UpdateCustomerAddress(CustomerAddressDal CA)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				{ }
				dbConnection.Open();
				try
				{
					int result = 0;
					result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Adresse_Update", true, new { CA.Id, CA.AdrInfo, CA.AdrRue, CA.AdrNo, CA.AdrVille, CA.AdrCp, CA.AdrPays });
                    TextColor.Write("Address", "update", $"Mise a jours de l adresse {CA.AdrInfo} du customer **** A CORIGER ***** OK", "green");
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
	
	#region DeleteCustomerAddress
		public int DeleteCustomerAddress(int IdCust)
		{
			return 0;
		}
        #endregion


    #region CreateUserAddress
    public int CreateUserAddress(UserAddressDal UA)
    {
        using (IDbConnection dbConnection = new SqlConnection(_connectionString))
        {
            dbConnection.Open();
            try
            {
                int rows = 0;
                rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Adresse_CreateCustomerAddress", true, new { UA.Id, UA.AdrInfo, UA.AdrRue, UA.AdrNo, UA.AdrVille, UA.AdrCp, UA.AdrPays });
                DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation d une adresse pour le user ****** a corriger ******" });

                TextColor.Write("user", "create", $"Creation d une adresse pour le client ******* a corriger ****** ", "green");
                return rows;
            }
            catch (Exception ex)
            {
                TextColor.Write("user", "create", ex.Message, "red");
                return 0;
            }
        }
    }
    #endregion

    #region ReadUserAddress
    public UserAddressDal ReadUserAddress(int IdAdr)
    {
        return null;
    }
    #endregion

    #region ReadAllOfUserAddress
    public List<UserAddressDal> ReadAllOfUserAddress(int IdCust)
    {
        List<UserAddressDal> UserAdresses = new List<UserAddressDal>();
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
                                UserAdresses.Add(AddressMapper.DataToUserAdresse(reader));
                            }
                            TextColor.Write("customer", "ReadAllOfCustomer", $"Récuperation de {UserAdresses.Count} adresses pour le client {IdCust}", "green");

                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            TextColor.Write("customer", "ReadAllOfCustomer", ex.Message, "orange");
        }
        return UserAdresses;

    }
    #endregion

    #region UpdateUserAddress
    public int UpdateUserAddress(UserAddressDal UA)
    {
        using (IDbConnection dbConnection = new SqlConnection(_connectionString))
        {
            dbConnection.Open();
            try
            {
                int result = 0;
                result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Adresse_Update", true, new { UA.Id, UA.AdrInfo, UA.AdrRue, UA.AdrNo, UA.AdrVille, UA.AdrCp, UA.AdrPays });
                TextColor.Write("Address", "update", $"Mise a jours de l adresse {UA.AdrInfo} du customer **** A CORIGER ***** OK", "green");
                return result;
            }
            catch (Exception ex)
            {
                TextColor.Write("address", "update", ex.Message, "orange");
                return 0;
            }
        }
    }
    #endregion

    #region DeleteUserAddress
    public int DeleteUserAddress(int IdUser)
    {
        return 0;
    }
    #endregion
    }
}