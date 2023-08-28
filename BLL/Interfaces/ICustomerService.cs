using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
    int Create(CustomerDal cust);
    CustomerDal Read(int id_cust);
    int Update(CustomerDal cust);
    int Delete(int id);
    List<CustomerDal> FindCustomer(string cust);
    List<CustomerDal> ReadLastCustomer();
    CustomerSummaryBll ReadCustomerSummary(int IdCust);
    }
}
