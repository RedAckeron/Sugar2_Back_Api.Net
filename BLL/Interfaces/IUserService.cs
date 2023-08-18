using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        int Create(UserBll UserBll);
        UserDal Read(int IdUser);
        UserDal Login(UserBll UserBll);
        int Update(UserDal User);
        bool Enable(int IdUser);
        bool Disable(int IdUser);
        int Delete(int IdUser);
        int InsertRefreshToken(string email,string refreshToken,DateTime validite);
        }
}
