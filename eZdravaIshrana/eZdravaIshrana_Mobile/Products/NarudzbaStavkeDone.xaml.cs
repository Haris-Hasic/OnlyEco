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

namespace eZdravaIshrana_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NarudzbaStavkeDone : Page
    {
        WebApiHelper narudzbeStavkaService = new WebApiHelper("http://localhost:2618/", "api/NarudzbaStavke");
        public NarudzbaStavkeDone()
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
            int narudzbaID = Convert.ToInt32(e.Parameter);
            HttpResponseMessage response = narudzbeStavkaService.GetResponse2par("GetNarudzbeStavkeCustom", Global.prijavljeniKupac.KupacID, narudzbaID);
            if (response.IsSuccessStatusCode)
            {

                narudzbeStavkeList.ItemsSource = response.Content.ReadAsAsync<List<NarudzbaStavke>>().Result;
            }
            else
            {
                MessageDialog msg = new MessageDialog("Došlo je do greške: " + response.ReasonPhrase);
                await msg.ShowAsync();
            }
         

        }

  

        private void narudzbeStavkeList_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Products.Ocjeni), ((NarudzbaStavke)e.ClickedItem).ProizvodID);
        }
    }
}
