using eZdravaIshrana_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_UI
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; } = new Korisnici();
       

        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("eZdravaIshrana_UI.Messages",Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }


        public static int ProizvodIDHLP { get; set; }
        public static int UlazIDHLP { get; set; } = -1;
        //public esp_UlazStavkeByUlazID_Prikazi_Result UlazStavketemp { get; set; }
        public static List<esp_UlazStavkeByUlazID_Prikazi_Result> ulazstavkeTemp { get; set; } = new List<esp_UlazStavkeByUlazID_Prikazi_Result>();
        //public static List<esp_UlazStavkeByUlazID_Prikazi_Result> UlazstavkelistHELP { get; set; }
        //public List<UlazStavke> listUlazStavketemp { get; set; }
        public static bool logout { get; set; } = false;
    }
}
