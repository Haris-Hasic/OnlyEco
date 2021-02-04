using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eZdravaIshrana_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        WebApiHelper servis = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        public Registracija()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            if (validateRegistration() == true)
            {
                Kupci k = new Kupci();
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);
                k.DatumRegistracije = DateTime.Now;
                k.Status = true;

                HttpResponseMessage response = servis.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Registracija uspjesna!");
                    await msg.ShowAsync();
                    Frame.Navigate(typeof(Login));
                }
                else if (response.ReasonPhrase == "Email_Kupac")
                {
                    MessageDialog msg = new MessageDialog("Uneseni email je već registrovan!");
                    await msg.ShowAsync();
                }
                else if (response.ReasonPhrase == "KorisnickoIme_Kupac")
                {
                    MessageDialog msg = new MessageDialog("Uneseno korisničko ime je već registrovan!");
                    await msg.ShowAsync();
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Doslo je do greske :" + response.ReasonPhrase);
                    await msg.ShowAsync();
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

            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }



        private bool validateIme()
        {
            if (imeInput.Text == "")
            {
                imeInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                imeError.Text = "Ime obavezno!";
                imeError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                imeInput.BorderBrush = null;
                imeError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                imeError.Text = "";
                return true;
            }
        }

        private bool validatePrezime()
        {
            if (prezimeInput.Text == "")
            {
                prezimeInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                prezimeError.Text = "Prezime obavezno!";
                prezimeError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                prezimeInput.BorderBrush = null;
                prezimeError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                prezimeError.Text = "";
                return true;
            }
        }

        private bool validateEmail()
        {
            if (emailInput.Text == "")
            {
                emailInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                emailError.Text = "Email obavezan!";
                emailError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                emailInput.BorderBrush = null;
                emailError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                emailError.Text = "";
                return true;
            }
        }

        

        private bool validateKorisnickoIme()
        {
            if (korisnickoImeInput.Text == "")
            {
                korisnickoImeInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                korisnickoImeError.Text = "Korisničko ime obavezno!";
                korisnickoImeError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                korisnickoImeInput.BorderBrush = null;
                korisnickoImeError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                korisnickoImeError.Text = "";
                return true;
            }
        }

        private bool validateLozinka()
        {

            if (lozinkaInput.Password == "")
            {
                lozinkaInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                lozinkaError.Text = "Lozinka obavezna!";
                lozinkaError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                lozinkaInput.BorderBrush = null;
                lozinkaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                lozinkaError.Text = "";
                return true;
            }
        }
    }
}
