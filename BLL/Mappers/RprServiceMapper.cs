using BLL.Models;
using DAL.Models;

namespace BLL.Mappers
{
    public static class RprServiceMapper
    {
        public static RprDal RprBllToRprDal(RprBll rprBll)
        {
            return new RprDal()
            {
                AddByUser = rprBll.AddByUser,
                IdCustomer = rprBll.IdCustomer,
            };
        }
        public static RprBll RprDalToRprBll(RprDal rprDal)
		{
            return new RprBll()
            {
            Id = rprDal.Id,
            AddByUser= rprDal.AddByUser,
            IdCustomer= rprDal.IdCustomer,
            DtIn= rprDal.DtIn,
            };
		}
        public static List<RprBllLight> RprDalLightToRprBllLight(List<RprDalLight> rprDalLights)
        {
            List<RprBllLight> rprBllLights = new List<RprBllLight>();

            foreach (RprDalLight rprDalLight in rprDalLights)
            {
                rprBllLights.Add(new RprBllLight()
                {
                    Id = rprDalLight.Id,
                    DtIn = rprDalLight.DtIn,
                });
            }
            return rprBllLights;

        }
    }
}