using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CustomerSummaryDal
    {
        public int IdCustomer { get; set; }
        public int QtAdr { get; set; } = 0;

        public int QtOdp { get; set; } = 0;
        public int QtCmd { get; set; } = 0;
        public int QtFct { get; set; } = 0;
        public int QtRpr { get; set; } = 0;
        public int QtDlc { get; set; } = 0;
    }
}
