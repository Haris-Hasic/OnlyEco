using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace eZdravaIshrana_Mob.ViewModels
{
    public class HistorijaDetaljiVM: BaseViewModel
    {
        WebApiHelper izlaziStavkeService = new WebApiHelper("http://localhost:2618/", "api/IzlazStavke");

        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");

        WebApiHelper IzlaziService = new WebApiHelper("http://localhost:2618/", "api/Izlazi");

        WebApiHelper ambalazaService = new WebApiHelper("http://localhost:2618/", "api/Ambalaza");
        public Izlaz Izlazhlp { get; set; }

        public ObservableCollection<Proizvodi> NList { get; set; } = new ObservableCollection<Proizvodi>();
        public ObservableCollection<Ambalaza> AmbList { get; set; } = new ObservableCollection<Ambalaza>();

    
        public HistorijaDetaljiVM()
        {

          
             Izlazhlp = Global.Izlazhlp2;
            InitCommand = new Command(async () => Init());

            //Init();

        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            HttpResponseMessage IzlazistavkeResponse;

            IzlazistavkeResponse = izlaziStavkeService.GetActionResponseID("GetIzlazStavkeCustom", Izlazhlp.IzlazID);
            List<IzlazStavke> aktivne = IzlazistavkeResponse.Content.ReadAsAsync<List<IzlazStavke>>().Result;
            Izlazhlp.IzlazStavke.Clear();
            foreach (var x in aktivne)
            {
                Izlazhlp.IzlazStavke.Add(x);
            }
            NList.Clear();
            foreach (var y in Izlazhlp.IzlazStavke)
            {
                HttpResponseMessage list;
                list = proizvodiService.GetActionResponseID("GetProizvodiCustom", y.ProizvodID);
                Proizvodi Proizvod = list.Content.ReadAsAsync<Proizvodi>().Result;
                Proizvod.IzlazStavkaID = y.IzlazStavkaID;
                Proizvod.Ocjenjenohlp = !y.Ocjenjeno;

                NList.Add(Proizvod);

            }
            HttpResponseMessage list2;
            list2 = ambalazaService.GetResponse();
            List<Ambalaza> vplist = list2.Content.ReadAsAsync<List<Ambalaza>>().Result;
            AmbList.Add(new Ambalaza { AmbalazaId = 0, Naziv = "Odaberite stavku" });
            foreach (var item in vplist)
            {
                AmbList.Add(item);
            }


        
    }

}
}
