using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class Proizvodi
    {
        public int ProizvodID { get; set; }
        public int IzlazStavkaID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string Vrsta { get; set; }
        public string Sorta { get; set; }
        public string Proizvođač { get; set; }
        public bool Ocjenjenohlp { get; set; }

        public int ProizvodjacID { get; set; }
        public decimal Prosjecna { get; set; }
    }
}
