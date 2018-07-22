﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EF_IVT.Entities
{
    public class Siparis
    {
        public Guid ID { get; set; }
        public Guid UrunID { get; set; }
        public decimal SatisFiyat { get; set; }
        public int Adet { get; set; }
        public int Durum { get; set; }
        public DateTime OlusturmaTarih { get; set; }

        // 1-N
        public Urun urun { get; set; }
    }
}
