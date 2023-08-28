using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class CustomerAddressDal
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string AdrInfo { get; set; }
        public string AdrRue { get; set; }
        public string AdrNo { get; set; }
        public string AdrVille { get; set; }
        public string AdrCp { get; set; }
        public string AdrPays { get; set; }

    }
}
