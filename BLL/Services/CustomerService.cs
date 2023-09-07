using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace BLL.Services
{
    public class CustomerService:ICustomerService
    { 
    private readonly ICustomerRepo _customerRepo;
    private readonly IAddressRepo _adresseRepo;
    private readonly ICmdRepo _cmdRepo;
    private readonly IOdpRepo _odpRepo;
    private readonly IFctRepo _fctRepo;
    private readonly IRprRepo _rprRepo;
    private readonly IDlcRepo _dlcRepo;

    
    public CustomerService(ICustomerRepo customerRepo, IAddressRepo adresseRepo,ICmdRepo cmdRepo,IOdpRepo odpRepo,IFctRepo fctRepo,IDlcRepo dlcRepo)
    {
        _customerRepo = customerRepo;
        _adresseRepo = adresseRepo;
        _cmdRepo = cmdRepo;
        _odpRepo = odpRepo;
        _fctRepo = fctRepo;
        _dlcRepo = dlcRepo;
    }
        
    public int Create(CustomerDal cust)
        {
        return _customerRepo.Create(cust);
        }

    public CustomerDal Read(int id)
        {
        CustomerDal Cust = _customerRepo.Read(id);
        if (Cust!=null)Cust.Adresses = _adresseRepo.ReadCustomerAllAddress(id);

            return Cust;
        }
    public int Update(CustomerDal cust) 
        {
           
            return _customerRepo.Update(cust);
        }  
    public int Delete(int id) 
        {
           
            return _customerRepo.Delete(id);
        }
    public List<CustomerDal> FindCustomer(string cust)
        {
            return _customerRepo.FindCustomer(cust);
        }
    public List<CustomerDal> ReadLastCustomer()
        {
            return _customerRepo.ReadLastCustomer();
        }
        public CustomerSummaryBll ReadCustomerSummary(int IdCust)
        {
            CustomerSummaryBll customerSummaryBll = new CustomerSummaryBll()
            {
                IdCustomer = IdCust,
                odpLights = OdpServiceMapper.OdpDalLightToOdpBllLight(_odpRepo.ReadAllOdpLight(IdCust)),
                cmdLights = CmdServiceMapper.CmdDalLightToCmdBllLight(_cmdRepo.ReadAllCmdLight(IdCust)),
                fctLights = null,
                rprLights = null,
                dlcLights = DlcServiceMapper.DlcDalLightToDlcBllLight(_dlcRepo.ReadAllDlcLight(IdCust))
            };
         return customerSummaryBll;
        }
    }
}
