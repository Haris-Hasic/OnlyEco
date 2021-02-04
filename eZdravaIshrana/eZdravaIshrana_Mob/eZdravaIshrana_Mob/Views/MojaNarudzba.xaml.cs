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
    public partial class MojaNarudzba : ContentPage
    {
        //MojaNarudzbaViewModel a = new MojaNarudzbaViewModel();
        public MojaNarudzba()
        {
            InitializeComponent();
            MojaNarudzbaList.ItemsSource = Global.av;
            hlp2.Text = "Ukupno: " + Global.aktivnaNarudzba.Ukupno.ToString() + " KM";



        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            hlp2.Text = "Ukupno: " + Global.aktivnaNarudzba.Ukupno.ToString() + " KM";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Global.av.Count == 0 )
            {
                await DisplayAlert("Greška ", "Lista je prazna ne možete dalje", "OK");

            }
            else
            {
                await Navigation.PushAsync(new MapRoutePage());

            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as NarudzbaStavke;
       
            Global.aktivnaNarudzba.Ukupno = Global.aktivnaNarudzba.Ukupno - item.CijenaProizvoda;
            hlp2.Text = "Ukupno: " + Global.aktivnaNarudzba.Ukupno.ToString() + " KM";

            Global.av.Remove(item);
        }

        

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProizvodiPage());
        }

    
    }
}