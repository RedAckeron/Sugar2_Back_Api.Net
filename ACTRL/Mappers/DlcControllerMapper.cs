using ACTRL.Models.Forms;
using BLL.Models;

namespace ACTRL.Mappers
{
    public static class DlcControllerMapper
    {
		public static DlcBll DlcRegisterFormToDlcBll(DlcRegisterForm dlcRegisterForm)
		{
            return new DlcBll()
            {
            AddByUser= dlcRegisterForm.AddByUser,
            IdCustomer= dlcRegisterForm.IdCustomer,
            };
		}
    }
}