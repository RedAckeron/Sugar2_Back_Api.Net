using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAddressRepo
    {
        int CreateCustomerAddress(CustomerAddressDal Adr);
        CustomerAddressDal ReadCustomerAddress(int IdAdr);
        List<CustomerAddressDal> ReadCustomerAllAddress(int IdCustomer);
        int UpdateCustomerAddress(CustomerAddressDal Adr);
        int DeleteCustomerAddress(int IdAdr);
        int CreateUserAddress(UserAddressDal Adr);
        UserAddressDal ReadUserAddress(int IdAdr);
        List<UserAddressDal> ReadAllOfUserAddress(int IdUser);
        int UpdateUserAddress(UserAddressDal Adr);
        int DeleteUserAddress(int IdAdr);
    }
}
