using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DostavljacMain : ContentPage
    {
        private DostavljacMainViewModel model = null;
        public DostavljacMain()
        {
            InitializeComponent();
            BindingContext = model = new DostavljacMainViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Izlaz;
       
            Global.Izlazhlp2 = item;
            await Navigation.PushAsync(new DostavljacNarudzbaDetalji(item));
        }
    }
}