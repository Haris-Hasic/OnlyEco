using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       // WebApiHelper service = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}