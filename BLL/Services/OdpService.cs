using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class OdpService:IOdpService
    { 
    private readonly IOdpRepo _odpRepo;
    public OdpService(IOdpRepo odpRepo)
    {
        _odpRepo = odpRepo;
    }
        
    public int Create(Odp Odp)
        {
            return _odpRepo.Create(Odp);
        }
    public Odp Read(int IdOdp)
        {
            return _odpRepo.Read(IdOdp);
        }

    public int Update(Odp Odp) 
        {
            return _odpRepo.Update(Odp);
        }  
    public int Delete(int IdOdp) 
        {
            return _odpRepo.Delete(IdOdp);
        }
    }
}
