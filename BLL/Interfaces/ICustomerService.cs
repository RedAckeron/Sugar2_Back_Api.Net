using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
    int Create(Customer cust);
    Customer Read(int id_cust);
    int Update(Customer cust);
    int Delete(int id);
    List<Customer> FindCustomer(string cust);
    List<Customer> ReadLastCustomer();
    }
}
