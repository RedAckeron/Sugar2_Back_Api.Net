using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Models

{
    public class CustomerBll
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Call1 { get; set; }
        public string Call2 { get; set; }
        public DateTime DtIn { get; set; }
        public int AddByUser { get; set; }
        //public IEnumerable<AddressDal> Adresses { get; set; }

    }
}
