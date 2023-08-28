using DAL.Models;

namespace BLL.Interfaces
{
    public interface IOdpService
    {
        int Create(OdpDal Odp);
		OdpDal Read(int IdOdp);
        int Update(OdpDal Odp);
        int Delete(int IdOdp);
        }
}