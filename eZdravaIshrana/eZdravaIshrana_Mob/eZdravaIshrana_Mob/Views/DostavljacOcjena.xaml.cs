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
    public partial class DostavljacOcjena : ContentPage
    {
        public Izlaz b { get; set; }
        public Dostavljac dostavljac { get; set; }
        WebApiHelper dostavljacService = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");

        WebApiHelper IzlazService = new WebApiHelper("http://localhost:2618/", "api/Izlazi");

        WebApiHelper ocjenadostavljacService = new WebApiHelper("http://localhost:2618/", "api/OcjeneDostavljaca");

        public int ocjena = 0;
        public DostavljacOcjena(Izlaz iz)
        {
            InitializeComponent();
         
            b = iz;
            HttpResponseMessage Response;

            Response = dostavljacService.GetResponseID(iz.DostavljacID);
            dostavljac = Response.Content.ReadAsAsync<Dostavljac>().Result;
            this.Title = "Dostavljač ( " + dostavljac.Naziv+" )";
            naziv.Text = dostavljac.Naziv;
            Kontakt.Text = dostavljac.KontaktOsoba;
            Email.Text = dostavljac.Email;
            Web.Text = dostavljac.Web;
            Fax.Text = dostavljac.Fax;
            Ziroracun.Text = dostavljac.ZiroRacuni;
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
            ocjena = 4;
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
            OcjenaDostavljaca nova = new OcjenaDostavljaca();
            nova.Datum = DateTime.Now;
            nova.DostavljacID = b.DostavljacID;
            nova.KupacID = b.KupacID;
            nova.Ocjena = ocjena;
            b.DostavljacOcjenjen = true;
            IzlazService.PutResponse(b.IzlazID, b);
            ocjenadostavljacService.PostResponse(nova);
            await DisplayAlert("Dostavljac ocjenjen", "Uspjesno ste ocjenili "+dostavljac.Naziv+" sa ocjenom" + ocjena, "OK");
            await Navigation.PopToRootAsync();
        }
    }

       
            


       
}
