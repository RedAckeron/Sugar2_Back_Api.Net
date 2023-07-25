using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICustomerAdresseRepo
{
        int Create(CustomerAdresse custAdr);
        
        //CustomerAdresse Read(int id);
        List<CustomerAdresse> ReadAllOfCustomer(int IdCust);
        //int Update(Customer cust);
        //int Delete(int id);
        //List<Customer> FindCustomer(string cust);
        }
}
