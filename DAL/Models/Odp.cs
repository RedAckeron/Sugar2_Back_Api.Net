using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class Odp
    {
        public int Id { get; set; }
        public string AddByUser { get; set; }
        public string IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
    }
}