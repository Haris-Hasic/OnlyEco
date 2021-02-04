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
    public class HistorijaVM:BaseViewModel
    {
        WebApiHelper IzlaziService = new WebApiHelper("http://localhost:2618/", "api/Izlazi");

        public ObservableCollection<Izlaz> NList { get; set; } = new ObservableCollection<Izlaz>();
      
        public HistorijaVM()
        {
            InitCommand = new Command(async () => await Init());
            //Init();
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            HttpResponseMessage Response;
            // GetBrojNarudzbi
            Response = IzlaziService.GetActionResponseID("IzlaziOcjeni", Global.prijavljeniKupac.KupacID);
            List<Izlaz> aktivne = Response.Content.ReadAsAsync<List<Izlaz>>().Result;
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
                NList.Add(x);
            }

        }

    }
}
