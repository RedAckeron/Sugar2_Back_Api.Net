using ACTRL.Models.Forms;
using BLL.Models;

namespace ACTRL.Mappers
{
    public static class RprControllerMapper
    {
		public static RprBll RprRegisterFormToRprBll(RprRegisterForm rprRegisterForm)
		{
            return new RprBll()
            {
            AddByUser= rprRegisterForm.AddByUser,
            IdCustomer= rprRegisterForm.IdCustomer,
            };
		}
    }
}