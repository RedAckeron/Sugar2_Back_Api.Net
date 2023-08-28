using ACTRL.Models.Forms;
using BLL.Models;

namespace ACTRL.Mappers
{
    public static class CmdControllerMapper
    {
		public static CmdBll CmdRegisterFormToCmdBll(CmdRegisterForm cmdRegisterForm)
		{
            return new CmdBll()
            {
            AddByUser= cmdRegisterForm.AddByUser,
            IdCustomer= cmdRegisterForm.IdCustomer,
            };
		}
      

        
    }
}