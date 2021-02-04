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
    public partial class Historija : ContentPage
    {
        private HistorijaVM model = null;
        public Historija()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaVM();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Aktiv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Global.Izlazhlp2 = (Izlaz)e.SelectedItem;
            await Navigation.PushAsync(new HistorijaDetalji((Izlaz)e.SelectedItem));
        }
    }
}