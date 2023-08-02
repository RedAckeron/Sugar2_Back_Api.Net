using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using ToolBox;
using Tools.Ado;
namespace DAL.Repositories
{
    public class ItemRepo:IItemRepo
	{
		TextColor TextColor = new TextColor("user", "create", "", "black");
		private string ?_connectionString;

        public ItemRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
        }

		//####################################################################################################################################################################
		public int Create(Item I)
		{
			
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
					int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Item_Create", true, new { I.Label, I.Url,I.PrxAchat,I.PrxVente,I.AddByUser});
					TextColor.Write("user", "create", "Insertion de Item OK", "Succes");
					return rows;
				}
				catch (Exception ex)
                {
					TextColor.Write("user", "create", ex.Message, "red");
                    return 0;
                }
            }
			
        }
//####################################################################################################################################################################
		public Item? Read(int IdItem)
		{
			Item Item = null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
					return dbConnection.ExecuteReader("SP_Item_Read", dr => dr.DataToItem(), true, new { IdItem=IdItem}).SingleOrDefault();
				}
			}
			catch (Exception ex)
			{
				TextColor.Write("user", "create", ex.Message, "red");
			}
			return Item;
		}
		//####################################################################################################################################################################
		public List<Item> ReadAllOfCmd(int IdCmd)
		{
			List<Item> basket = new List<Item>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
			{
				using (SqlCommand cmd = cnx.CreateCommand())
				{
					cmd.CommandText = "select * from ItemCmd where IdCmd = @IdCcmd;";
					cmd.Parameters.AddWithValue("IdCcmd", @IdCmd);

					cnx.Open();
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							using (IDbConnection dbConnection = new SqlConnection(_connectionString))
							{
								dbConnection.Open();
								Item item = dbConnection.ExecuteReader("SP_Item_Read", dr => dr.DataToItem(), true, new { IdItem = reader["id"] }).SingleOrDefault();
								item.Qt = (int)reader["Qt"];
								basket.Add(item);
							}
						}
					}
				}
			}
			return basket;
		}
//####################################################################################################################################################################
       
        public int Update(Item I)
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
        //####################################################################################################################################################################
        public int Delete(int IdItem)
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
	}
}
