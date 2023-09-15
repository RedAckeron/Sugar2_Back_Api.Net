using DAL.Models;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
	public static class RprDalMapper
	{
		public static RprDal DataToRprDal(this IDataRecord reader)
		{
			return new RprDal()
			{
				Id = (int)reader["id"],
				AddByUser = (int)reader["AddByUser"],
				IdCustomer = (int)reader["IdCustomer"],
				DtIn = (DateTime)reader["DtIn"],
			};
		}
		public static RprDalLight DataToRprDalLight(this IDataRecord reader)
		{
			return new RprDalLight()
			{
				Id = (int)reader["id"],
				DtIn = (DateTime)reader["DtIn"],
			};
		
		}
	}
}