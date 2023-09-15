using ACTRL.Mappers;
using Bll.Models;
using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper;

namespace BLL.Services
{
    public class CustomerService:ICustomerService
    { 
    private readonly ICustomerRepo _customerRepo;
    private readonly IAddressRepo _adrRepo;
    private readonly ICmdRepo _cmdRepo;
    private readonly IOdpRepo _odpRepo;
    private readonly IFctRepo _fctRepo;
    private readonly IRprRepo _rprRepo;
    private readonly IDlcRepo _dlcRepo;

    
    public CustomerService(ICustomerRepo customerRepo, IAddressRepo adrRepo,ICmdRepo cmdRepo,IOdpRepo odpRepo,IFctRepo fctRepo,IRprRepo rprRepo,IDlcRepo dlcRepo)
    {
        _customerRepo = customerRepo;
        _adrRepo = adrRepo;
        _cmdRepo = cmdRepo;
        _odpRepo = odpRepo;
        _fctRepo = fctRepo;
        _dlcRepo = dlcRepo;
        _rprRepo = rprRepo;
    }
        
    public int Create(CustomerBll custBll)
        {
        return _customerRepo.Create(CustomerBllMapper.CustomerBllToCustomerDal(custBll));
        }
        
    public CustomerBll Read(int idCust)
        {
        return CustomerBllMapper.CustomerDalToCustomerBll(_customerRepo.Read(idCust));
        }
        
    public int Update(CustomerBll custBll) 
        {
        return _customerRepo.Update(CustomerBllMapper.CustomerBllToCustomerDal(custBll));
        }  

    public int Delete(int id) 
        {
           
            return _customerRepo.Delete(id);
        }

    public List<CustomerBll> FindCustomer(string cust)
        {
            return CustomerBllMapper.CustomerDalToCustomerBll(_customerRepo.FindCustomer(cust));
        }

    public List<CustomerBll> ReadLastCustomer()
        {
            return CustomerBllMapper.CustomerDalToCustomerBll(_customerRepo.ReadLastCustomer());
        }

        public CustomerSummaryBll ReadCustomerSummary(int IdCust)
        {
            CustomerSummaryBll customerSummaryBll = new CustomerSummaryBll()
            {
                IdCustomer = IdCust,
                adrLights = AdrBllMapper.AdrDalLightToAdrBllLight(_adrRepo.ReadAllAdrLight(IdCust)),
                odpLights = OdpServiceMapper.OdpDalLightToOdpBllLight(_odpRepo.ReadAllOdpLight(IdCust)),
                cmdLights = CmdServiceMapper.CmdDalLightToCmdBllLight(_cmdRepo.ReadAllCmdLight(IdCust)),
                fctLights = FctServiceMapper.FctDalLightToFctBllLight(_fctRepo.ReadAllFctLight(IdCust)),
                rprLights = RprServiceMapper.RprDalLightToRprBllLight(_rprRepo.ReadAllRprLight(IdCust)),
                dlcLights = DlcServiceMapper.DlcDalLightToDlcBllLight(_dlcRepo.ReadAllDlcLight(IdCust))
            };
         return customerSummaryBll;
        }
    }
}
