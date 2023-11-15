using BLL.Models;
using DAL.Models;
using System.Data;

namespace BLL.Mappers
{
    public static class OdpServiceMapper
    {
        public static OdpDal OdpBllToOdpDal(OdpBll odpBll)
        {
            return new OdpDal()
            {
                Id = odpBll.Id,
                AddByUser = odpBll.AddByUser,
                IdCustomer = odpBll.IdCustomer,
                DtIn = odpBll.DtIn,
                Basket = odpBll.Basket
            };
        }
        public static OdpBll OdpDalToOdpBll(OdpDal odpDal)
		{
            return new OdpBll()
            {
            Id = odpDal.Id,
            AddByUser= odpDal.AddByUser,
            IdCustomer= odpDal.IdCustomer,
            DtIn= odpDal.DtIn,
            Basket= odpDal.Basket
            };
		}
      

        public static List<OdpBllLight> OdpDalLightToOdpBllLight(List<OdpDalLight> odpDalLights)
        {
            List<OdpBllLight> odpBllLights = new List<OdpBllLight>();

            foreach (OdpDalLight odpDalLight in odpDalLights)
            {
                odpBllLights.Add(new OdpBllLight()
                {
                    Id = odpDalLight.Id,
                    Name = odpDalLight.Name,
                    DtIn = odpDalLight.DtIn,
                    //PrxTtl= odpDalLight.PrxTtl,
                    //NbItem= odpDalLight.NbItem
                });
            }
            return odpBllLights;
        }
    }
}