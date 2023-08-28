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
		public static UserDal DataToUser(this IDataRecord reader)
		{
            return new UserDal()
            {
            Id = (int)reader["id"],
            Email=(string)reader["Email"],
            Password=null,
            FirstName=(string)reader["FirstName"],
            LastName=(string)reader["LastName"],
            DtIn=(DateTime)reader["DtIn"]
            };

		
		}
	}

   
}