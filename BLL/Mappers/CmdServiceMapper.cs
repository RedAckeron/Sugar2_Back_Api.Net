using BLL.Models;
using DAL.Models;
using System.Data;

namespace BLL.Mappers
{
    public static class CmdServiceMapper
    {
		public static CmdBll CmdDalToCmdBll(CmdDal cmdDal)
		{
            return new CmdBll()
            {
            Id = cmdDal.Id,
            IdOdp=cmdDal.IdOdp,
            AddByUser=cmdDal.AddByUser,
            IdCustomer=cmdDal.IdCustomer,
            DtIn=cmdDal.DtIn,
            Basket=cmdDal.Basket
            };
		}
        public static CmdDal CmdBllToCmdDal(CmdBll cmdBll)
        {
            return new CmdDal()
            {
                Id = cmdBll.Id,
                IdOdp = cmdBll.IdOdp,
                AddByUser = cmdBll.AddByUser,
                IdCustomer = cmdBll.IdCustomer,
                DtIn = cmdBll.DtIn,
                Basket = cmdBll.Basket
            };
        }
       /*
        public static List<CmdDalLight> CmdBllLightToCmdDalLight(List<CmdBllLight> cmdBllLights)
        {
            List<CmdDalLight> cmdDalLights = new List<CmdDalLight>();

            foreach (CmdBllLight cmdBllLight in cmdBllLights)
            {
                cmdDalLights.Add(new CmdDalLight() { 
                Id = cmdBllLight.Id,
                DtIn= cmdBllLight.DtIn,
                });
            }
             return cmdDalLights;
        }
       */
        public static List<CmdBllLight> CmdDalLightToCmdBllLight(List<CmdDalLight> cmdDalLights)
        {
            List<CmdBllLight> cmdBllLights = new List<CmdBllLight>();

            foreach (CmdDalLight cmdDalLight in cmdDalLights)
            {
                cmdBllLights.Add(new CmdBllLight()
                {
                    Id = cmdDalLight.Id,
                    DtIn = cmdDalLight.DtIn,
                });
            }
            return cmdBllLights;

        }
    }
}