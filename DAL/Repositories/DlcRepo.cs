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
	public class DlcRepo : IDlcRepo
	{
		TextColor TextColor = new TextColor("Dlc", "create", "", "black");
		private string? _connectionString;

		public DlcRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
		}

		//####################################################################################################################################################################
		#region Create
		public int Create(DlcDal dlcDal)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Dlc_Create", true, new { dlcDal.AddByUser, dlcDal.IdCustomer });
					TextColor.Write("Dlc", "create", "Insertion de Dlc OK", "green");
					return rows;
				}
				catch (Exception ex)
				{
					TextColor.Write("Dlc", "create", ex.Message, "red");
					return 0;
				}
			}
			
		}
		#endregion
		#region Read
		public DlcDal Read(int IdDlc)
		{
			DlcDal dlcDal= null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
					dlcDal=dbConnection.ExecuteReader("SP_Dlc_Read", dr => dr.DataToDlcDal(), true, new { IdDlc }).SingleOrDefault();
                    TextColor.Write("Dlc", "read", "Lecture du repair "+IdDlc, "green");
                }
            }
			catch (Exception ex)
			{
				TextColor.Write("rpr", "read", ex.Message, "red");
			}
			return dlcDal;
		}
		#endregion
		#region Update
		public int Update(DlcDal dlcDal)
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
		#region ReadAllDlcLight
        public List<DlcDalLight> ReadAllDlcLight(int IdCust)
        {
            List<DlcDalLight> Dlcs = new List<DlcDalLight>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Dlc_ReadAllDlcLight @IdCust={IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
									//Console.WriteLine(reader["id"]+" "+reader["DtIn"]);
                                    Dlcs.Add(DlcDalMapper.DataToDlcDalLight(reader));
                                }
                                TextColor.Write("Dlc", "ReadAllDlcLight", $"Récuperation de {Dlcs.Count} Offres de prix pour le client id {IdCust}", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Dlc", "ReadAllDlcLight", ex.Message, "orange");
            }
            return Dlcs;
        }
        #endregion
    }
}