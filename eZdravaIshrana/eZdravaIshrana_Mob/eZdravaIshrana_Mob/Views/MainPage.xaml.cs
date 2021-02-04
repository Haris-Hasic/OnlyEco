using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eZdravaIshrana_Mob.Models;
using eZdravaIshrana_PCL.Util;
using eZdravaIshrana_PCL.Model;

namespace eZdravaIshrana_Mob.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();


        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Proizvodi, (NavigationPage)Detail);
          
         


        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Proizvodi:
                        MenuPages.Add(id, new NavigationPage(new ProizvodiPage()));
                        break;
                    case (int)MenuItemType.Aktivne:
                        MenuPages.Add(id, new NavigationPage(new AktivneNarudzbe()));
                        break;
                    case (int)MenuItemType.Historija:
                        MenuPages.Add(id, new NavigationPage(new Historija()));
                        break;
                    case (int)MenuItemType.MojProfil:
                        MenuPages.Add(id, new NavigationPage(new KorisnickiProfil()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}