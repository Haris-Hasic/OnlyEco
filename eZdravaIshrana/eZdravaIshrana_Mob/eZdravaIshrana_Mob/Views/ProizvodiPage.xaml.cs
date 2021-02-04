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
    public partial class ProizvodiPage : ContentPage
    {
        ProizvodiViewModel model = null;
        int hlp = 0;
        public ProizvodiPage()
        {

            InitializeComponent();
            BindingContext = model = new ProizvodiViewModel();
            hlp = 0;
           
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (hlp == 0)
            {
                cmbVrsta.SelectedIndex = 0;
                hlp = 1;
            }
        }

        private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            model.hlppretraga = txtNaziv.Text;
            await model.Init(txtNaziv.Text);
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ProizvodDetalji((Proizvodi)e.SelectedItem));
        }
    }
}