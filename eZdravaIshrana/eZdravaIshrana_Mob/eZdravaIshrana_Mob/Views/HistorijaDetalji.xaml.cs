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
    public partial class HistorijaDetalji : ContentPage
    {
        WebApiHelper proizvodService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        private HistorijaDetaljiVM model = null;
        public Izlaz b;
        public HistorijaDetalji(Izlaz a)
        {
            InitializeComponent();
            this.Title = "Detalji historije narudžbe " + a.BrojRacuna;
            BindingContext = model = new HistorijaDetaljiVM();
            model.Izlazhlp = a;
            b = a;
            OcjenaDostavljacaButton.IsVisible = !a.DostavljacOcjenjen;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Proizvodi;
           
            // model.NList.Remove(item);
            HttpResponseMessage Response;
            // GetBrojNarudzbi
            //Response = proizvodService.GetResponseID(item.ProizvodID);
            //Proizvodi aktivne = Response.Content.ReadAsAsync<Proizvodi>().Result;
            await Navigation.PushAsync(new ProizvodiDetalji2(item));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            LatLong hlp = new LatLong();

            hlp.Lat = Convert.ToDouble(b.Latitude);
            hlp.Lng = Convert.ToDouble(b.Longitude);
            await Navigation.PushAsync(new MapRoutePage(hlp));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AmbalazaPovratna(b,true));
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DostavljacOcjena(b));
        }
    }
}