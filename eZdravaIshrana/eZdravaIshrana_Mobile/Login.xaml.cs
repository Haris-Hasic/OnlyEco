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
using eZdravaIshrana_PCL.Util;
using eZdravaIshrana_PCL.Model;
using System.Net.Http;
using Windows.UI.Popups;

namespace eZdravaIshrana_Mobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        WebApiHelper service = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        public Login()
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage response = service.GetActionResponse("GetKupciByUsername", korisnickoImeInput.Text);
            string message = string.Empty;    string message = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                Kupci k = response.Content.ReadAsAsync<Kupci>().Result;
                if (UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt) == k.LozinkaHash)
                {
                    message = "Welcome " + k.Ime + " " + k.Prezime;
                    Global.prijavljeniKupac = k;
                    Frame.Navigate(typeof(MainPage));

                    
                }
                else
                {
                    message = "Podaci nisu validni";
                }
            }
            else
            {
                message = "Greska u komunikaciji sa webApi-em";
              
            }
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
        }

        private void registracijabtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Registracija));
        }
    }
}
