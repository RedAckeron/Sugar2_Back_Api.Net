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
    public class UserRepo:IUserRepo
	{
		TextColor TextColor = new TextColor("","","", "black");
		private string ?_connectionString;

        public UserRepo(IConfiguration config, IDbConnection connection)
		{
			_connectionString = config.GetConnectionString("default");
        }
        
        #region CREATE
        public int Create(UserDal U)
		{
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int rows = 0;
					rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_User_Create", true, new { U.LastName, U.FirstName, U.Email, U.Password });
                    DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority=2,AddByUser=1,Msg="Creation d un utilisateur" });

                    TextColor.Write("user", "create", "Creation du user " +U.Email+" : OK", "green");
					return rows;
				}
				catch (Exception ex)
                {
					TextColor.Write("user","create","Email existe deja en DB", "red");
                    return 0;
                }
            }
        }
        #endregion
        
        #region READ
        public UserDal? Read(int IdUser)
		{
            UserDal user = null;
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    dbConnection.Open();
                    user= dbConnection.ExecuteReader("SP_User_Read", dr => dr.DataToUser(), true, new { Id= IdUser}).SingleOrDefault();
                    if (user != null)
                        {
						    user.Password = null;
						    TextColor.Write("user", "read", "User Read : " + user.Email + " OK", "green");
					    }
					else TextColor.Write("user", "read", "Il n existe aucun user avec l ID " +IdUser, "orange");
				}
			}
            catch (Exception ex)
            {
                TextColor.Write("user", "read", "Il n existe pas de user avec l id "+IdUser+" en DB", "orange");
            }
            return user;
		}
        #endregion
        
        #region LOGIN
        public UserDal? Login(UserDal userDal)
			{
            UserDal userdal;
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                   

                    dbConnection.Open();
                    userdal = dbConnection.ExecuteReader("SP_User_Login", dr => dr.DataToUser(), true, new { Email = userDal.Email, Password = userDal.Password }).SingleOrDefault<UserDal>();

                    if (userdal!=null)
                    {
                       
                        TextColor.Write("user", "login", $"User {userdal.Email} : OK", "green");
                    }

                    else
                    {
                        throw new ArgumentException("Login ou password incorrect");
                    }
                    return userdal;
                }
                
            }
            catch (Exception ex)
            {
                TextColor.Write("user", "login", ex.Message, "red");
               
                return new UserDal() { Id=0};
            }
            
           
           }
        #endregion
        
        #region UPDATE
        public int Update(UserDal U)
		{
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
				try
				{
                    int result =0;
					result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_User_Update", true, new { U.Id, U.Email, U.FirstName, U.LastName });
                    TextColor.Write("user", "update", "Mise a jours de " +result+" user OK", "Succes");
                    return result;
				}
				catch (Exception ex)
				{
                    TextColor.Write("user", "update","La mise a jours du user "+U.Id+" n est pas possible", "Error");
                    return 0;
				}
			}
		}
        #endregion

        public bool Enable(int IdUser)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int result = 0;
                    result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_User_Enable", true, new { IdUser});
                    DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = "Activation du User "+IdUser });
                    TextColor.Write("user", "create", "User Enable " + result + " OK", "Succes");
                    if (result != 0) return true;
                    else return false;
                }
                catch (Exception ex)
                {
                    TextColor.Write("user", "create", ex.Message, "Error");
                    return false;
                }
            }
        }
        //####################################################################################################################################################################
        public bool Disable(int IdUser)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int result = 0;
                    result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_User_Disable", true, new { IdUser });
                    DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = "Désactivation du User "+IdUser });

                    TextColor.Write("user", "create", "User Disable " + result + " OK", "Succes");
                    if (result != 0) return true;
                    else return false;
                }
                catch (Exception ex)
                {
                    TextColor.Write("user", "create", ex.Message, "Error");
                    return false;
                }
            }
        }
        //####################################################################################################################################################################
        public int Delete(int IdUser)
		{
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int result = 0;
                    result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_User_Delete", true, new { IdUser });
                    DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 1, AddByUser = 1, Msg = "Supression du User "+IdUser });
                    TextColor.Write("user", "create", "User Delete " + result + " OK", "Succes");
                    return result;
                }
                catch (Exception ex)
                {
                    TextColor.Write("user", "create", ex.Message, "Error");
                    return 0;
                }
            }
        }

        public int InsertFrefreshToken(string email, string refreshToken, DateTime validite)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int result = 0;
                    result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "[InsertRefreshToken", true, new { email,refreshToken, validite }) ;
                    TextColor.Write("user", "Token", "User Delete " + result + " OK", "Succes");
                    return result;
                }
                catch (Exception ex)
                {
                    TextColor.Write("user", "Token", ex.Message, "Error");
                    return 0;
                }
            }
        }
	}
}