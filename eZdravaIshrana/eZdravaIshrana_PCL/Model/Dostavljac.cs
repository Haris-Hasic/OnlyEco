using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
   public  class Dostavljac
    {
        public int DostavljacID { get; set; }
        public string Naziv { get; set; }
        public string KontaktOsoba { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Fax { get; set; }
        public string Adresa { get; set; }
        public string ZiroRacuni { get; set; }
        public string Napomena { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
    }
}
