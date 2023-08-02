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
        int CreateCustomerAddress(CustomerAddress Adr);
        CustomerAddress ReadCustomerAddress(int IdAdr);
        List<CustomerAddress> ReadCustomerAllAddress(int IdCustomer);
        int UpdateCustomerAddress(CustomerAddress Adr);
        int DeleteCustomerAddress(int IdAdr);
        int CreateUserAddress(UserAddress Adr);
        UserAddress ReadUserAddress(int IdAdr);
        List<UserAddress> ReadAllOfUserAddress(int IdUser);
        int UpdateUserAddress(UserAddress Adr);
        int DeleteUserAddress(int IdAdr);
    }
}
