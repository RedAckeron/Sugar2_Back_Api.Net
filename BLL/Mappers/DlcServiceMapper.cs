using BLL.Models;
using DAL.Models;

namespace BLL.Mappers
{
    public static class DlcServiceMapper
    {
        public static DlcDal DlcBllToDlcDal(DlcBll dlcBll)
        {
            return new DlcDal()
            {
                AddByUser = dlcBll.AddByUser,
                IdCustomer = dlcBll.IdCustomer,
            };
        }
        public static DlcBll DlcDalToDlcBll(DlcDal dlcDal)
		{
            return new DlcBll()
            {
            Id = dlcDal.Id,
            AddByUser= dlcDal.AddByUser,
            IdCustomer= dlcDal.IdCustomer,
            DtIn= dlcDal.DtIn,
            };
		}

        public static List<DlcBllLight> DlcDalLightToDlcBllLight(List<DlcDalLight> dlcDalLights)
        {
            List<DlcBllLight> dlcBllLights = new List<DlcBllLight>();

            foreach (DlcDalLight dlcDalLight in dlcDalLights)
            {
                dlcBllLights.Add(new DlcBllLight()
                {
                    Id = dlcDalLight.Id,
                    DtIn = dlcDalLight.DtIn,
                });
            }
            return dlcBllLights;

        }
    }
}