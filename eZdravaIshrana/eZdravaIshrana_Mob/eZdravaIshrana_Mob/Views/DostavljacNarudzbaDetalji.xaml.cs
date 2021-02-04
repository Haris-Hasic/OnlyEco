using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DostavljacNarudzbaDetalji : ContentPage
    {
        WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");

        WebApiHelper ambalazaService = new WebApiHelper("http://localhost:2618/", "api/AmbalazaStavke");


        public Kupci kupac { get; set; }
     
        WebApiHelper IzlaziService = new WebApiHelper("http://localhost:2618/", "api/Izlazi");

        private DostavljacNaruDetaljiVM model = null;
        public Izlaz prosljedena { get; set; }
        public DostavljacNarudzbaDetalji(Izlaz dostava)
        {
            InitializeComponent();
            BindingContext = model = new DostavljacNaruDetaljiVM();
            if (model.Izlazhlp == null) {
                model.Izlazhlp = new Izlaz();
            }
            this.Title = "Detalji narudžbe " + dostava.BrojRacuna;
            model.Izlazhlp = dostava;
            prosljedena = dostava;
            model.Init();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
         
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            LatLong hlp = new LatLong();

            hlp.Lat = Convert.ToDouble(prosljedena.Latitude);
            hlp.Lng = Convert.ToDouble(prosljedena.Longitude);
            await Navigation.PushAsync(new MapRoutePage(hlp));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //IzlazByID
            HttpResponseMessage izlazResponse;
            izlazResponse = IzlaziService.GetActionResponseID("IzlazByID", prosljedena.IzlazID);
            Izlaz Iz = new Izlaz();
            Iz=izlazResponse.Content.ReadAsAsync<Izlaz>().Result;
            Iz.Zakljucen = true;
            izlazResponse = IzlaziService.PutResponse(Iz.IzlazID, Iz);

            HttpResponseMessage response;
            response = kupciService.GetResponseID(prosljedena.KupacID);
            kupac = response.Content.ReadAsAsync<Kupci>().Result;
            int ukupnohlp = 0;

            if (Global.AmbList2.Count() > 0) { 
            foreach (var x in Global.AmbList2)
            {
                ambalazaService.PostResponse(x);
                ukupnohlp += x.Ukupno;
            }
            kupac.Bodovi = kupac.Bodovi + ukupnohlp;
            kupciService.PutResponse(kupac.KupacID, kupac);
                Global.AmbList2.Clear();
            await DisplayAlert("Narudžba dostavljena", "Uspjesno ste zaključili narudžbu", "OK");
            }

            await DisplayAlert("Narudžba dostavljena", "Uspjesno ste zaključili narudžbu", "OK");
            await Navigation.PopToRootAsync();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AmbalazaPovratna(prosljedena));
        }
    }
}