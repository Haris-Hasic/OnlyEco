using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eZdravaIshrana_Mob.Services;
using eZdravaIshrana_Mob.Views;
using Xamarin.Essentials;

namespace eZdravaIshrana_Mob
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Brush_experimental" });
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
            //MainPage = new NavigationPage( new MainPage());
          // MainPage = new MainPage(); //kupoac
            //MainPage = new Master(); //dostavljac
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
