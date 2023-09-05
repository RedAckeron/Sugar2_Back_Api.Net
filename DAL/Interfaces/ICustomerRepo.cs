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
        int Create(CustomerDal cust);
        CustomerDal Read(int id);
        int Update(CustomerDal cust);
        int Delete(int id);
        List<CustomerDal> FindCustomer(string cust);
        List<CustomerDal> ReadLastCustomer();
        //CustomerSummaryDal ReadCustomerSummary(int IdCust);
    }
}
