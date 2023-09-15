using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models

{
    public class AddressBll
    {
        public int Id { get; set; }
        public string AdrInfo { get; set; }
        public string AdrRue { get; set; }
        public string AdrNo { get; set; }
        public string AdrVille { get; set; }
        public string AdrCp { get; set; }
        public string AdrPays { get; set; }

    }
    public class AdrBllLight
    {
        public int Id { get; set; }
        public string AdrInfo { get; set;}
    }
}
