using DAL.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
	public static class CustomerMapper
	{
	public static CustomerDal DataToCustomer(this IDataRecord reader)
		{
			return new CustomerDal()
			{
				Id = (int)reader["id"],
				FirstName = (string)reader["FirstName"],
				LastName = (string)reader["LastName"],
				Email = (string)reader["email"],
				Call1 = (string)reader["Call1"],
				Call2= (string)reader["Call2"],
				DtIn = (DateTime)reader["DtIn"]
			};
		}
	public static CustomerDal DataToFindCustomer(this IDataRecord reader) 
		{
			return new CustomerDal()
			{
				Id = (int)reader["id"],
				FirstName = (string)reader["FirstName"],
				LastName = (string)reader["LastName"],
				DtIn = DateTime.Now

			};
        }
	}
}