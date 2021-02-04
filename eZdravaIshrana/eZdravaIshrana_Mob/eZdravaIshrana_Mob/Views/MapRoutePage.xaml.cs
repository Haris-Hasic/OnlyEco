using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;


namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapRoutePage : ContentPage
    {

        WebApiHelper skladistaService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        public ObservableCollection<Skladista> skladistalist { get; set; } = new ObservableCollection<Skladista>();
        RouteViewModel mapaPins;
        HttpResponseMessage response;
        bool IsPin = false;

        bool prikaz = false;
        public MapRoutePage()
        {
            InitializeComponent();

            BindingContext = mapaPins = new RouteViewModel();
            RouteViewModel.mapa = mapa;
            mapaPins.Destinacija = new LatLong();


            double zoomLevel = 15;
            double latlongDegrees = 360 / (Math.Pow(2, zoomLevel));
            mapa.MoveToRegion(new MapSpan(new Position(43.3438, 17.8078), latlongDegrees, latlongDegrees));
           
            Udaljenost.BindingContext = mapaPins;
            Vrijeme.BindingContext = mapaPins;
            cmbSkladiste.SelectedIndex = 0;
            Global.aktivnaNarudzba.SkladisteID = ((Skladista)cmbSkladiste.SelectedItem).SkladisteID;
        }

        public MapRoutePage(LatLong pregled)
        {
            InitializeComponent();
            int a = 0;
            BindingContext = mapaPins = new RouteViewModel();
            RouteViewModel.mapa = mapa;
            mapaPins.Destinacija = new LatLong();
            a =Global.aktivnaNarudzbaPrikazihlp.SkladisteID;
            if(a==0)
                a = Global.Izlazhlp2.SkladisteID;
            response = skladistaService.GetResponseID(a);
            Skladista  aktivne = response.Content.ReadAsAsync<Skladista>().Result;

            if (Global.destinacijaPin == null)
            {
                Global.destinacijaPin = new LatLong();
            }
            mapaPins.Destinacija.Lng = Convert.ToDouble(pregled.Lat);
            mapaPins.Destinacija.Lat = Convert.ToDouble(pregled.Lng);
            mapaPins.Skladiste.Lat = Convert.ToDouble(aktivne.Latitude);
            mapaPins.Skladiste.Lng = Convert.ToDouble(aktivne.Longitude);
            double zoomLevel = 15;
            double latlongDegrees = 360 / (Math.Pow(2, zoomLevel));
            mapa.MoveToRegion(new MapSpan(new Position(pregled.Lat, pregled.Lng), latlongDegrees, latlongDegrees));
           
            Udaljenost.BindingContext = mapaPins;
            Vrijeme.BindingContext = mapaPins;
            cmbSkladiste.IsVisible = false;
            lblskladiste.Text = "Kliknite na button Izracunaj rutu da vidite vasu rutu za ovu narudžbu";
            SaveButton.IsVisible = false;
            prikaz = true;


        }

        private void BindSkladista()
        {
            HttpResponseMessage list = skladistaService.GetResponse();
            List<Skladista> ProizvodiList1 = list.Content.ReadAsAsync<List<Skladista>>().Result;
            foreach (var x in ProizvodiList1)
            {
                skladistalist.Add(x);
            }
            cmbSkladiste.ItemsSource = skladistalist;
        }

        void mapa_MapClicked(object sender, MapClickedEventArgs e)
        {
            if (prikaz == false) { 
            if (mapaPins.Destinacija == null)
            {
                mapaPins.Destinacija = new LatLong();
            }
            mapaPins.AddLocation(e.Position.Latitude,
            e.Position.Longitude);
            if (Global.destinacijaPin == null)
                Global.destinacijaPin = new LatLong();
            Global.destinacijaPin.Lat = e.Position.Latitude;
            Global.destinacijaPin.Lng = e.Position.Longitude;
            IsPin = true;
            mapaPins.Destinacija.Lat = e.Position.Longitude;
            mapaPins.Destinacija.Lng = e.Position.Latitude;
            mapaPins.Skladiste.Lat = Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Latitude);
            mapaPins.Skladiste.Lng = Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Longitude);

            }

        }

        private void cmbSkladiste_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Longitude) != null && Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Latitude) != null)
            {
                double zoomLevel = 15;
                double latlongDegrees = 360 / (Math.Pow(2, zoomLevel));
                mapa.MapElements.Clear();
                if (IsPin == true)
                {
                    IsPin = false;
                    mapaPins.RemoveLastPin();
                    mapaPins.RouteDistance = "0";
                    mapaPins.RouteDuration = "0";
                    Global.aktivnaNarudzba.UdaljenostRute = "0";
                    Global.aktivnaNarudzba.VrijemeRute = "0";


                }
                Global.aktivnaNarudzba.SkladisteID = ((Skladista)cmbSkladiste.SelectedItem).SkladisteID;
                mapa.MoveToRegion(new MapSpan(new Position(Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Longitude), Convert.ToDouble(((Skladista)(cmbSkladiste.SelectedItem)).Latitude)), latlongDegrees, latlongDegrees));

            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
           
            if (mapaPins.Destinacija.Lat == 0 || mapaPins.Destinacija.Lng == 0 || mapaPins.RouteDistance=="0")
                await DisplayAlert("Izaberite rutu", "Ruta nije izabrana", "OK");
            else
            {
                await Navigation.PushAsync(new NarudzbaDetalji());

             }

        }
    }
}
