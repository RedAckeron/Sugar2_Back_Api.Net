using DAL.Models;

namespace DAL.Interfaces
{
    public interface IOdpRepo
    {
        int Create(Odp Odp);
		Odp Read(int IdOdp);
        int Update(Odp Odp);
        int Delete(int IdOdp);
        }
}