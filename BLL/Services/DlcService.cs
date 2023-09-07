using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace BLL.Services
{
    public class DlcService:IDlcService
    { 
    private readonly IDlcRepo _dlcRepo;
    public DlcService(IDlcRepo dlcRepo)
    {
            _dlcRepo = dlcRepo;
    }
        
    public int Create(DlcBll dlcBll)
        {
            return _dlcRepo.Create(DlcServiceMapper.DlcBllToDlcDal(dlcBll) );
        }

    public DlcBll Read(int IdDlc)
        {
            return DlcServiceMapper.DlcDalToDlcBll(_dlcRepo.Read(IdDlc));
        }

    public int Update(DlcBll dlcBll) 
        {
            return _dlcRepo.Update(DlcServiceMapper.DlcBllToDlcDal(dlcBll));
        }
    public int Delete(int IdDlc) 
        {
            return _dlcRepo.Delete(IdDlc);
        }
    #region ReadAllDlcLight
    public List<DlcBllLight> ReadAllDlcLight(int IdCust)
    {
        return DlcServiceMapper.DlcDalLightToDlcBllLight(_dlcRepo.ReadAllDlcLight(IdCust));
    }
    #endregion
    }
}
