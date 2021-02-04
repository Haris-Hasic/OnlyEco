using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class AmbalazaStavke
    {
        public int AmbalazaStavkaID { get; set; }

        public string Naziv { get; set; }
        public int Bodovi { get; set; }
        public int Brbodova { get; set; }
        public int Kolicina { get; set; }
        public int Ukupno { get; set; }
        public int DostavljacID { get; set; }

        public int AmbalazaID { get; set; }
        public int IzlazID { get; set; }
        public int KupacID { get; set; }

    }
}
