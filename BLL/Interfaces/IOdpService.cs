using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IOdpService
    {
        int Create(OdpBll OdpBll);
        OdpBll Read(int IdOdp);
        int Update(OdpBll OdpBll);
        int Delete(int IdOdp);
        List<OdpBllLight> ReadAllOdpLight(int IDCust);
        List<OdpBllLight> ReadLastOdpLight();

    }
}