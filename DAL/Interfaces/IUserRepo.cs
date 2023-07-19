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
        int Create(User cust);
        User Read(int id);
        User Login(string email, string passwd);
        int Update(User cust);
        bool Enable(int IdUser);
        bool Disable(int IdUser);
        int Delete(int id);
        }
    }