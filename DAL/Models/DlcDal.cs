﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models

{
    public class DlcDal
    {
        public int Id { get; set; }
        public int AddByUser { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DtIn{ get; set; }
    }
    public class DlcDalLight
    {
        public int Id { get; set; }
        public DateTime DtIn { get; set; }

    }
}