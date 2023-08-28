using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
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
		public int Create(ItemDal I)
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
		public ItemDal Read(int IdItem)
		{
            ItemDal Item = null;
			try
			{
				using (IDbConnection dbConnection = new SqlConnection(_connectionString))
				{
					dbConnection.Open();
                    ItemDal item;
                    item = dbConnection.ExecuteReader("SP_Item_Read", dr => dr.DataToItemDal(), true, new { IdItem = IdItem }).SingleOrDefault();
                    TextColor.Write("item", "Read", $"Lecture de Item {item.Label}", "green");
					return item;
				}
			}
			catch (Exception ex)
			{
				TextColor.Write("user", "create", ex.Message, "red");
			}
			return Item;
		}
		//####################################################################################################################################################################
		public List<ItemDal> ReadAllOfCmd(int IdCmd)
		{
            List<ItemDal> basket = new List<ItemDal>();
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
                                ItemDal item = dbConnection.ExecuteReader("SP_Item_Read", dr => dr.DataToItemDal(), true, new { IdItem = reader["id"] }).SingleOrDefault();
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
       
        public int Update(ItemDal I)
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
