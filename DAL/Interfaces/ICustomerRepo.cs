using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICustomerRepo
{
        int Create(Customer cust);
        Customer Read(int id);
        int Update(Customer cust);
        int Delete(int id);
        List<Customer> FindCustomer(string cust);
        List<Customer> ReadLastCustomer();

    }
}
