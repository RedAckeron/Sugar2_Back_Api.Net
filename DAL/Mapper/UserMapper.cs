using DAL.Models;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public static class UserMapper
    {
		public static User DataToUser(this IDataRecord reader)
		{
            return new User()
            {
            Id = (int)reader["id"],
            Email=(string)reader["Email"],
            Password=null,
            FirstName=(string)reader["FirstName"],
            LastName=(string)reader["LastName"],
            DtIn=(DateTime)reader["DtIn"]
            };

		/*
		User user= new User(	
		(int)reader["id"],
		(string)reader["Email"],
		(string)reader["Password"],
		(string)reader["FirstName"],
        (string)reader["LastName"],
		(DateTime)reader["DtIn"]
		);
		return user;
		*/
		}
	}

    /*

         internal static Utilisateur ToUtilisateur(this IDataRecord record)
            {
                return new Utilisateur()
                {
                    Id = (int)record["Id"],
                    Nom = (string)record["Nom"],
                    Prenom = (string)record["Prenom"],
                    Email = (string)record["Email"],
                };
            }
     */





}