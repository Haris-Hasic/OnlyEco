using eZdravaIshrana_Mob.Converter;
using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProizvodDetalji : ContentPage
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        WebApiHelper ocjeneService = new WebApiHelper("http://localhost:2618/", "api/Ocjene");
        Proizvodi p = new Proizvodi();
        public ObservableCollection<Proizvodi> ProizvodiList2 { get; set; } = new ObservableCollection<Proizvodi>();
        public ProizvodDetalji(Proizvodi proizvod)
        {
           
            InitializeComponent();
            p = proizvod;
            HttpResponseMessage ocjeneResponse;
            ocjeneService.GetActionResponseID("GetProsjek", p.ProizvodID);
            ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", p.ProizvodID);
            List<Ocjene> ocjeneprikaz = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
            p.Prosjecna = IzracunajProsjek(ocjeneprikaz);
            p.Prosjecna =Math.Round(p.Prosjecna,2);
            proizvodImage.Source = ImageConverter.FromByteToImageSource(p.SlikaThumb);
            nazivLabel.Text = p.Naziv;
            sifraLabel.Text = p.Sifra;
            cijenaLabel.Text = p.Cijena.ToString() + " KM";
            
            prosjekLabel.Text = p.Prosjecna.ToString();
            prikaziZvjezdice(p.Prosjecna);
            sortaLabel.Text = p.Sorta;
            vrstaLabel.Text = p.Vrsta;
            kolicinaInput.Text = "0";
            // Recommender
            preporuceniProizvodiList.ItemsSource = ProizvodiList2;
            HttpResponseMessage recomendResponse = proizvodiService.GetActionResponseID("RecommendProduct", p.ProizvodID);


            if (recomendResponse.IsSuccessStatusCode)
            {
                List<Proizvodi> proizvodi = recomendResponse.Content.ReadAsAsync<List<Proizvodi>>().Result;

                foreach (var help in proizvodi)
                {
                    ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", help.ProizvodID);
                    List<Ocjene> ocjene = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
                    help.Prosjecna = IzracunajProsjek(ocjene);
                    help.Prosjecna = Math.Round(help.Prosjecna, 2);
                    ProizvodiList2.Add(help);
                }
            }


        }


        public ProizvodDetalji(Proizvodi proizvod,bool a)
        {

            InitializeComponent();
            p = proizvod;
            HttpResponseMessage ocjeneResponse;
            ocjeneService.GetActionResponseID("GetProsjek", p.ProizvodID);
            ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", p.ProizvodID);
            List<Ocjene> ocjeneprikaz = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
            p.Prosjecna = IzracunajProsjek(ocjeneprikaz);
            p.Prosjecna = Math.Round(p.Prosjecna, 1);
            proizvodImage.Source = ImageConverter.FromByteToImageSource(p.SlikaThumb);
            nazivLabel.Text = p.Naziv;
            sifraLabel.Text = p.Sifra;
            cijenaLabel.Text = p.Cijena.ToString();
            prosjekLabel.Text = p.Prosjecna.ToString();
            sortaLabel.Text = p.Sorta;
            prikaziZvjezdice(p.Prosjecna);
            vrstaLabel.Text = p.Vrsta;
            kolicinaInput.Text = "0";
            // Recommender
            preporuceniProizvodiList.ItemsSource = ProizvodiList2;
            HttpResponseMessage recomendResponse = proizvodiService.GetActionResponseID("RecommendProduct", p.ProizvodID);


            if (recomendResponse.IsSuccessStatusCode)
            {
                List<Proizvodi> proizvodi = recomendResponse.Content.ReadAsAsync<List<Proizvodi>>().Result;

                foreach (var help in proizvodi)
                {
                    ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", help.ProizvodID);
                    List<Ocjene> ocjene = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
                    help.Prosjecna = IzracunajProsjek(ocjene);
                    help.Prosjecna = Math.Round(help.Prosjecna, 1);
                    ProizvodiList2.Add(help);
                }
            }

           
          
           


        }

       

        private void prikaziZvjezdice(decimal prosjecna)
        {
            if (prosjecna >= 1)
            {
                jedan.IsVisible = true;
                if (prosjecna < 2 && prosjecna > 1)
                    jedanipo.IsVisible = true;
            }
            if (prosjecna >= 2)
            {
                dva.IsVisible = true;
                if (prosjecna < 3 && prosjecna > 2)
                    dvaipo.IsVisible = true;
            }
            if (prosjecna >= 3)
            {
                tri.IsVisible = true;
                if (prosjecna < 4 && prosjecna > 3)
                    triipo.IsVisible = true;
            }
            if (prosjecna >= 4)
            {
                cetri.IsVisible = true;
                if (prosjecna < 5 && prosjecna > 4)
                    cetriipo.IsVisible = true;
            }

            if (prosjecna == 5)
            {
                pet.IsVisible = true;
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

        private async void kupiButton_Click(object sender, EventArgs e)
        {
            bool Isvalid = false;
            Isvalid= validirajkolicinu();
            if (kolicinaInput.Text != "0" && kolicinaInput.Text != "" && Isvalid == true)
            {
                errorkolicina.IsVisible = false;
                NarudzbaStavke nova = new NarudzbaStavke();
                nova.Proizvodi = p;
                nova.ProizvodID = p.ProizvodID;
                nova.Kolicina = Convert.ToInt32(kolicinaInput.Text);
                nova.CijenaProizvoda = p.Cijena * nova.Kolicina;
                nova.Naziv = p.Naziv;
                if (Global.hlpGlobal == 0)
                {
                    Global.aktivnaNarudzba.NarudzbaStavke = new ObservableCollection<NarudzbaStavke>();
                    Global.hlpGlobal++;
                    
                }
            
                bool pronadjen = true;

                foreach (var x in Global.av)
                {
                    if (x.ProizvodID == nova.ProizvodID)
                    {
                        pronadjen = false;
                        x.Kolicina += nova.Kolicina;
                        x.CijenaProizvoda += nova.CijenaProizvoda;
                        Global.aktivnaNarudzba.Ukupno += nova.CijenaProizvoda;
                    }
                }
                if (pronadjen)
                {
                  
                    Global.av.Add(nova);
                    Global.aktivnaNarudzba.Ukupno += nova.CijenaProizvoda;

                    await DisplayAlert("Uspjesno dodano ", "Uspjesno ste dodali novu stavku na narudžbu", "OK");
                    kolicinaInput.Text = "0";
                }
                else {
                    await DisplayAlert("Izmjenjena uspješna", "Izmjenjena količina stavku na narudžbu", "OK");
                    kolicinaInput.Text = "0";
                }
           
            }
            else
            {
                errorkolicina.IsVisible = true;
            }

        }

        private bool validirajkolicinu()
        {
            bool a = false;
            if (Regex.Match(kolicinaInput.Text, "^[0-9]*$").Success)
            {
                a = true;

            }
            else
            {
                a = false;
            }
            return a;
        }

        private async void zakljuciButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MojaNarudzba());
        }

        private async void preporuceniProizvodiList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ProizvodDetalji((Proizvodi)e.SelectedItem));
        }
    }
}