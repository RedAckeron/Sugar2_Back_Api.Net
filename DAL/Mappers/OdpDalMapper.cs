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
	public static class OdpDalMapper
	{
		public static OdpDal DataToOdpDal(this IDataRecord reader)
		{
			return new OdpDal()
			{
				Id = (int)reader["id"],
				AddByUser = (int)reader["AddByUser"],
				IdCustomer = (int)reader["IdCustomer"],
				DtIn = (DateTime)reader["DtIn"],
			};
		}
		public static OdpDalLight DataToOdpDalLight(this IDataRecord reader)
		{
			return new OdpDalLight()
			{
				Id = (int)reader["id"],
				DtIn = (DateTime)reader["DtIn"],
			};
		
		}
	}
}