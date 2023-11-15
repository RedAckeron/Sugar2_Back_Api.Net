using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using DAL.Repositories;

namespace BLL.Services
{
    public class OdpService:IOdpService
    { 
    private readonly IOdpRepo _odpRepo;
    public OdpService(IOdpRepo odpRepo)
    {
        _odpRepo = odpRepo;
    }
        
    public int Create(OdpBll odpBll)
        {
            return _odpRepo.Create(OdpServiceMapper.OdpBllToOdpDal(odpBll));
        }

    public OdpBll Read(int IdOdp)
        {
            return OdpServiceMapper.OdpDalToOdpBll(_odpRepo.Read(IdOdp));
        }

    public int Update(OdpBll odpBll) 
        {
            return _odpRepo.Update(OdpServiceMapper.OdpBllToOdpDal(odpBll));
        } 
        
    public int Delete(int IdOdp) 
        {
            return _odpRepo.Delete(IdOdp);
        }
    #region ReadAllOdpLight
    public List<OdpBllLight> ReadAllOdpLight(int IdCust)
        {
            return OdpServiceMapper.OdpDalLightToOdpBllLight(_odpRepo.ReadAllOdpLight(IdCust));
        }
    #endregion

    #region ReadAllOdpLight
    public List<OdpBllLight> ReadLastOdpLight()
        {
            return OdpServiceMapper.OdpDalLightToOdpBllLight(_odpRepo.ReadLastOdpLight());
        }
    #endregion
    }
}
