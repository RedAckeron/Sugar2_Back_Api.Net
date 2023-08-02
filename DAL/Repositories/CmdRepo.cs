using DAL.Interfaces;
using DAL.Mapper;
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
	public class CmdRepo : ICmdRepo
	{
		TextColor TextColor = new TextColor("user", "create", "", "black");
		private string? _connectionString;

		public CmdRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
		}

		//####################################################################################################################################################################
		#region Create
		public int Create(Cmd C)
		{
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Cmd_Create", true, new { C.AddByUser, C.IdCustomer });
					TextColor.Write("cmd", "create", "Insertion de Item OK", "green");
					return rows;
				}
				catch (Exception ex)
				{
					TextColor.Write("cmd", "create", ex.Message, "red");
					return 0;
				}
			}
			
		}
		#endregion
		#region Read
		public Cmd? Read(int IdCmd)
		{
			Cmd Cmd = null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
					return dbConnection.ExecuteReader("SP_Cmd_Read", dr => dr.DataToCmd(), true, new { IdCmd = IdCmd }).SingleOrDefault();
				}
			}
			catch (Exception ex)
			{
				TextColor.Write("cmd", "read", ex.Message, "red");
			}
			return Cmd;
		}
		#endregion
		#region Update
		public int Update(Cmd C)
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
		#region AddItemToCmd
		public int AddItemToCmd(int IdCmd, int IdItem, int Qt, int AddByUser)
		{
			int rows = 0;
			using (IDbConnection dbConnection = new SqlConnection(_connectionString))
			{
				dbConnection.Open();
				try
				{
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Cmd_AddItemToCmd", true, new { IdItem, IdCmd, Qt, AddByUser });
					TextColor.Write("cmd", "additem", $"Ajoute de {Qt} item {IdItem} dans cmd {IdCmd} OK", "green");
				}
				catch (Exception ex)
				{
					TextColor.Write("cmd", "additem", ex.Message, "red");
				}
			}
			return rows;
		}
        #endregion
		#region ReadAllCmdLight
        public List<CmdLight> ReadAllCmdLight(int  IdCust)
        {
            List<CmdLight> Cmds = new List<CmdLight>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Cmd_ReadAllCmdLight @IdCust={IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
									Console.WriteLine(reader["id"]+" "+reader["DtIn"]);
                                    Cmds.Add(CmdMapper.DataToCmdLight(reader));
                                }
                                TextColor.Write("Command", "ReadAllCmdLight", $"Récuperation de {Cmds.Count} commandes pour le client id {IdCust}", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Command", "ReadAllCmdLight", ex.Message, "orange");
            }
            return Cmds;
        }
        #endregion
    }
}