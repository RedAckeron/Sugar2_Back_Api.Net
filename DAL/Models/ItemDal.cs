using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class ItemDal
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Url { get; set; }
        public int Qt { get; set; }
        public double PrxAchat{ get; set; }
        public double PrxVente { get; set; }
        public DateTime DtIn { get; set; }
        public int AddByUser { get; set; }
    }
}