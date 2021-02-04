using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StripePaymentGatwayPage : ContentPage
    {
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");

        PaymentGatewayPageViewModel model = null;
        bool karticaValidna = false;
        bool godinaValidna = false;
        bool mjesecValidna = false;
        bool ccvValidna = false;

        public StripePaymentGatwayPage(double Iznos = 1)
        {
            InitializeComponent();
            Global.placanjeKarticom = true;
            BindingContext = model = new PaymentGatewayPageViewModel()
            {
                Iznos = Iznos
            };
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            
            
        }


        protected override void OnAppearing()
        {
            Submit_Button.IsEnabled = false;
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;

        }
        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CardNumber.Text.Length < 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
             
                ErrorLabel_CardNumber.Text = "Invalid Card number";
                karticaValidna = false;
            }
            else if (CardNumber.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Card number can not be empty !!";
                karticaValidna = false;

            }
            else
            {
                karticaValidna = true;
                ErrorLabel_CardNumber.IsVisible = false;

            }
            EnableSubmitButton();
        }
        private void CardNumber_Completed(object sender, System.EventArgs e)
        {
            if (CardNumber.Text.Length > 16 || CardNumber.Text.Length < 12)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Kartica nije validna";
                karticaValidna = false;
                EnableSubmitButton();
            }
            else
            {
                karticaValidna = true;
                ErrorLabel_CardNumber.IsVisible = false;
            }
            CardNumber.Unfocus();
            Month.Focus();
            EnableSubmitButton();
        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = 0;
            if (Month.Text != "")
                a = Convert.ToInt32(Month.Text);
            if (a == 0)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Mjesec ne moze biti prazan !!";
                mjesecValidna = false;
            }
            else if (a > 12 || a < 1)
            {
             
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Mjesec nije validan !!";
                mjesecValidna = false;
            }
            else
            {
                mjesecValidna = true;
                ErrorLabel_Month.IsVisible = false;
                EnableSubmitButton();
            }
            EnableSubmitButton();
        }
        private void Month_Completed(object sender, System.EventArgs e)
        {
            Month.Unfocus();
            Year.Focus();
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = 0;
            if (Year.Text != "")
                a = Convert.ToInt32(Year.Text);
            if (Year.Text.Length > 2 || Year.Text.Length < 2 || a > 40)
            {
          
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Godina nije validna !!(zadnja 2 broja godine)";
                godinaValidna = false;
            }
            else
            {
                godinaValidna = true;
                ErrorLabel_Year.IsVisible = false;
                EnableSubmitButton();
            }
            EnableSubmitButton();
        }
        private void Year_Completed(object sender, System.EventArgs e)
        {
            Year.Unfocus();
            Cvv.Focus();
        }

        private void Cvv_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Cvv.Text.Length > 3 || Cvv.Text.Length < 3)
            {
              
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV nije validan !!";
                ccvValidna = false;
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                ccvValidna = true;
                EnableSubmitButton();
            }
            EnableSubmitButton();

        }
        private void Cvv_Completed(object sender, System.EventArgs e)
        {
            Cvv.Unfocus();
        }

        private void EnableSubmitButton()
        {
            if (karticaValidna == true && mjesecValidna == true && godinaValidna == true && ccvValidna == true)
            {
                Submit_Button.IsEnabled = true;
            }
            else
            {
                Submit_Button.IsEnabled = false;
            }
        }


        private async void Submit_Button_Clicked(object sender, EventArgs e)
        {


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Global.CCplaceno == true)
            {
                Gotovolbl.IsVisible = false;
                Global.CCplaceno = false;
                await Navigation.PopToRootAsync();
                Global.placanjeKarticom = false;
            }
            else
                Gotovolbl.IsVisible = true;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            Global.placanjeKarticom = false;
        }
    }
}
