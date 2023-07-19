using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class CustomerService:ICustomerService
    { 
    private readonly ICustomerRepo _customerRepo;
    public CustomerService(ICustomerRepo customerRepo)
    {
        _customerRepo = customerRepo;
    }

        
    public int Create(Customer cust)
        {
        return _customerRepo.Create(cust);
        }
    public Customer Read(int id)
        {
            return _customerRepo.Read(id);
        }
    public int Update(Customer cust) 
        {
           
            return _customerRepo.Update(cust);
        }  
    public int Delete(int id) 
        {
           
            return _customerRepo.Delete(id);
        }
        
    }
}
