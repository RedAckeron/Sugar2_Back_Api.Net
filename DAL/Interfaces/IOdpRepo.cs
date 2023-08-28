using DAL.Models;

namespace DAL.Interfaces
{
    public interface IOdpRepo
    {
        int Create(OdpDal Odp);
		OdpDal Read(int IdOdp);
        int Update(OdpDal Odp);
        int Delete(int IdOdp);
        int AddItemToOdp(int IdOdp, int IdItem, int Qt, int AddByUser);
        List<OdpDalLight> ReadAllOdpLight(int IdCust);

        }
}