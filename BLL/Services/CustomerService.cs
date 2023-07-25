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
    private readonly ICustomerAdresseRepo _customerAdresseRepo;
    public CustomerService(ICustomerRepo customerRepo, ICustomerAdresseRepo customerAdresseRepo)
    {
        _customerRepo = customerRepo;
        _customerAdresseRepo= customerAdresseRepo;
    }

        
    public int Create(Customer cust)
        {
        return _customerRepo.Create(cust);
        }

        public int CreateAdresse(CustomerAdresse CustAdr)
        {
            return _customerAdresseRepo.Create(CustAdr);
        }
    public Customer Read(int id)
        {
            Customer Cust = _customerRepo.Read(id);
            Cust.Adresses = _customerAdresseRepo.ReadAllOfCustomer(id);

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
