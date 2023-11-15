using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class OdpDal
    {
        public int Id { get; set; }
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
        public List<ItemDal> Basket { get; set; }
    }
    public class OdpDalLight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DtIn { get; set; }
        //public int NbItem { get; set; } = 0;
        //public int PrxTtl { get; set; } = 0;
    }
}