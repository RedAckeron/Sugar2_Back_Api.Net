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
	public static class FctDalMapper
	{
		public static FctDal DataToFctDal(this IDataRecord reader)
		{
			return new FctDal()
			{
				Id = (int)reader["id"],
				AddByUser = (int)reader["AddByUser"],
				IdCustomer = (int)reader["IdCustomer"],
				DtIn = (DateTime)reader["DtIn"],
			};
		}
		public static FctDalLight DataToFctDalLight(this IDataRecord reader)
		{
			return new FctDalLight()
			{
				Id = (int)reader["id"],
				DtIn = (DateTime)reader["DtIn"],
			};
		
		}
	}
}