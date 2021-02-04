using Acr.UserDialogs;
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
    public partial class ANDetalji : ContentPage
    {
        private ANDetaljiViewModel model = null;
        public Narudzbe prosljedena { get; set; }
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");

        public ANDetalji(Narudzbe pros)
        {
            InitializeComponent();
             BindingContext = model = new ANDetaljiViewModel();
            this.Title = "Detalji narudžbe " + pros.BrojNarudzbe;
       
            prosljedena = pros;

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            LatLong hlp = new LatLong();

            hlp.Lat = Convert.ToDouble(Global.aktivnaNarudzbaPrikazihlp.Latitude);
            hlp.Lng = Convert.ToDouble(Global.aktivnaNarudzbaPrikazihlp.Longitude);
            await Navigation.PushAsync(new MapRoutePage(hlp));

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            HttpResponseMessage narudzaResponse;
  
            prosljedena.Status = false;
            prosljedena.Otkazano = true;
            narudzaResponse = narudzbeService.PutResponse(prosljedena.NarudzbaID,prosljedena);
            if (narudzaResponse.IsSuccessStatusCode)
            {
                UserDialogs.Instance.Alert("Uspjestno ste poništili narudžbu", null, "OK");
            }
            else {
                UserDialogs.Instance.Alert("Došlo je do greške", null, "OK");
            }


            await Navigation.PushAsync(new AktivneNarudzbe(1));
        }
    }
}