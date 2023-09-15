using ACTRL.Models.Forms;
using BLL.Models;

namespace ACTRL.Mappers
{
    public static class AdrControllerMapper
    {
		public static AddressBll AddressFormToAddressBll(AddressForm adrForm)
		{
            return new AddressBll()
            {
                Id = adrForm.Id,
                AdrInfo = adrForm.AdrInfo,
                AdrRue = adrForm.AdrRue,
                AdrNo = adrForm.AdrNo,
                AdrVille = adrForm.AdrVille,
                AdrCp= adrForm.AdrCp,
                AdrPays = adrForm.AdrPays
          
            };
		}
    }
}