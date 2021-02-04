using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZdravaIshrana_PCL.Model
{
    public class Izlaz
    {
        public Izlaz()
        {
            this.IzlazStavke = new ObservableCollection<IzlazStavke>();
        }

        public int NarudzbaID { get; set; }
        public int IzlazID { get; set; }

        public int SkladisteID { get; set; } //hlp
        public string BrojRacuna { get; set; }
        public int KupacID { get; set; }
        public int DostavljacID { get; set; }
        public bool DostavljacOcjenjen { get; set; }
        public string Dostavljac { get; set; }
        public int KorisnikID { get; set; }
        public System.DateTime Datum { get; set; }
        public string DatumPrikaz { get; set; }
        public bool Zakljucen { get; set; }

        public string Korisnik { get; set; }
        public string UdaljenostRute { get; set; }
        public string VrijemeRute { get; set; }
        public decimal IznosSaPDV { get; set; }
        public decimal IznosBezPDV { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool PayByCard { get; set; }
        public string PayByCardString { get; set; }
        public string Adresa { get; set; }

        public int BrojStavki { get; set; }

        public Nullable<decimal> Iznos { get; set; }
        public Nullable<int> Broj_stavki { get; set; }

        //public string  Adresa { get; set; }
        //public int Brojstavki { get; set; }
        public decimal Ukupno { get; set; }
        public ObservableCollection<IzlazStavke> IzlazStavke { get; set; }
    }
}

