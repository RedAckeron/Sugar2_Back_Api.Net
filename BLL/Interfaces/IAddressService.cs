using DAL.Interfaces;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IAddressService
    {
    int CreateCustomerAddress(CustomerAddress Adr);
    CustomerAddress ReadCustomerAddress(int idAdr);
    List<CustomerAddress> ReadCustomerAllAddress(int idCust);
    int UpdateCustomerAddress(CustomerAddress Adr);
    int DeleteCustomerAddress(int id_Adr);

    int CreateUserAddress(UserAddress Adr);
    UserAddress ReadUserAddress(int id_Adr);
    int UpdateUserAddress(UserAddress Adr);
    int DeleteUserAddress(int id_Adr);
    }
}
