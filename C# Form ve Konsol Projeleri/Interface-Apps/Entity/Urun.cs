using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Apps.Entity
{
    public class Urun : IEntity
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }

    }
}
