using DAL.Models;

namespace BLL.Interfaces
{
    public interface IOdpService
    {
        int Create(Odp Odp);
		Odp Read(int IdOdp);
        int Update(Odp Odp);
        int Delete(int IdOdp);
        }
}