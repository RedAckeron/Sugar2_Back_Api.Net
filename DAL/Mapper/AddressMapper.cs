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
	public static class AddressMapper
	{
	public static CustomerAddress DataToCustomerAdresse(this IDataRecord reader)
		{
			return new CustomerAddress()
			{
				Id = (int)reader["id"],
				IdCustomer= (int)reader["IdCustomer"],
				AdrInfo = (string)reader["AdrInfo"],
				AdrRue = (string)reader["AdrRue"],
				AdrNo = (string)reader["AdrNo"],
				AdrVille = (string)reader["AdrVille"],
				AdrCp = (string)reader["AdrCp"],
				AdrPays = (string)reader["AdrPays"]
			};
        }

        public static UserAddress DataToUserAdresse(this IDataRecord reader)
        {
            return new UserAddress()
            {
                Id = (int)reader["id"],
                IdUser= (int)reader["IdUser"],
                AdrInfo = (string)reader["AdrInfo"],
                AdrRue = (string)reader["AdrRue"],
                AdrNo = (string)reader["AdrNo"],
                AdrVille = (string)reader["AdrVille"],
                AdrCp = (string)reader["AdrCp"],
                AdrPays = (string)reader["AdrPays"]
            };
        }
    }
}