
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZdravaIshrana_Mob.ViewModels
{
    public class ANDetaljiViewModel : BaseViewModel
    {
        WebApiHelper narudzbeStavkeService = new WebApiHelper("http://localhost:2618/", "api/NarudzbaStavke");
        WebApiHelper ocjeneService = new WebApiHelper("http://localhost:2618/", "api/Ocjene");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        WebApiHelper proizvodzacService = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        WebApiHelper narudzbeServices = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        public Narudzbe Narudzbahlp { get; set; }
       
        public ObservableCollection<Proizvodi> NList { get; set; } = new ObservableCollection<Proizvodi>();
        public ANDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            Narudzbahlp=Global.aktivnaNarudzbaPrikazihlp;
            //Init();
            PonistiCommand = new Command(async () => await Ponisti());

        }

        public ICommand InitCommand { get; set; }

        public ICommand PonistiCommand { get; set; }
        public async Task Ponisti()
        {
        
        }
            public async Task Init()
        {
            HttpResponseMessage narudzaResponse;
            // GetBrojNarudzbi
            narudzaResponse = narudzbeStavkeService.GetResponse2par("GetNarudzbeStavkeCustom", Global.prijavljeniKupac.KupacID, Narudzbahlp.NarudzbaID);
           // narudzaResponse = narudzbeStavkeService.GetActionResponseID("Getprobajsada", Narudzbahlp.NarudzbaID);
          // HttpResponseMessage response = narudzbeServices.GetActionResponse("GetStavkeNarudzbe", narudzba.NarudzbaID.ToString());

            List<NarudzbaStavke> aktivne = narudzaResponse.Content.ReadAsAsync<List<NarudzbaStavke>>().Result;
          
            Narudzbahlp.NarudzbaStavke.Clear();

            foreach (var x in aktivne)
            {
                Narudzbahlp.NarudzbaStavke.Add(x);
            }
            NList.Clear();
            foreach (var y in Narudzbahlp.NarudzbaStavke)
            {
                HttpResponseMessage list;
                 list = proizvodiService.GetActionResponseID("GetProizvodiCustom", y.ProizvodID);
    
                Proizvodi Proizvod = new Proizvodi();
                Proizvod= list.Content.ReadAsAsync<Proizvodi>().Result;

                HttpResponseMessage list2;
                list2 = proizvodzacService.GetResponseID(Proizvod.ProizvodjacID);
              
                Proizvodjac proiz = list2.Content.ReadAsAsync<Proizvodjac>().Result;

                Proizvod.Proizvođač = proiz.Ime + " " + proiz.Prezime;
                NList.Add(Proizvod); 
               
            }



            HttpResponseMessage ocjeneResponse;
               
                foreach (var item in NList)
                {
                    ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", item.ProizvodID);
                    List<Ocjene> ocjene = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
                    item.Prosjecna = IzracunajProsjek(ocjene);
                item.Prosjecna = Math.Round(item.Prosjecna,1);
                }

            }

        private decimal IzracunajProsjek(List<Ocjene> ocjene)
        {
            if (ocjene.Count != 0)
            {
                decimal ukupno = 0;

                foreach (var item in ocjene)
                {
                    ukupno += item.Ocjena;
                }

                return ukupno / ocjene.Count;
            }
            else
                return 0;
        }
    }
       
    }


