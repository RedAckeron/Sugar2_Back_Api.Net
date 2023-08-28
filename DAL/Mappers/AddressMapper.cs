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
	public static CustomerAddressDal DataToCustomerAdresse(this IDataRecord reader)
		{
			return new CustomerAddressDal()
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

        public static UserAddressDal DataToUserAdresse(this IDataRecord reader)
        {
            return new UserAddressDal()
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