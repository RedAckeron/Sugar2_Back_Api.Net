using DAL.Interfaces;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IAddressService
    {
    int CreateCustomerAddress(CustomerAddressDal Adr);
    CustomerAddressDal ReadCustomerAddress(int idAdr);
    List<CustomerAddressDal> ReadCustomerAllAddress(int idCust);
    int UpdateCustomerAddress(CustomerAddressDal Adr);
    int DeleteCustomerAddress(int id_Adr);

    int CreateUserAddress(UserAddressDal Adr);
    UserAddressDal ReadUserAddress(int id_Adr);
    int UpdateUserAddress(UserAddressDal Adr);
    int DeleteUserAddress(int id_Adr);
    }
}
