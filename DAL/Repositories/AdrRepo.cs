using DAL.Interfaces;
using DAL.Mappers;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using ToolBox;
using Tools.Ado;

namespace DAL.Repositories
{
    public class AdrRepo : IAddressRepo
    {
        TextColor TextColor = new TextColor("", "", "", "");

        private string _connectionString;

        //private readonly IDbConnection _connection;

        public AdrRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }

        #region CreateUserAddress
        public int CreateUserAddress(int idUser)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int rows = 0;
                    rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Adresse_CreateUserAddress", true, new { idUser });
                    //DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation d une adresse pour le user ****** a corriger ******" });

                    TextColor.Write("user", "create", $"Creation d une adresse pour le user {idUser}  OK", "green");
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

        #region CreateCustomerAddress
        public int CreateCustomerAddress(int idCustomer)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                try
                {
                    int chkcnt = (int)DbConnectionExtensions.ExecuteScalar(dbConnection, "SP_Address_CountCustomerAddress", true, new { IdCust=idCustomer });

                    if (chkcnt < 3)
                    {
                        int rows = 0;
                        rows = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Address_CreateCustomerAddress", true, new { idCustomer});
                        //DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Log_Create", true, new { Priority = 2, AddByUser = 1, Msg = $"Creation d une adresse pour le client ****** a corriger ******" });

                        TextColor.Write("Address", "create", $"Creation d une adresse pour le client {idCustomer} OK", "green");
                        return rows;
                    }
                    else
                    {
                        throw new Exception("Le client a deja 3 adresse enregistré");
                    }
                   
                }
                catch (Exception ex)
                {
                    TextColor.Write("Address", "create", ex.Message, "red");
                    return 0;
                }
            }
        }
        #endregion

        #region Read
            public Models.AdrDal Read(int IdAdr)
            {
            //AdrDal adrDal = null;
                try
                {
                    using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                    {
                    dbConnection.Open();
                    TextColor.Write("Address", "read", $"Lecture de l adresse id {IdAdr} OK", "green");
                    return dbConnection.ExecuteReader("SP_Address_Read", dr => dr.DataToAdrDal(), true, new { IdAdr }).SingleOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    TextColor.Write("Address", "read", ex.Message, "red");
                    return null;
                }
            }
        #endregion

        #region Update
        public int Update(Models.AdrDal adrDal)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                { }
                dbConnection.Open();
                try
                {
                    int result = 0;
                    result = DbConnectionExtensions.ExecuteNonQuery(dbConnection, "SP_Adresse_Update", true, new { adrDal.Id, adrDal.AdrInfo, adrDal.AdrRue, adrDal.AdrNo, adrDal.AdrVille, adrDal.AdrCp, adrDal.AdrPays });
                    TextColor.Write("Address", "update", $"Mise a jours de l adresse id {adrDal.Id} OK", "green");
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
        
        #region ReadAllAdrLight
        public List<AdrDalLight> ReadAllAdrLight(int IdCust)
        {
            List<AdrDalLight> Adrs = new List<AdrDalLight>();
            try
            {
                using (IDbConnection dbConnection = new SqlConnection(_connectionString))
                {
                    using (SqlConnection cnx = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = cnx.CreateCommand())
                        {
                            cmd.CommandText = $"Exec SP_Adr_ReadAllAdrLight @IdCust={IdCust};";
                            cmd.Parameters.AddWithValue("IdCust", IdCust);

                            cnx.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //Console.WriteLine(reader["id"]+" "+reader["DtIn"]);
                                    Adrs.Add(AdrDalMapper.DataToAdrDalLight(reader));
                                }
                                TextColor.Write("Adr", "ReadAllAdrLight", $"Récuperation de {Adrs.Count} Offres de prix pour le client id {IdCust}", "green");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextColor.Write("Dlc", "ReadAllDlcLight", ex.Message, "orange");
            }
            return Adrs;
        }
        #endregion
    }
}