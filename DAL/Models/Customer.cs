using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DtIn { get; set; }
        public int AddByUser { get; set; }
        public IEnumerable<CustomerAddress> Adresses { get; set; }

    }
}
