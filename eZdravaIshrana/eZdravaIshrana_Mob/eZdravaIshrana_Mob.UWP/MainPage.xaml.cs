using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace eZdravaIshrana_Mob.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("P80QpvgcFa7W0yvCASHQ~6wjwytIjnlpGPvzm2hfYSA~ApAoZNUYz7srwJ2VngrxYcNo-GJKBIzgLWWnNn_8oVB-7aFehu6ogtsrxMc-fwDZ");
            //key za bing mape 
            LoadApplication(new eZdravaIshrana_Mob.App());
        }
    }
}
