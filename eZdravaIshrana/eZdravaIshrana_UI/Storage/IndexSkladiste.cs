using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Storage
{
    public partial class IndexSkladiste : Form
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper proizvodjacService = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        WebApiHelper sortaService = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        int hideid = 0;
        int ulazID=0;
        List<esp_Skadiste_Pretraga_Result> skladisteZaPrikaz = new List<esp_Skadiste_Pretraga_Result>();

        public IndexSkladiste()
        {
            InitializeComponent();
            skladistedatagrid.AutoGenerateColumns = false;
            if (hideid == 0)
                narucibtn.Visible = false;

        }

        public IndexSkladiste(int id)
        {
            InitializeComponent();
            skladistedatagrid.AutoGenerateColumns = false;
            ulazID = id;
            DialogResult = DialogResult.OK;
            if (ulazID ==0)
                narucibtn.Visible = true;
        }

        private void IndexSkladiste_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindVrsteProizvoda();
        }

        private void BindGrid()
        {

            HttpResponseMessage response;
            HttpResponseMessage response2;
            Skladista ab = vrstacmb.SelectedItem as Skladista;
            if (ab == null)
            {
                response = skladisteService.GetActionResponseID("GetAllUlazi", 0);
                response2 = skladisteService.GetActionResponseID("GetAllIzlazi", 0);
            }
            else { 
            response = skladisteService.GetActionResponseID("GetAllUlazi", ab.SkladisteID);
            response2 = skladisteService.GetActionResponseID("GetAllIzlazi", ab.SkladisteID);
            }
            skladisteZaPrikaz.Clear();

            List<esp_SkadisteGetIzlazi_zastaanje_Result> ListaIzlaza = response2.Content.ReadAsAsync<List<esp_SkadisteGetIzlazi_zastaanje_Result>>().Result;
            List<esp_SkadisteGetUlazi_zastaanje_Result> ListaUlaza = response.Content.ReadAsAsync<List<esp_SkadisteGetUlazi_zastaanje_Result>>().Result;
            foreach (var x in ListaUlaza)
            {
                esp_Skadiste_Pretraga_Result a = new esp_Skadiste_Pretraga_Result();
                a.Adresa = x.Adresa;
                a.Ime_proizvodjac = x.Ime_proizvodjac;
                a.Prezime_proizvodjaca = x.Prezime_proizvodjaca;
                a.ProizvodID = x.ProizvodID;
                a.SkladisteID = x.SkladisteID;
                a.Vrsta = x.Vrsta;
                a.Sorta = x.Sorta;
                a.Proizvod = x.Proizvod;
                a.Skladiste = x.Skladiste;
                a.Nabavljeno = x.Stanje;
                skladisteZaPrikaz.Add(a);
            }
            foreach (var x in ListaIzlaza)
            {
                bool pronadjen = false;
                foreach (var y in skladisteZaPrikaz)
                {
                    if (y.ProizvodID == x.ProizvodID && x.SkladisteID == y.SkladisteID)
                    {
                        pronadjen = true;
                        y.Naruceno =Convert.ToInt32(x.Otislo);                     
                    }
                }
                if (pronadjen == false)
                {
                    esp_Skadiste_Pretraga_Result a = new esp_Skadiste_Pretraga_Result();
                    a.Adresa = x.Adresa;
                    a.Ime_proizvodjac = x.Ime_proizvodjac;
                    a.Prezime_proizvodjaca = x.Prezime_proizvodjaca;
                    a.ProizvodID = x.ProizvodID;
                    a.SkladisteID = x.SkladisteID;
                    a.Vrsta = x.Vrsta;
                    a.Sorta = x.Sorta;
                    a.Proizvod = x.Proizvod;
                    a.Skladiste = x.Skladiste;
                    a.Nabavljeno = 0;
                    a.Naruceno =Convert.ToInt32(x.Otislo);
                    skladisteZaPrikaz.Add(a);
                }
            }

            foreach (var x in skladisteZaPrikaz)
            {
                if (x.Nabavljeno == 0)
                    x.Stanje_na_skladistu = x.Naruceno * -1;
                else
                {
                    x.Stanje_na_skladistu = x.Nabavljeno - x.Naruceno;
                }
            }
            skladisteZaPrikaz=skladisteZaPrikaz.OrderBy(x=>x.Stanje_na_skladistu).ToList();
            skladistedatagrid.DataSource = null;
            skladistedatagrid.DataSource = skladisteZaPrikaz;
            
       
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindVrsteProizvoda()
        {
            HttpResponseMessage respone = skladisteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Skladista> skladista = respone.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                vrstacmb.DataSource = skladista;
                vrstacmb.DisplayMember = "Naziv";
                vrstacmb.ValueMember = "SkladisteID";

            }
        }
      

    

        private void skladistedatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int skladisteID = Convert.ToInt32(skladistedatagrid.SelectedRows[0].Cells[0].Value);
            Storage.AddSkladiste novif = new Storage.AddSkladiste(skladisteID);
            if (novif.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void novoskladistebtn_Click(object sender, EventArgs e)
        {
            Storage.AddSkladiste novif = new Storage.AddSkladiste();
            if (novif.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void narucibtn_Click(object sender, EventArgs e)
        {
            int proizvodID = 0;
            proizvodID = Convert.ToInt32(skladistedatagrid.SelectedRows[0].Cells[1].Value);

            string vrsta = Convert.ToString(skladistedatagrid.SelectedRows[0].Cells[5].Value);
            string sorta = Convert.ToString(skladistedatagrid.SelectedRows[0].Cells[6].Value);
            string ime = Convert.ToString(skladistedatagrid.SelectedRows[0].Cells[7].Value);
            string prezime = Convert.ToString(skladistedatagrid.SelectedRows[0].Cells[8].Value);
            DialogResult = DialogResult.OK;
            if (proizvodID != 0)
            {
                Storage.NabavkaStavkaAdd novif = new Storage.NabavkaStavkaAdd(proizvodID, vrsta, sorta, ime, prezime);
                if (novif.ShowDialog() == DialogResult.OK) { 
                    BindGrid();
                    this.Close();
                }
            }
            else
            {
                Products.IndexForm novif = new Products.IndexForm(Global.UlazIDHLP);

                if (novif.ShowDialog() == DialogResult.OK)
                 BindGrid();
                this.Close();
            }
        }
    }
}
