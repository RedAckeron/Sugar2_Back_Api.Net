using BLL.Interfaces;
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
        
    public int Create(User User)
        {
            return _userRepo.Create(User);
        }
    public User Read(int IdUser)
        {
            return _userRepo.Read(IdUser);
        }
    public User Login(string email,string passwd)
        {
            return _userRepo.Login(email, passwd);
        }
    public int Update(User User) 
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
    }
}
