using eZdravaIshrana_Mob.ViewModels;
using eZdravaIshrana_PCL.Model;
using eZdravaIshrana_PCL.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eZdravaIshrana_Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmbalazaPovratna : ContentPage
    {

        WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");

        WebApiHelper ambalazastavkaService = new WebApiHelper("http://localhost:2618/", "api/AmbalazaStavke");

        public Izlaz izlazhlp;
        public Kupci kupac { get; set; }
        public int brojibodove { get; set; }
        private AmbalazaVM model = null;
      
        public bool prikaz = false;

        public AmbalazaPovratna(Izlaz prosljedena)
        {
            InitializeComponent();
            BindingContext = model = new AmbalazaVM();
            izlazhlp = prosljedena;
            brojibodove = 0;
            Global.ambalazastavkehlp.Clear();
            if(Global.hlpambalaza==0)
            Global.hlpambalaza = prosljedena.NarudzbaID;
            if (Global.hlpambalaza == prosljedena.NarudzbaID)
            {

            }
            else {
                Global.hlpambalaza = prosljedena.NarudzbaID;
                Global.AmbList2.Clear();
            }
           HttpResponseMessage response;
            response = kupciService.GetResponseID(prosljedena.KupacID);
            kupac = response.Content.ReadAsAsync<Kupci>().Result;
            Imeliste1.ItemsSource = Global.AmbList2;
            int a = 0;
            foreach (var x in Global.AmbList2)
            {
                brojibodove += x.Kolicina * x.Brbodova;
            }
            bodova.Text = brojibodove.ToString();
         

            Imekupca.Text = kupac.Ime + " " + kupac.Prezime;

         //hidati
        }
        public AmbalazaPovratna(Izlaz prosljedena,bool a)
        {
            //prikaz
            InitializeComponent();
            prikaz = a;
            BindingContext = model = new AmbalazaVM();
            izlazhlp = prosljedena;
            brojibodove = 0;
            Global.ambalazastavkehlp.Clear();
            HttpResponseMessage response;
            response = kupciService.GetResponseID(prosljedena.KupacID);
            kupac = response.Content.ReadAsAsync<Kupci>().Result;
            HttpResponseMessage response2;
            response2 = ambalazastavkaService.GetActionResponseID("GetAmbalaza", prosljedena.IzlazID);
            List<AmbalazaStavke> hlp = new List<AmbalazaStavke>();
            hlp = response2.Content.ReadAsAsync<List<AmbalazaStavke>>().Result;
            Global.AmbList2.Clear();
            foreach (var x in hlp)
            {
                x.Ukupno = x.Kolicina * x.Brbodova;
                Global.AmbList2.Add(x);
                model.AmbList.Add(x);
                brojibodove += x.Ukupno;
            }
            bodova.Text = brojibodove.ToString();
            Imekupca.Text = kupac.Ime + " " + kupac.Prezime;
            Hidefunk();
            
            cmbAmb.SelectedIndex = 0;
        }

        private void Hidefunk()
        {
            hide1.IsVisible = false;
            hide3.IsVisible = false;
            hide5.IsVisible = false;
            hide11.IsVisible = false;
            hide12.IsVisible = false;
            txtkolicina.IsVisible = false;
            cmbAmb.IsVisible = false;
            txtnaslov.IsVisible=false;
            Imeliste1.IsVisible = false;
            Imeliste2.IsVisible = true;
            Imeliste2lbl.IsVisible = true;


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isValid = true;

             if (cmbAmb.SelectedIndex == -1)
            {
                isValid = false;
                cmberror.IsVisible = true;
                cmberror.Text = "Molimo vas odaberite ambalazu ";
            }
            else
            {
                cmberror.IsVisible = false;
            }
            if (txtkolicina.Text == "" || Convert.ToInt32(txtkolicina.Text) == 0) { 
                isValid = false;
                kolicinaerror.IsVisible = true;
                kolicinaerror.Text = "Kolicina nije u ispravnom formatu ";
            }
            else
            {
                kolicinaerror.IsVisible = false;
            }
            if (isValid) {
                bool hlp = true;
            AmbalazaStavke nova = new AmbalazaStavke();
            AmbalazaStavke temp = new AmbalazaStavke();
            AmbalazaStavke temp2 = new AmbalazaStavke();
            nova.AmbalazaID = model._selectedAmbalaza.AmbalazaId;
            nova.Kolicina = Convert.ToInt32(txtkolicina.Text);
            nova.Brbodova = model._selectedAmbalaza.Brbodova;
            nova.Naziv = model._selectedAmbalaza.Naziv;
            nova.Ukupno = nova.Brbodova * nova.Kolicina;
            nova.IzlazID = izlazhlp.IzlazID;
            nova.DostavljacID = Global.prijavljeniDostavljac.DostavljacID;
            nova.KupacID = izlazhlp.KupacID;
                temp = nova;
                foreach (var x in Global.AmbList2)
                {
                    if (nova.AmbalazaID == x.AmbalazaID)
                    {
                        temp2 = x;
                        temp.Kolicina = x.Kolicina + nova.Kolicina;
                        temp.Ukupno = nova.Brbodova * nova.Kolicina;
                        hlp = false;
                      
                   
                    }
                }
                if (hlp) {
                    Global.AmbList2.Add(nova);
                    IzracunajBodove();
                }
                else
                {
                    Global.AmbList2.Remove(temp2);
                    Global.AmbList2.Add(temp);
                    IzracunajBodove();
                }
              
            }
        }

        private void IzracunajBodove()
        {
            brojibodove = 0;
            foreach (var x in Global.AmbList2)
            {
                brojibodove = brojibodove + x.Ukupno;
            }
            bodova.Text = brojibodove.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
            var button = sender as Button;
            var item = button.BindingContext as AmbalazaStavke;
            
            Global.AmbList2.Remove(item);
            IzracunajBodove();


        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            foreach (var x in Global.AmbList2)
            {
                Global.ambalazastavkehlp.Add(x);
            }
            await Navigation.PopAsync();
        }
    }
}