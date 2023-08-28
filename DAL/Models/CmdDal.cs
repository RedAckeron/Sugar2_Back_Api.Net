using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class CmdDal
	{
        public int Id { get; set; }
        public int IdOdp { get; set; } = 0;
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
        public List<ItemDal> Basket { get; set; }
    }
    public class CmdDalLight
    {
        public int Id { get; set; }
        public DateTime DtIn { get; set; }

    }
}