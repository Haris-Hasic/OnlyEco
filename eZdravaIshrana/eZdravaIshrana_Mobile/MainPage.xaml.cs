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
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace eZdravaIshrana_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame != null)
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    e.Handled = true;
                }
         
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
            if (Global.prijavljeniKupac != null)
            {
                PrijavaButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                profileButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                narudzbedone.Visibility= Windows.UI.Xaml.Visibility.Visible;
            }

            BindProizvodi();

        }

        private void BindProizvodi()
        {
          
        

            HttpResponseMessage response = proizvodiService.GetActionResponseNoP("GetTop3");
            if (response.IsSuccessStatusCode)
            {
                proizvodiTop3list.ItemsSource = response.Content.ReadAsAsync<List<Proizvodi>>().Result;
            }
        }

        private void proizvodiButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.Search));
        }

        private void PrijavaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Profile.ActiveOrders));
        }

        private void proizvodiTop3list_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(Products.Details), ((Proizvodi)e.ClickedItem).ProizvodID);
        }

        private void narudzbedone_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Products.NarudzbeDone));
        }
    }
}
