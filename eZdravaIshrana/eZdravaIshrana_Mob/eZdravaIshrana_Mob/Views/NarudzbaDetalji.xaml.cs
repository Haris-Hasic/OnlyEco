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
    public partial class NarudzbaDetalji : ContentPage
    {
        WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        decimal ukupno = 0;
        double ukupno2 = 0;
        double CPDV = 0;
        bool popust = false;
        public NarudzbaDetalji()
        {
            InitializeComponent();

            UcitajLabele();

        }

        private void UcitajLabele()
        {
            HttpResponseMessage skladisteResponse;
            if (Global.prijavljeniKupac.Bodovi >= 50)
            {
                slika.IsVisible = false;
                bodovigrid.IsVisible = true;
                popustlbl.IsVisible = true;
                popustlbl2.IsVisible = true;

                korisnikbodovi.Text = Global.prijavljeniKupac.Bodovi.ToString();
                korisnikbodovinovo.Text = (Global.prijavljeniKupac.Bodovi - 50).ToString();
            }
            else {
                bodovigrid.IsVisible = false;
                popustlbl.IsVisible = false;
                popustlbl2.IsVisible = true;

            }
            skladisteResponse = skladisteService.GetResponseID(Global.aktivnaNarudzba.SkladisteID);
            Skladista skladisteprikaz = skladisteResponse.Content.ReadAsAsync<Skladista>().Result;
            SkladisteNaziv.Text = skladisteprikaz.Adresa;
            Distanca.Text = Global._udaljenosthlp + "km";
            Vrijeme.Text = Global._vrijemethlp + "min";

            if (Convert.ToDouble(Global._udaljenosthlp) > 5.4)
            {
                int a = Convert.ToInt32(Math.Round(Convert.ToDouble(Global._udaljenosthlp), 0));

                DistancaPlacanje.IsVisible = true;
                Lbldistancaplacanja.IsVisible = true;
                a = a - 5;

                ukupno = a * 4;
                DistancaPlacanje.Text = ukupno.ToString() + " KM";
            }
            ukupno += Global.aktivnaNarudzba.Ukupno;
            CijenaBezPDV.Text = Math.Round(ukupno,2).ToString() + " KM";

            CPDV = Math.Round((Convert.ToDouble(ukupno) * 0.17) + Convert.ToDouble(ukupno),2);
            CijenaSaPDV.Text = CPDV + " KM";
            BrojStavki.Text = Global.av.Count.ToString();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MojaNarudzba());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapRoutePage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            Global.popustaktivan = false;
            if (popust == true) { 
                Global.popustaktivan = true;
                Global.prijavljeniKupac.Bodovi = Global.prijavljeniKupac.Bodovi - 50;
            }
            await Navigation.PushAsync(new StripePaymentGatwayPage(CPDV));
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            HttpResponseMessage narudzaResponse;
            // GetBrojNarudzbi
            narudzaResponse = narudzbeService.GetActionResponseNoP("GetBrojNarudzbi");
            int broj = narudzaResponse.Content.ReadAsAsync<int>().Result;

            foreach (var x in Global.av)
            {
                Global.aktivnaNarudzba.NarudzbaStavke.Add(x);
            }
            Global.aktivnaNarudzba.PayByCard = false;
            Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;
            Global.aktivnaNarudzba.BrojNarudzbe = "Br" + broj.ToString();
            Global.aktivnaNarudzba.Latitude = Global.destinacijaPin.Lat.ToString();
            Global.aktivnaNarudzba.Longitude = Global.destinacijaPin.Lng.ToString();
            Global.aktivnaNarudzba.IznosBezPDV = ukupno;
            Global.aktivnaNarudzba.IznosSaPDV = Convert.ToDecimal(CPDV);
            narudzaResponse = narudzbeService.PostResponse(Global.aktivnaNarudzba);

            string message = string.Empty;
            if (narudzaResponse.IsSuccessStatusCode)
            {

                message = "Narudžba uspješno kreirana ";
                if (popust == true)
                {
                    Global.prijavljeniKupac.Bodovi = Global.prijavljeniKupac.Bodovi - 50;

                    kupciService.PutResponse(Global.prijavljeniKupac.KupacID, Global.prijavljeniKupac);
                }

            }
            else
            {
                message = "Greska u komunikaciji sa webApi-em";

            }
           

            Global.aktivnaNarudzba.NarudzbaStavke.Clear();
            Global.av.Clear();
            Global.aktivnaNarudzba = new eZdravaIshrana_PCL.Model.Narudzbe();
            Global.av = new System.Collections.ObjectModel.ObservableCollection<NarudzbaStavke>();
            Global.destinacijaPin = new LatLong();

            await DisplayAlert(message, message, "OK");

            await Navigation.PopToRootAsync();
          
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            popust = !popust;
         
            if (popust == true)
            {
                
                ukupno2 = CPDV;
                CPDV = Math.Round(CPDV - (CPDV * Convert.ToDouble(0.15)),2);
                lbl2plac.IsVisible = true;
                lbl2plac.Text = "Popust je aktivan.";
                CijenaSaPDV.TextColor = Color.FromHex("#2196F3");
              
            }
            else 
            {
                CPDV = ukupno2;
                lbl2plac.IsVisible = false;
                CijenaSaPDV.TextColor =Color.Black;
            }
            CijenaSaPDV.Text = CPDV.ToString()+ " KM";
        }
    }
}