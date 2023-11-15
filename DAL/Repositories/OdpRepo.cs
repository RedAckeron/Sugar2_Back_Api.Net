using DAL.Interfaces;
using DAL.Mappers;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using ToolBox;
using Tools.Ado;
namespace DAL.Repositories
{
	public class OdpRepo : IOdpRepo
	{
		TextColor TextColor = new TextColor("Odp", "create", "", "black");
		private string? _connectionString;

		public OdpRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
		}

		//####################################################################################################################################################################
		#region Create
		public int Create(Models.OdpDal odp)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					int rows = 0;
					Console.WriteLine("[ODP]User : "+odp.AddByUser+" - Customer : "+odp.IdCustomer);
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Odp_Create", true, new { odp.AddByUser, odp.IdCustomer });
					TextColor.Write("Odp", "create", "Insertion de Odp OK", "green");
					return rows;
				}
				catch (Exception ex)
				{
					TextColor.Write("Odp", "create", ex.Message, "red");
					return 0;
				}
			}
			
		}
		#endregion
		#region Read
		public OdpDal? Read(int IdOdp)
		{
			OdpDal Odp = null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
					return dbConnection.ExecuteReader("SP_Odp_Read", dr => dr.DataToOdpDal(), true, new { IdOdp = IdOdp }).SingleOrDefault();
				}
			}
			catch (Exception ex)
			{
				TextColor.Write("odp", "read", ex.Message, "red");
			}
			return Odp;
		}
		#endregion
		#region Update
		public int Update(OdpDal O)
		{
			/*
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
				try
				{
					return DbConnectionExtensions.ExecuteNonQuery(dbConnection, "CSP_UpdateUser", true, new { U.Id, U.Email, U.FirstName, U.LastName });
				}
				catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(ex.Message);
					Console.ForegroundColor = ConsoleColor.Black;
					return 0;
				}
			}
			*/
			return 0;
		}
		#endregion
		#region Delete
		public int Delete(int IdCmd)
		{
			/*
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
			try
				{
                dbConnection.Open();
                int result = 0;
				result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "CSP_DelUser", true, new { IdUser });
				if (result != 0)
					{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("User "+IdUser+" ajouter avec succes ");
					Console.ForegroundColor = ConsoleColor.Black;
					}
                    //return DbConnectionExtensions.ExecuteNonQuery(dbConnection, "CSP_DelUser", true, new { IdUser });
                dbConnection.Close(); 
				return result;
				}
			catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(ex.Message);
					Console.ForegroundColor = ConsoleColor.Black;
					return 0;
				}
			}
			*/
			return 0;
		}
		#endregion
		#region AddItemToOdp
		public int AddItemToOdp(int IdOdp, int IdItem, int Qt, int AddByUser)
		{
			int rows = 0;
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Odp_AddItemToOdp", true, new { IdItem, IdOdp, Qt, AddByUser });
					TextColor.Write("cmd", "additem", $"Ajoute de {Qt} item {IdItem} dans cmd {IdOdp} OK", "green");
				}
				catch (Exception ex)
				{
					TextColor.Write("cmd", "additem", ex.Message, "red");
				}
			}
			return rows;
		}
        #endregion

		#region ReadOdpLight
        public OdpDalLight ReadOdpLight(int IdOdp)
        {
            OdpDalLight Odp = new OdpDalLight();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Odp_Read @IdOdp";
                            cmd.Parameters.AddWithValue("IdOdp", IdOdp);

                            cnx.Open();
                            //result = DbConnectionExtensions.ExecuteScalar(dbConnection, "SP_Customer_Create", true, new { C.FirstName, C.LastName, C.Email, C.Call1, C.Call2, C.AddByUser });

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Odp=OdpDalMapper.DataToOdpDalLight(reader);
                                }
                                TextColor.Write("Odp", "ReadAllOdpLight", $"Récuperation de 1 Offres de prix id {IdOdp}", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Odp", "ReadAllOdpLight", ex.Message, "orange");
            }
            return Odp;
        }
        #endregion

        #region ReadAllOdpLight
        public List<OdpDalLight> ReadAllOdpLight(int  IdCust)
        {
            List<OdpDalLight> Odps = new List<OdpDalLight>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Odp_ReadAllOdpLight @IdCust={IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
									Odps.Add(OdpDalMapper.DataToOdpDalLight(reader));
                                }
                                TextColor.Write("Odp", "ReadAllOdpLight", $"Récuperation de {Odps.Count} Offres de prix pour le client id {IdCust}", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Odp", "ReadAllOdpLight", ex.Message, "orange");
            }
            return Odps;
        }
        #endregion

        #region ReadLastOdpLight
        public List<OdpDalLight> ReadLastOdpLight()
        {
			List<OdpDalLight> Odps = new List<OdpDalLight>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Odp_ReadLastOdpLight;";

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
									OdpDalLight odpDalLight = OdpDalMapper.DataToOdpDalLight(reader);
                                    //odpDalLight.PrxTtl = (((int)reader["pv"])*((int)reader["Qt"]));
                                    //odpDalLight.NbItem = (int)reader["Qt"];
                                    Odps.Add(odpDalLight);

                                    //Odps.Add(OdpDalMapper.DataToOdpDalLight(reader));
                                }
                                TextColor.Write("Odp", "ReadLastOdpLight", $"Récuperation de {Odps.Count} Offres de prix", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Odp", "ReadLastOdpLight", ex.Message, "orange");
            }
            return Odps;
        }
        #endregion

    }
}