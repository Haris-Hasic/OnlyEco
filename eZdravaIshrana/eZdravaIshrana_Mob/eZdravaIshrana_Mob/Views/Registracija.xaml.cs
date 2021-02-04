using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registracija : ContentPage
    {
        WebApiHelper servis = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        public Registracija()
        {
            InitializeComponent();
        }

        private async void registracijaButton_Clicked(object sender, EventArgs e)
        {
            string msg = string.Empty;
            string msg1 = string.Empty;
         //   validateRegistration()
            if (validateRegistration() == true)
            {
                Kupci k = new Kupci();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                string test = UIHelper2.GenerateSalt(); 
                k.LozinkaSalt = UIHelper2.GenerateSalt();
                k.LozinkaHash = UIHelper2.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.DatumRegistracije = DateTime.Now;
                k.Status = true;
              
                HttpResponseMessage response = servis.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    msg = "Registracija uspjesna!";
                    await DisplayAlert("", msg, "OK");
                    Application.Current.MainPage = new LoginPage();

                }
                else if (response.ReasonPhrase == "Email_Kupac")
                {           
                    msg = "Uneseno korisničko ime je već registrovan!";
                    await DisplayAlert("", msg, "OK");
                    emailError.Text = "Korisnicko ime vec postoji!";
                    emailError.IsVisible = true;
                }
                else if (response.ReasonPhrase == "KorisnickoIme_Kupac")
                {
                    msg = "Uneseni email je već registrovan!";
                    await DisplayAlert("", msg, "OK");
                    korisnickoImeError.Text = "Email vec postoji!";
                    korisnickoImeError.IsVisible = true;
                }
                else
                {
                    msg ="Doslo je do greske :" + response.ReasonPhrase;
                    await DisplayAlert("", msg, "OK");
                }
            }
        }

        private bool validateRegistration()
        {
            bool valid = true;
            //radim odvojeno kako bi dobio odma error border za svaki pogresan unos
            if (validateIme() == false)
                valid = false;
            if (validatePrezime() == false)
                valid = false;
            if (validateEmail() == false)
                valid = false;
            if (validateKorisnickoIme() == false)
                valid = false;
            if (validateLozinka() == false)
                valid = false;
            if (validateLozinka() == false)
                valid = false;
            if (validatepotvrdaLozinka() == false)
                valid = false;

            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

     

        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();

        }
        private bool validateIme()
        {
            if (imeInput.Text==null)
            {
                //imeInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                imeError.Text = "Ime obavezno!";
                imeError.IsVisible =true;
                return false;
            }
            else
            {
                //imeInput.BorderBrush = null;
                imeError.IsVisible = false;
                imeError.Text = "";
                return true;
            }
        }

        private bool validatePrezime()
        {
            if (prezimeInput.Text == null)
            {
                prezimeError.Text = "Prezime obavezno!";
                prezimeError.IsVisible = true;
                return false;
            }
            else
            {
               
                prezimeError.IsVisible = false;
                prezimeError.Text = "";
                return true;
            }
        }

        private bool validateEmail()
        {

           
            if (emailInput.Text == null)
            {

                emailError.Text = "Email obavezan!";
                emailError.IsVisible = true;
                return false;
            }
            string a = emailInput.Text;
            if (Regex.Match(a, "^[a-zA-Z0-9_@.-]*$").Success)
            {
                a = a.Replace('.', ',');
            
            }
            else
            {
                emailError.Text = "Dozvoljeni specijalni karakteri su  ( _ @ . - )!";
                emailError.IsVisible = true;
                return false;
            }

            HttpResponseMessage response = servis.GetActionResponse("CheckEmail2", a);
            Dostavljac postoji = null;
            if (response.IsSuccessStatusCode)
            {
                postoji = response.Content.ReadAsAsync<Dostavljac>().Result;
            }
            else 
            {
                postoji = null;
            }

            try
            {
                MailAddress mail = new MailAddress(emailInput.Text);
                if (postoji == null)
                {
                    emailError.IsVisible = false;
                    emailError.Text = "";
                    return true;
                }
                else
                {
                    emailError.Text = "Email već postoji!";
                    emailError.IsVisible = true;
                    return false;
                }
            }
            catch (Exception)
            {
                emailError.Text = "Email nije u ispravnom formatu!";
                emailError.IsVisible = true;
                return false;
            }

        }



        private bool validateKorisnickoIme()
        {


            if (korisnickoImeInput.Text == null)
            {
                korisnickoImeError.Text = "Korisničko ime obavezno!";
                korisnickoImeError.IsVisible = true;
                return false;
            }
            if (korisnickoImeInput.Text.Count() < 3)
            {
                korisnickoImeError.Text = "Korisničko ime ne smije biti manje od 4 karaktera!";
                korisnickoImeError.IsVisible = true;
                return false;
            }
            string a = korisnickoImeInput.Text.Replace('.', ',');
        

            if (Regex.Match(a, "^[a-zA-Z0-9_.-]*$").Success)
            {
                a = a.Replace('.', ',');

            }
            else
            {
                korisnickoImeError.Text = "Dozvoljeni specijalni karakteri ( _ . - ) !";
                korisnickoImeError.IsVisible = true;
                return false;
            }
            HttpResponseMessage response = servis.GetActionResponse("CheckAcc", a);
            Dostavljac postoji = null;
            if(response.IsSuccessStatusCode)
            {
                postoji = response.Content.ReadAsAsync<Dostavljac>().Result;
            }
            else
            {
                postoji = null;
            }
            if(postoji == null)
            {
                korisnickoImeError.IsVisible = false;
                korisnickoImeError.Text = "";
                return true;
            }
            else
            {
                korisnickoImeError.IsVisible = true;
                korisnickoImeError.Text = "Korisničko ime već postoji";
                return false;
            }

            
            
        }

        private bool validateLozinka()
        {
            if (lozinkaInput.Text == null)
            {

                lozinkaError.Text = "Lozinka obavezna!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (lozinkaInput.Text.Count() < 6)
            {

                lozinkaError.Text = "Lozinka treba imati najmanje 6 karaktera!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (lozinkaInput.Text == korisnickoImeInput.Text)
            {

                lozinkaError.Text = "Lozinka i korisnicko moraju biti razliciti!";
                lozinkaError.IsVisible = true;
                return false;
            }
            else
            {
               
                lozinkaError.IsVisible = false;
                lozinkaError.Text = "";
                return true;
            }
        }
        private bool validatepotvrdaLozinka()
        {
            if (potvrdalozinkaInput.Text == null)
            {
                potvrdalozinkaError.Text = "Potvrda lozinke obavezna !";
                potvrdalozinkaError.IsVisible = true;
                return false;
            }
            else
            { 
            if (lozinkaInput.Text != potvrdalozinkaInput.Text)
            {

                potvrdalozinkaError.Text = "Loznike se ne podudaraju!";
                potvrdalozinkaError.IsVisible = true;
                return false;
            }
            else
            {
                potvrdalozinkaError.Text = "";
                potvrdalozinkaError.IsVisible = false;
                return true;
            }
            }
        }

    }
}