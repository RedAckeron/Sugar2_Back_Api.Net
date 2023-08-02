using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BLL.Services
{
    public class CustomerService:ICustomerService
    { 
    private readonly ICustomerRepo _customerRepo;
    private readonly IAddressRepo _adresseRepo;
    public CustomerService(ICustomerRepo customerRepo, IAddressRepo adresseRepo)
    {
        _customerRepo = customerRepo;
            _adresseRepo = adresseRepo;
    }
        
    public int Create(Customer cust)
        {
        return _customerRepo.Create(cust);
        }

    public Customer Read(int id)
        {
            Customer Cust = _customerRepo.Read(id);
            Cust.Adresses = _adresseRepo.ReadCustomerAllAddress(id);

            return Cust;
        }
    public int Update(Customer cust) 
        {
           
            return _customerRepo.Update(cust);
        }  
    public int Delete(int id) 
        {
           
            return _customerRepo.Delete(id);
        }
    public List<Customer> FindCustomer(string cust)
        {
            return _customerRepo.FindCustomer(cust);
        }
      
    }
}
