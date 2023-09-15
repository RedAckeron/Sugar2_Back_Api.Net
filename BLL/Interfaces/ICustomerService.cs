using Bll.Models;
using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
    int Create(CustomerBll cust);
    CustomerBll Read(int id_cust);
    int Update(CustomerBll cust);
    int Delete(int id);
    List<CustomerBll> FindCustomer(string cust);
    List<CustomerBll> ReadLastCustomer();
    CustomerSummaryBll ReadCustomerSummary(int IdCust);
    }
}