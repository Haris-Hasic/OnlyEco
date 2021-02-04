using eZdravaIshrana_PCL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eZdravaIshrana_Mob
{
    public class Global
    {
        public static Kupci prijavljeniKupac { get; set; }
        public static Dostavljac prijavljeniDostavljac { get; set; }

        public static Narudzbe aktivnaNarudzba { get; set; } = new Narudzbe();

        public static int hlpGlobal { get; set; } = 0;

        public static ObservableCollection<NarudzbaStavke> av { get; set; } = new ObservableCollection<NarudzbaStavke>();

        public static string _udaljenosthlp { get; set; }
        public static string _vrijemethlp { get; set; }

        public static LatLong destinacijaPin { get; set; }

        public static bool CCplaceno { get; set; } = false;

        public static Narudzbe aktivnaNarudzbaPrikazihlp{ get; set; } = new Narudzbe();
        public static Izlaz Izlazhlp2 { get; set; } = new Izlaz();

        public static List<AmbalazaStavke> ambalazastavkehlp { get; set; } = new List<AmbalazaStavke>();
        public static ObservableCollection<AmbalazaStavke> AmbList2 { get; set; } = new ObservableCollection<AmbalazaStavke>();

        public static bool placanjeKarticom { get; set; } = false;
        public static int hlpambalaza { get; set; } = 0;
        public static bool popustaktivan { get; set; } = false;
    }

}
