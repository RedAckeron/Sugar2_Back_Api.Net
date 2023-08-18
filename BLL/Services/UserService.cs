using BLL.Interfaces;
using BLL.Models;
using BLL.Mapper;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class UserService:IUserService
    {
    private readonly IUserRepo _userRepo;
    public UserService(IUserRepo userRepo)
    {
        _userRepo = userRepo;
    }
    public int Create(UserBll userBll)
        {
            return _userRepo.Create(UserBllMapper.UserBllToUserDal(userBll));
        }
    public UserDal Read(int IdUser)
        {
            return _userRepo.Read(IdUser);
        }
    public UserDal Login(UserBll userBll)
        {
            return _userRepo.Login(UserBllMapper.UserBllToUserDal(userBll));
        }
    public int Update(UserDal User) 
        {
            return _userRepo.Update(User);
        }
    public bool Enable(int IdUser)
        {
            return _userRepo.Enable(IdUser);
        }
    public bool Disable(int IdUser)
        {
            return _userRepo.Disable(IdUser);
        }
    public int Delete(int IdUser) 
        {
            return _userRepo.Delete(IdUser);
        }
        public int InsertRefreshToken(string email,string refreshToken,DateTime validite)
        { 
        return _userRepo.InsertFrefreshToken(email, refreshToken, validite);
        }


    }
}
