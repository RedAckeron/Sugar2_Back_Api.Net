using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class FctService:IFctService
    { 
    private readonly IFctRepo _fctRepo;
    public FctService(IFctRepo fctRepo)
    {
        _fctRepo = fctRepo;
    }
        
    public int Create(FctBll fctBll)
        {
            return _fctRepo.Create(FctServiceMapper.FctBllToFctDal(fctBll));
        }
    public FctBll Read(int IdFct)
        {
            return FctServiceMapper.FctDalToFctBll(_fctRepo.Read(IdFct));
        }

    public int Update(FctBll fctBll) 
        {
            return _fctRepo.Update(FctServiceMapper.FctBllToFctDal(fctBll));
        }  
    public int Delete(int IdFct) 
        {
            return _fctRepo.Delete(IdFct);
        }
    }
}
