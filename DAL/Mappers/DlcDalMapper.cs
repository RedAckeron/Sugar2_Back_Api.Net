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
	public static class DlcDalMapper
	{
		public static DlcDal DataToDlcDal(this IDataRecord reader)
		{
			return new DlcDal()
			{
				Id = (int)reader["id"],
				AddByUser = (int)reader["AddByUser"],
				IdCustomer = (int)reader["IdCustomer"],
				DtIn = (DateTime)reader["DtIn"],
			};
		}
		public static DlcDalLight DataToDlcDalLight(this IDataRecord reader)
		{
			return new DlcDalLight()
			{
				Id = (int)reader["id"],
				DtIn = (DateTime)reader["DtIn"],
			};
		
		}
      
    }
}