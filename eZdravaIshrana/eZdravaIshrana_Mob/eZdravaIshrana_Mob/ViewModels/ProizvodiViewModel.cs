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
    public class ProizvodiViewModel : BaseViewModel
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        WebApiHelper vrsteProizvodaService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper ocjeneService = new WebApiHelper("http://localhost:2618/", "api/Ocjene");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvodi> ProizvodiList { get; set; } = new ObservableCollection<Proizvodi>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();

        VrsteProizvoda _selectedVP = null;
        public string hlppretraga { get; set; } = "";

        public VrsteProizvoda SelectedVP
        {
            get { return _selectedVP; }
            set
            {
                SetProperty(ref _selectedVP, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init(string a = "")
        {

            HttpResponseMessage list;
            if (SelectedVP != null)
            {       //SearchProizvodiMobile
                list = proizvodiService.GetResponse2par("SearchProizvodiMobile", _selectedVP.VrstaID, hlppretraga);
                List<Proizvodi> ProizvodiList1 = list.Content.ReadAsAsync<List<Proizvodi>>().Result;
                HttpResponseMessage ocjeneResponse;
                ProizvodiList.Clear();
                foreach (var item in ProizvodiList1)
                {
                    ocjeneResponse = ocjeneService.GetActionResponseID("GetProsjek", item.ProizvodID);
                    List<Ocjene> ocjene = ocjeneResponse.Content.ReadAsAsync<List<Ocjene>>().Result;
                    item.Prosjecna = IzracunajProsjek(ocjene);
                    item.Prosjecna = Math.Round(item.Prosjecna,1);
                    ProizvodiList.Add(item);
                }
            }
            else
            {
                list = proizvodiService.GetResponse2par("SearchProizvodiMobile", 0, hlppretraga);

                List<Proizvodi> ProizvodiList2 = list.Content.ReadAsAsync<List<Proizvodi>>().Result;

                ProizvodiList.Clear();
                VrsteProizvodaList.Clear();
                foreach (var item in ProizvodiList2)
                {
                    ProizvodiList.Add(item);
                }
            }
            if (VrsteProizvodaList.Count == 0)
            {
                list = vrsteProizvodaService.GetResponse();
                List<VrsteProizvoda> vplist = list.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                VrsteProizvodaList.Add(new VrsteProizvoda { VrstaID = 0, Naziv = "Prikaži sve vrste" });
                foreach (var item in vplist)
                {
                    VrsteProizvodaList.Add(item);
                }
            }


        }
        private decimal IzracunajProsjek(List<Ocjene> ocjene)
        {
            if (ocjene.Count != 0)
            {
                decimal ukupno = 0;

                foreach (var item in ocjene)
                {
                    ukupno += item.Ocjena;
                }

                return ukupno / ocjene.Count;
            }
            else
                return 0;
        }
    }
}
