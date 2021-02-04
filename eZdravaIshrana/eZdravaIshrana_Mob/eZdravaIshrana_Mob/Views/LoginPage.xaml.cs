using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using Windows.UI.Popups;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eZdravaIshrana_Mob.ViewModels;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        WebApiHelper service = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        WebApiHelper servis2 = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");

       // public NavigationPage test = new NavigationPage();

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool pronasao = false;
            string message = string.Empty;
            if (korisnickoime.Text == null || lozinka.Text == null)
            {
                message = "Polja korisničko ime ili lozinka su prazni !!! ";
            }
            else {
                HttpResponseMessage response = service.GetActionResponse("GetKupciByUsername", korisnickoime.Text);
                HttpResponseMessage response2 = servis2.GetActionResponse("GetDostavljaciByUsername", korisnickoime.Text);

                if (response.IsSuccessStatusCode)
                 {
                    
                Kupci k = response.Content.ReadAsAsync<Kupci>().Result;
               if (UIHelper2.GenerateHash(lozinka.Text, k.LozinkaSalt) == k.LozinkaHash)
                {
                    message = "Welcome " + k.Ime + " " + k.Prezime;
                    Global.prijavljeniKupac = k;
                        pronasao = true;

                    Application.Current.MainPage = new MainPage();
                    
                }
                else
                {
                    message = "Korisničko ime ili lozinka nije ispravna";
                }
            }
            else if(response2.IsSuccessStatusCode)
            {
                    Dostavljac k = response2.Content.ReadAsAsync<Dostavljac>().Result;
                    if (UIHelper2.GenerateHash(lozinka.Text, k.LozinkaSalt) == k.LozinkaHash)
                    {
                        message = "Welcome " + k.Naziv ;
                        Global.prijavljeniDostavljac = k;
                        pronasao = true;

                        Application.Current.MainPage = new Master();

                    }
                    else
                    {
                        message = "Korisničko ime ili lozinka nije ispravna";
                    }

                }
                   else
                {
                    message = "Greska u komunikaciji sa webApi-em";

                }
            }
         

            await DisplayAlert("Podaci nisu validni", message, "OK");

        }

        private  void registracijabtn_click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Registracija();

        }
    }
}