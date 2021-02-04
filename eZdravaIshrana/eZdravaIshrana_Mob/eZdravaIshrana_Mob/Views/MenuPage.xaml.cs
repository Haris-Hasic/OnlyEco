using eZdravaIshrana_Mob.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Proizvodi, Title="Proizvodi" },
           
                new HomeMenuItem {Id = MenuItemType.Aktivne, Title="Aktivne Narudzbe" },
                new HomeMenuItem {Id = MenuItemType.Historija, Title="Historija" },
                new HomeMenuItem {Id = MenuItemType.MojProfil, Title="Moj Profil" }
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
  

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            //logout
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