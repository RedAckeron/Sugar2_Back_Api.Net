using DAL.Models;
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
	public static Customer DataToCustomer(this IDataRecord reader)
		{
			return new Customer()
			{
				Id = (int)reader["id"],
				FirstName = (string)reader["FirstName"],
				LastName = (string)reader["LastName"],
				DtIn = (DateTime)reader["DtIn"]
			};
		}
	}
}