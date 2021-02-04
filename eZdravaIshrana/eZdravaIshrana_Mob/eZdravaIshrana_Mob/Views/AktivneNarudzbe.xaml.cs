using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AktivneNarudzbe : ContentPage
    {
        private AktivViewModel model = null;

        public AktivneNarudzbe()
        {
            InitializeComponent();
            BindingContext = model = new AktivViewModel();
            

        }
        public AktivneNarudzbe(int a)
        {
            InitializeComponent();
            BindingContext = model = new AktivViewModel();
            NavigationPage.SetHasBackButton(this, false);
           

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

      

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Narudzbe;
            
            item.DatumPrikaz = item.Datum.ToString("dd-MM-yyyy");
            Global.aktivnaNarudzbaPrikazihlp = (Narudzbe)item;
            await Navigation.PushAsync(new ANDetalji(item));
          
        }
    }
}