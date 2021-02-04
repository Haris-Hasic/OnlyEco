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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace eZdravaIshrana_Mobile.Products
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Ocjeni : Page
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        WebApiHelper ocijeniService = new WebApiHelper("http://localhost:2618/", "api/Ocjene");
        Proizvodi proizvod;

        int proizvodID;
        public Ocjeni()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            proizvodID = Convert.ToInt32(e.Parameter);
            HttpResponseMessage response = proizvodiService.GetActionResponseID("GetProizvodiCustom", proizvodID);
            if (response.IsSuccessStatusCode)
            {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;

                vrstaLabel.Text = proizvod.Vrsta;
                nazivLabel.Text = proizvod.Naziv;
                sifraLabel.Text = proizvod.Sifra;
                cijenaLabel.Text = proizvod.Cijena.ToString() + " KM";

                if (proizvod.Prosjecna != 0)
                    prosjekLabel.Text = "Ocjena: " + Math.Round((decimal)proizvod.Prosjecna, 2).ToString();

                MemoryStream ms = new MemoryStream(proizvod.SlikaThumb);
                BitmapImage image = new BitmapImage();

                await image.SetSourceAsync(ms.AsRandomAccessStream());

                proizvodImage.Source = image;

                HttpResponseMessage response2 = ocijeniService.GetResponse2par("CheckIF", Global.prijavljeniKupac.KupacID, proizvodID);
                if (response2.IsSuccessStatusCode)
                {
                    Ocjene ocjene = response2.Content.ReadAsAsync<Ocjene>().Result;
                    if (ocjene == null)
                    {
                        ocjenaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                        ocjeniButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Već ste ocjenili odabrani proizvod!");
                        await msg.ShowAsync();
                        Frame.GoBack();
                    }
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                    await msg.ShowAsync();
                }
            }
        }

        private async void ocjeniButton_Click(object sender, RoutedEventArgs e)
        {
            if (validateRegistration() == true)
            {
                Ocjene novi = new Ocjene();
                novi.ProizvodID = proizvodID;
                novi.KupacID = Global.prijavljeniKupac.KupacID;
                novi.Datum = DateTime.Now;
                novi.Ocjena = Convert.ToInt32(ocjenaInput.Text);
                HttpResponseMessage response = ocijeniService.PostResponse(novi);
                if (response.IsSuccessStatusCode)
                {
                    MessageDialog msg = new MessageDialog("Uspješno ste dodali ocjenu: ");
                    await msg.ShowAsync();
                    Frame.GoBack();
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                    await msg.ShowAsync();
                }
            }
        }

        private bool validateRegistration()
        {
            bool valid = true;
            if (validateOcjena() == false)
                valid = false;
            else
                valid = true;


            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

        private bool validateOcjena()
        {
            if (ocjenaInput.Text == "")
            {
                ocjenaInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                ocjenaError.Text = "Molimo vas unesite ocjenu!";
                ocjenaError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else
            {
                if (!Regex.IsMatch(ocjenaInput.Text.Trim(), "^[0-9]*$"))
                {
                    ocjenaInput.BorderBrush = null;
                    ocjenaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    ocjenaError.Text = "Molimo vas unesite samo brojeve";
                    return false;
                }
                else
                   if (Convert.ToInt32(ocjenaInput.Text.Trim())<0 && Convert.ToInt32(ocjenaInput.Text.Trim())>5)
                {
                    ocjenaInput.BorderBrush = null;
                    ocjenaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    ocjenaError.Text = "Molimo vas unesite samo brojeve of 1-5 ";
                    return false;
                }
                {
                    ocjenaInput.BorderBrush = null;
                    ocjenaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    ocjenaError.Text = "";
                    return true;
                }
            }
        }
    }
}
