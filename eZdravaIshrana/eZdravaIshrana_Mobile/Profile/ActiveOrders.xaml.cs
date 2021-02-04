using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace eZdravaIshrana_Mobile.Profile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActiveOrders : Page
    {
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        public ActiveOrders()
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
            BindNarudzbe();

        }

        private void BindNarudzbe()
        {
            if (Global.aktivnaNarudzba != null)
            {
                decimal iznos = 0;
                narudzbaList.ItemsSource = Global.aktivnaNarudzba.NarudzbaStavke;
                foreach (NarudzbaStavke x in Global.aktivnaNarudzba.NarudzbaStavke)
                {
                    iznos += x.Proizvodi.Cijena * x.Kolicina;
                }
                iznosLabel.Text = "Ukupan iznos: " + Math.Round(iznos, 2)+ " KM";
            }
        }

        private async void zakljuciButton_Click(object sender, RoutedEventArgs e)
        {
            string message = string.Empty;
            if (Global.aktivnaNarudzba != null)
            {
                HttpResponseMessage response = narudzbeService.PostResponse(Global.aktivnaNarudzba);
                if (response.IsSuccessStatusCode)
                {
                    message = "Uspješno ste zaključili narudžbu!";

                    Global.aktivnaNarudzba = null;
                }
                else
                {
                    message = "Narudžba nije dodata ->!" + response.ReasonPhrase;
                }
                MessageDialog msg = new MessageDialog(message);
                await msg.ShowAsync();
            }
        }

        private void izbrisiStavku_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void narudzbaList_ItemClick(object sender, ItemClickEventArgs e)
        {
           
           

        }
    }
}
