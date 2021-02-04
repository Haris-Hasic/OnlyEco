using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eZdravaIshrana_Mob.ViewModels
{
    public class AmbalazaVM : BaseViewModel
    {
        WebApiHelper ambalazaService = new WebApiHelper("http://localhost:2618/", "api/Ambalaza");

        public Ambalaza _selectedAmbalaza = null;
        public ObservableCollection<Ambalaza> cmb { get; set; } = new ObservableCollection<Ambalaza>();
        public ObservableCollection<AmbalazaStavke> AmbList { get; set; } = new ObservableCollection<AmbalazaStavke>();

        public Ambalaza AmbalazaVP
        {
            get { return _selectedAmbalaza; }
            set
            {
                SetProperty(ref _selectedAmbalaza, value);
            }
        }
        public AmbalazaVM()
        {
          
            InitCommand = new Command(async () => Init());

            //Init();

        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            HttpResponseMessage Response;

            Response = ambalazaService.GetResponse();
            List<Ambalaza> list = Response.Content.ReadAsAsync<List<Ambalaza>>().Result;
       
            foreach (var x in list)
            {
                cmb.Add(x);
            }
            
        }



    }

}
