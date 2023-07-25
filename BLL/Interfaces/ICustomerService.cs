using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
    int Create(Customer cust);
    int CreateAdresse(CustomerAdresse CustAdr);
    Customer Read(int id_cust);
    int Update(Customer cust);
    int Delete(int id);
    List<Customer> FindCustomer(string cust);
    }
}
