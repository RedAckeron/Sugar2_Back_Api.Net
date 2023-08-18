using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepo
    {
        int Create(UserDal Userdal);
        UserDal Read(int id);
        UserDal Login(UserDal Userdal);
        int Update(UserDal cust);
        bool Enable(int IdUser);
        bool Disable(int IdUser);
        int Delete(int id);
        int InsertFrefreshToken(string email, string refreshToken, DateTime validite);
        }
    }