using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class RprService:IRprService
    { 
    private readonly IRprRepo _rprRepo;
    public RprService(IRprRepo rprRepo)
    {
            _rprRepo = rprRepo;
    }
        
    public int Create(RprBll rprBll)
        {
            return _rprRepo.Create(RprServiceMapper.RprBllToRprDal(rprBll) );
        }

    public RprBll Read(int IdRpr)
        {
            return RprServiceMapper.RprDalToRprBll(_rprRepo.Read(IdRpr));
        }

    public int Update(RprBll rprBll) 
        {
            return _rprRepo.Update(RprServiceMapper.RprBllToRprDal(rprBll));
        }
    public int Delete(int IdOdp) 
        {
            return _rprRepo.Delete(IdOdp);
        }
    }
}
