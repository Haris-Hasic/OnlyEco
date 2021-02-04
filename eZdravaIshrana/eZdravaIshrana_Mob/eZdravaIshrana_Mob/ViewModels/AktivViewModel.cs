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
    public class AktivViewModel : BaseViewModel
    {
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");

        public ObservableCollection<Narudzbe> NList { get; set; } = new ObservableCollection<Narudzbe>();
        public AktivViewModel()
        {
            InitCommand = new Command(async () => await Init());
            //Init();
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            HttpResponseMessage narudzaResponse;
            // GetBrojNarudzbi
            narudzaResponse = narudzbeService.GetActionResponseID("GetNarudzbeAktive", Global.prijavljeniKupac.KupacID);
            List<Narudzbe> aktivne = narudzaResponse.Content.ReadAsAsync<List<Narudzbe>>().Result;
            NList.Clear();
            foreach (var x in aktivne)
            {
                if (x.PayByCard == true)
                {
                    x.PayByCardString = "Karticom";
                }
                else 
                { 
                    x.PayByCardString = "Kešom";
                }
                x.DatumPrikaz = x.Datum.ToString("dd-MM-yyyy");
                NList.Add(x);
            }
        
        }
    }
}
