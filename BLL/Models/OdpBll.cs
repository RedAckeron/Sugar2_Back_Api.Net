using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models

{
    public class OdpBll
	{
        public int Id { get; set; }
        public int IdOdp { get; set; } = 0;
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
        public List<ItemDal> Basket { get; set; }
    }
    public class OdpBllLight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DtIn { get; set; }
        public int NbItem { get; set; }
        public int PrxTtl { get; set; }
    }
}