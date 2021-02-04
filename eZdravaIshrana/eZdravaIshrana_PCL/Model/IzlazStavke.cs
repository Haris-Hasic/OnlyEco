using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class IzlazStavke
    {
        public int IzlazStavkaID { get; set; }
        public int IzlazID { get; set; }
        public int ProizvodID { get; set; }
        public int Kolicina { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public string Sorta { get; set; }
        public string Vrsta { get; set; }

        public byte[] SlikaThumb { get; set; }


        public decimal Cijena { get; set; }
        public decimal Popust { get; set; }
        public bool Ocjenjeno { get; set; }

        public virtual Proizvodi Proizvodi { get; set; }

    }
}
