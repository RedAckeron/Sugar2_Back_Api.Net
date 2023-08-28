using BLL.Models;
using DAL.Models;

namespace BLL.Mappers
{
    public static class UserServiceMapper
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
        public static UserBll UserDalToUserBll(UserDal userDal)
        {
            return new UserBll()
            {
                Id = userDal.Id,
                Email = userDal.Email,
                Password = userDal.Password,
                FirstName = userDal.FirstName,
                LastName = userDal.LastName,
                DtIn = userDal.DtIn,
            };
        }
    }

   
}