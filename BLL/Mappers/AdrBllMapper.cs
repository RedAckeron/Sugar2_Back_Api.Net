using BLL.Models;
using DAL.Models;

namespace ACTRL.Mappers
{
    public static class AdrBllMapper
    {
		public static AdrDal AddressBllToAddressDal(AddressBll adrBll)
		{
            return new AdrDal()
            {
                Id = adrBll.Id,
                AdrInfo = adrBll.AdrInfo,
                AdrRue = adrBll.AdrRue,
                AdrNo = adrBll.AdrNo,
                AdrVille = adrBll.AdrVille,
                AdrCp= adrBll.AdrCp,
                AdrPays = adrBll.AdrPays
          
            };
		}

        public static AddressBll AddressDalToAddressBll(AdrDal adrDal)
        {
            return new AddressBll()
            {
                Id = adrDal.Id,
                AdrInfo = adrDal.AdrInfo,
                AdrRue = adrDal.AdrRue,
                AdrNo = adrDal.AdrNo,
                AdrVille = adrDal.AdrVille,
                AdrCp = adrDal.AdrCp,
                AdrPays = adrDal.AdrPays

            };
        }
        public static List<AdrBllLight> AdrDalLightToAdrBllLight(List<AdrDalLight> adrDalLights)
        {
            List<AdrBllLight> adrBllLights = new List<AdrBllLight>();

            foreach (AdrDalLight adrDalLight in adrDalLights)
            {
                adrBllLights.Add(new AdrBllLight()
                {
                    Id = adrDalLight.Id,
                    AdrInfo= adrDalLight.AdrInfo,
                });
            }
            return adrBllLights;

        }
    }
}