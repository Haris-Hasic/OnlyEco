using eZdravaIshrana_PCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_Mobile
{
   public class Global
    {
        public static Kupci prijavljeniKupac { get; set; }
        public static Narudzbe aktivnaNarudzba { get; set; }

        public static Ocjene ocjena { get; set; }

        public static int  proizvodID { get; set; }
    }
}
