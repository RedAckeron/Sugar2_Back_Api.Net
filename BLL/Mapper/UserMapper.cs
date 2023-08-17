using BLL.Models;
using DAL.Models;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public static class UserBllMapper
    {
		public static UserDal UserBllToUserDal(UserBll userBll)
		{
            return new UserDal()
            {
            Id = userBll.Id,
            Email=userBll.Email,
            Password=userBll.Password,
            FirstName=userBll.FirstName,
            LastName=userBll.LastName,
            DtIn=userBll.DtIn,
            };
		}
	}

   
}