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
    public sealed partial class Details : Page
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        public Proizvodi proizvod { get; set; }
        public Details()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            int proizvodId = Convert.ToInt32(e.Parameter);
            HttpResponseMessage response = proizvodiService.GetActionResponseID("GetProizvodiCustom", proizvodId);
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

                if (Global.prijavljeniKupac != null)
                {
                    kolicinaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    kupiButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }

                HttpResponseMessage recomendResponse = proizvodiService.GetActionResponseID("RecommendProduct", proizvodId);
                if (recomendResponse.IsSuccessStatusCode)
                {
                    List<Proizvodi> proizvodi = recomendResponse.Content.ReadAsAsync<List<Proizvodi>>().Result;
                    preporuceniProizvodiList.ItemsSource = proizvodi;
                }
            }
        }

        private async void kupiButton_Click(object sender, RoutedEventArgs e)
        {
            if (validate() == true)
            {
                if (Global.aktivnaNarudzba == null)
                {
                    Global.aktivnaNarudzba = new Narudzbe();
                    Global.aktivnaNarudzba.BrojNarudzbe = "1/" + DateTime.Now.Day + "-" + DateTime.Now.Year;
                    Global.aktivnaNarudzba.Datum = DateTime.Now;
                    Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;
                }
                bool proizvodPostoji = false;
                foreach (NarudzbaStavke x in Global.aktivnaNarudzba.NarudzbaStavke)
                {
                    if (proizvod.ProizvodID == x.ProizvodID)
                    {
                        x.Kolicina += Convert.ToInt32(kolicinaInput.Text);
                        proizvodPostoji = true;
                        break;
                    }
                }
                string message = "Uspjesno ste dodali proizvod u korpu!";
                if (proizvodPostoji)
                    message = "Uspjesno ste izmjenuli kolicinu proizvoda u korpi";
                else
                {
                    NarudzbaStavke s = new NarudzbaStavke();
                    s.ProizvodID = proizvod.ProizvodID;
                    s.Proizvodi = proizvod;
                    s.Kolicina = Convert.ToInt32(kolicinaInput.Text);

                    Global.aktivnaNarudzba.NarudzbaStavke.Add(s);
                }
                MessageDialog msg = new MessageDialog(message);
                await msg.ShowAsync();

                narudzbaInfoLabel.Text = "Broj naručenih proizvoda: " + Global.aktivnaNarudzba.NarudzbaStavke.Count;
                zakljuciButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            
        }

     

        private void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile.ActiveOrders));
        }

        private void preporuceniProizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Details), ((Proizvodi)e.ClickedItem).ProizvodID);
        }




        private bool validate()
        {
            bool valid = true;
            if (validateKolicina() == false)
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

        private bool validateKolicina()
        {
            if (kolicinaInput.Text == "")
            {
                kolicinaInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                kolicinaError.Text = "Molimo vas unesite količinu!";
                kolicinaError.Visibility = Windows.UI.Xaml.Visibility.Visible;
                return false;
            }
            else if (!Regex.IsMatch(kolicinaInput.Text.Trim(), "^[0-9]*$"))
                {
                    kolicinaInput.BorderBrush = null;
                    kolicinaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    kolicinaError.Text = "Molimo vas unesite samo brojeve";
                    return false;
                }
                else{
                    kolicinaInput.BorderBrush = null;
                    kolicinaError.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    kolicinaError.Text = "";
                    return true;
                    }
            }
        }
    }

