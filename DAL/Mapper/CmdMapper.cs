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
	public static class CmdMapper
	{
		public static Cmd DataToCmd(this IDataRecord reader)
		{
			return new Cmd()
			{
				Id = (int)reader["id"],
				AddByUser = (int)reader["AddByUser"],
				IdCustomer = (int)reader["IdCustomer"],
				DtIn = (DateTime)reader["DtIn"],
			};
		}
	}
}