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
	public static Customer DataToFindCustomer(this IDataRecord reader) 
		{
			return new Customer()
			{
				Id = (int)reader["id"],
				FirstName = (string)reader["FirstName"],
				LastName = (string)reader["LastName"],
				DtIn = DateTime.Now

			};
        }
	public static CustomerAdresse DataToCustomerAdresse(this IDataRecord reader)
		{
			return new CustomerAdresse()
			{
				Id = (int)reader["id"],
				IdCustomer= (int)reader["IdCustomer"],
				AdrInfo = (string)reader["AdrInfo"],
				AdrRue = (string)reader["AdrInfo"],
				AdrNo = (string)reader["AdrInfo"],
				AdrVille = (string)reader["AdrInfo"],
				AdrCp = (string)reader["AdrInfo"],
				AdrPays = (string)reader["AdrInfo"]
			};
        }
	}
}