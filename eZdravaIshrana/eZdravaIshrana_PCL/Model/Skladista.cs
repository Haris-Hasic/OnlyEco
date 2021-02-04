using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class Skladista
    {
        public int SkladisteID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
