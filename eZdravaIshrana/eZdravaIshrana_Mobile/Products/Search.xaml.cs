using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System.Net.Http;
using eZdravaIshrana_PCL.Model;

namespace eZdravaIshrana_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Search : Page
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        public Search()
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
            BindVrstaProizvoda();
            BindProizvodi();
        }

        private void BindProizvodi()
        {
            int vrstaID = 0;
            if (vrstaProizvodaList.SelectedIndex != -1)
                vrstaID = ((VrsteProizvoda)vrstaProizvodaList.SelectedValue).VrstaID;
            
            HttpResponseMessage response = proizvodiService.GetResponse2par("SearchProizvodiMobile", vrstaID,nazivProizvoda.Text);
            if (response.IsSuccessStatusCode)
            {
                proizvodiList.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void BindVrstaProizvoda()
        {
           
            HttpResponseMessage respone = vrsteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = respone.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrstaProizvodaList.ItemsSource = vrste;
                vrstaProizvodaList.DisplayMemberPath = "Naziv";
                
            }
            else
            {

            }
        }

        private void vrstaProizvodaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BindProizvodi();
        }

        private void nazivProizvoda_TextChanged(object sender, TextChangedEventArgs e)
        {
            BindProizvodi();
        }

        private void proizvodiList_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Frame.Navigate(typeof(Details),((Proizvodi)e.ClickedItem).ProizvodID);
        }
    }
}
