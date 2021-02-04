using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eZdravaIshrana_Mob.Models;

using System.ComponentModel;


namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage2 : ContentPage
    {
        Master RootPage { get => Application.Current.MainPage as Master; }
        List<HomeMenuItem> menuItems;
        public MenuPage2()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.AktivneDostave, Title="Aktivne Narudzbe" },
                new HomeMenuItem {Id = MenuItemType.Zakljucene, Title="Zakljucene" },
                new HomeMenuItem {Id = MenuItemType.MojProfil, Title="Moj profil" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Global.aktivnaNarudzba = new eZdravaIshrana_PCL.Model.Narudzbe();
            Global.av.Clear();
            Global.prijavljeniDostavljac = new eZdravaIshrana_PCL.Model.Dostavljac();
            Global.placanjeKarticom = false;
            Global.Izlazhlp2 = new eZdravaIshrana_PCL.Model.Izlaz();
            Global.hlpGlobal = 0;
            Global.prijavljeniKupac = new eZdravaIshrana_PCL.Model.Kupci();
            Application.Current.MainPage = new LoginPage();
        }
    }
}