using ACTRL.Models.Forms;
using BLL.Models;
using DAL.Models;

namespace ACTRL.Mappers
{
    public static class OdpControllerMapper
    {
		public static OdpBll OdpRegisterFormToOdpBll(OdpRegisterForm odpRegisterForm)
		{
            return new OdpBll()
            {
            AddByUser= odpRegisterForm.AddByUser,
            IdCustomer= odpRegisterForm.IdCustomer,
            };
		}
      

        
    }
}