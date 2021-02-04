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
using System.Threading.Tasks;
//using System.Windows.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProizvodiDetalji2 : ContentPage
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        WebApiHelper izlazStavkeService = new WebApiHelper("http://localhost:2618/", "api/IzlazStavke");
        WebApiHelper ocjeneService = new WebApiHelper("http://localhost:2618/", "api/Ocjene");
        Proizvodi p = new Proizvodi();
        public ObservableCollection<Proizvodi> ProizvodiList2 { get; set; } = new ObservableCollection<Proizvodi>();

        public int ocjena = 0;
        public ProizvodiDetalji2(Proizvodi proizvod)
        {
            InitializeComponent();
            this.Title = "Ocjenjivanje proizvoda"; 
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
            vrstaLabel.Text = p.Vrsta;
            sortaLabel.Text = p.Sorta;
            prikaziZvjezdice(p.Prosjecna);
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


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            ocjena = 1;
            string a = testh.Source.ToString();
            if (testh.Source.ToString().Contains("stare.png"))
            {
                testh.Source = "Assets/starf.png";
                testh1.Source = "Assets/stare.png";
                testh2.Source = "Assets/stare.png";
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";
            }
            else
            {
                testh1.Source = "Assets/stare.png";
                testh2.Source = "Assets/stare.png";
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";
            }

        }

        private void ImageButton_Clicked4(object sender, EventArgs e)
        {
            ocjena = 5;
            if (testh4.Source.ToString().Contains("stare.png"))
            {
                testh.Source = "Assets/starf.png";
                testh1.Source = "Assets/starf.png";
                testh2.Source = "Assets/starf.png";
                testh3.Source = "Assets/starf.png";
                testh4.Source = "Assets/starf.png";
            }



        }

        private void ImageButton_Clicked3(object sender, EventArgs e)
        {
            ocjena =4;
            string a = testh3.Source.ToString();

            if (testh3.Source.ToString().Contains("stare.png"))
            {
                testh.Source = "Assets/starf.png";
                testh1.Source = "Assets/starf.png";
                testh2.Source = "Assets/starf.png";
                testh3.Source = "Assets/starf.png";
                testh4.Source = "Assets/stare.png";
            }
            else
            {
                testh4.Source = "Assets/stare.png";
            }

        }

        private void ImageButton_Clicked2(object sender, EventArgs e)
        {
            ocjena = 3;
            if (testh2.Source.ToString().Contains("stare.png"))
            {
                testh.Source = "Assets/starf.png";
                testh1.Source = "Assets/starf.png";
                testh2.Source = "Assets/starf.png";
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";

            }
            else
            {
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";
            }

        }

        private void ImageButton_Clicked1(object sender, EventArgs e)
        {
            ocjena = 2;
            if (testh1.Source.ToString().Contains("stare.png"))
            {
                testh.Source = "Assets/starf.png";
                testh1.Source = "Assets/starf.png";
                testh2.Source = "Assets/stare.png";
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";

            }
            else
            {
                testh2.Source = "Assets/stare.png";
                testh3.Source = "Assets/stare.png";
                testh4.Source = "Assets/stare.png";
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Ocjene nova = new Ocjene();
            nova.Datum = DateTime.Now;
            nova.KupacID = Global.prijavljeniKupac.KupacID;
            nova.Ocjena = ocjena;
            nova.ProizvodID = p.ProizvodID;
            HttpResponseMessage Response;
            Response = izlazStavkeService.GetActionResponseID("GetIzlaziStavkehlp", p.IzlazStavkaID);
            IzlazStavke baza = Response.Content.ReadAsAsync<IzlazStavke>().Result;
            baza.Ocjenjeno = true;
            izlazStavkeService.PutResponse(baza.IzlazStavkaID, baza);
            ocjeneService.PostResponse(nova);
            await DisplayAlert("Ocjenjivanje proizvda", "Uspjesno ste ocijenili proizvod", "OK");
            await Navigation.PopToRootAsync();

        }
    }
}