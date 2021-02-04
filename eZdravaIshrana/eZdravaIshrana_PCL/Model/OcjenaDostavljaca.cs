using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class OcjenaDostavljaca
    {
        public int OcjenaDostavljacaID { get; set; }
        public int DostavljacID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
