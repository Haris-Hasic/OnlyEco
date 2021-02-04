using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;


using System.Net.Http;
using System.Net.Mail;

using System.Text.RegularExpressions;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DostavljaciKorisnickiProfil : ContentPage
    {
        WebApiHelper servis = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");
        public Dostavljac prijavljeni { get; set; } = new Dostavljac();
        public DostavljaciKorisnickiProfil()
        {
            InitializeComponent();

            this.Title = Global.prijavljeniDostavljac.Naziv;
            lblnaslov.Text = lblnaslov.Text + "(" + Global.prijavljeniDostavljac.Naziv + ")";
            prijavljeni = Global.prijavljeniDostavljac;


            UcitajPodatke();
        }
        

        private void UcitajPodatke()
        {
            nazivinput.Text = prijavljeni.Naziv;
            adresainput.Text = prijavljeni.Adresa;
            emailInput.Text = prijavljeni.Email;
            korisnickoImeInput.Text = prijavljeni.KorisnickoIme;
           
        }

        private async void registracijaButton_Clicked(object sender, EventArgs e)
        {
            string msg = string.Empty;
            string msg1 = string.Empty;
          
            if (validateRegistration() == true)
            {
                prijavljeni.Adresa = adresainput.Text;
                prijavljeni.Naziv = nazivinput.Text;
                prijavljeni.Email = emailInput.Text;
                prijavljeni.KorisnickoIme = korisnickoImeInput.Text;
                string test = UIHelper2.GenerateSalt();
                if (lozinkaInput.Text != null && potvrdalozinkaInput.Text != null)
                {
                    prijavljeni.LozinkaSalt = UIHelper2.GenerateSalt();
                    prijavljeni.LozinkaHash = UIHelper2.GenerateHash(lozinkaInput.Text, prijavljeni.LozinkaSalt);
                }

                Global.prijavljeniDostavljac = prijavljeni;
                HttpResponseMessage response = servis.PutResponse(prijavljeni.DostavljacID, prijavljeni);
                if (response.IsSuccessStatusCode)
                {
                    msg = "Uspješna izmjena podataka ( ponovo se prijavite da vidite promjene ) !";
                    await DisplayAlert("", msg, "OK");
                    await Navigation.PopAsync();
                    //redirect 
                }
                else if (response.ReasonPhrase == "CS_EmailD")
                {
                    msg = "Uneseno korisničko ime je već registrovan!";
                    await DisplayAlert("", msg, "OK");
                    emailError.Text = "Korisnicko ime vec postoji!";
                    emailError.IsVisible = true;
                }
                else if (response.ReasonPhrase == "CS_KorisnickoImeD")
                {
                    msg = "Uneseni email je već registrovan!";
                    await DisplayAlert("", msg, "OK");
                    korisnickoImeError.Text = "Email vec postoji!";
                    korisnickoImeError.IsVisible = true;
                }
                else
                {
                    msg = "Doslo je do greske :" + response.ReasonPhrase;
                    await DisplayAlert("", msg, "OK");
                }
            }
        }

        private bool validateRegistration()
        {
            bool valid = true;

            if (validateNaziv() == false)
                valid = false;
            if (validateAdresa() == false)
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

        private bool validateNaziv()
        {
            if (nazivinput.Text == null)
            {
                
                nazivError.Text = "Ime obavezno!";
                nazivError.IsVisible = true;
                return false;
            }
            else if(nazivinput.Text.Count()<=4)
            {

                nazivError.Text = "Naziv mora imati vise od 4 karaktera !";
                nazivError.IsVisible = true;
                return false;
            }  
            else
            {

                nazivError.IsVisible = false;
                nazivError.Text = "";
                return true;
            }
        }
        private bool validateAdresa()
        {
            if (adresainput.Text == null)
            {

                adresaError.Text = "Adresa obavezno!";
                adresaError.IsVisible = true;
                return false;
            }
            else if (adresainput.Text.Count() <= 4)
            {

                adresaError.Text = "Adresa mora imati vise od 4 karaktera !";
                adresaError.IsVisible = true;
                return false;
            }
            else
            {

                adresaError.IsVisible = false;
                adresaError.Text = "";
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
            if (response.IsSuccessStatusCode)
            {
                postoji = response.Content.ReadAsAsync<Dostavljac>().Result;
            }
            else
            {
                postoji = null;
            }
            if (postoji == null)
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
            if (lozinkaInput.Text == null && potvrdalozinkaInput.Text == null)
            {
                lozinkaError.IsVisible = false;
                lozinkaError.Text = "";
                return true;
            }
            else { 
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
        }
        private bool validatepotvrdaLozinka()
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