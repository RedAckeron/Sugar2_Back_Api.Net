using DAL.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
	public static class AdrDalMapper
	{
	public static AdrDal DataToAdrDal(this IDataRecord reader)
		{
            return new AdrDal()
			{
				Id = (int)reader["id"],
				AdrInfo = (string)reader["AdrInfo"] ,
				AdrRue = (string)reader["AdrRue"],
				AdrNo = (string)reader["AdrNo"],
				AdrVille = (string)reader["AdrVille"],
				AdrCp = (string)reader["AdrCp"],
				AdrPays = (string)reader["AdrPays"]
            };
        }
        public static AdrDalLight DataToAdrDalLight(this IDataRecord reader)
        {
            return new AdrDalLight()
            {
                Id = (int)reader["id"],
				AdrInfo = (string)reader["AdrInfo"]
            };

        }
    }
}