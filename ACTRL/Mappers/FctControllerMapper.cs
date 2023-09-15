using ACTRL.Models.Forms;
using BLL.Models;

namespace ACTRL.Mappers
{
    public static class FctControllerMapper
    {
		public static FctBll FctRegisterFormToCmdBll(FctRegisterForm fctRegisterForm)
		{
            return new FctBll()
            {
            AddByUser= fctRegisterForm.AddByUser,
            IdCustomer= fctRegisterForm.IdCustomer,
            };
		}
      

        
    }
}