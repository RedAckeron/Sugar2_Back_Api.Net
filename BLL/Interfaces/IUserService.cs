using DAL.Models;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        int Create(User User);
        User Read(int IdUser);
        User Login(string Email, string Passwd);
        int Update(User User);
        bool Enable(int IdUser);
        bool Disable(int IdUser);
        int Delete(int IdUser);
        }
}
