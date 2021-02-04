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
    public partial class DostavljacZakljucenDetalji : ContentPage
    {
        WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");

        WebApiHelper ambalazaService = new WebApiHelper("http://localhost:2618/", "api/AmbalazaStavke");


        public Kupci kupac { get; set; }

        WebApiHelper IzlaziService = new WebApiHelper("http://localhost:2618/", "api/Izlazi");

        private DostavljaczakljucenaDetaljiVM model = null;
        public Izlaz prosljedena { get; set; }
        public DostavljacZakljucenDetalji(Izlaz dostava)
        {
            InitializeComponent();
            BindingContext = model = new DostavljaczakljucenaDetaljiVM();
            if (model.Izlazhlp == null)
            {
                model.Izlazhlp = new Izlaz();
            }
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
            Global.Izlazhlp2.SkladisteID = prosljedena.SkladisteID;
            await Navigation.PushAsync(new MapRoutePage(hlp));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AmbalazaPovratna(prosljedena,true));
        }
    }
}