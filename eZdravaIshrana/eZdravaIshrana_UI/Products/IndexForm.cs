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

namespace eZdravaIshrana_UI.Products
{
    public partial class IndexForm : Form
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper proizvodjacService = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        WebApiHelper sortaService = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        WebApiHelper proizvodService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        public int globalUlazID;

        public IndexForm()
        {
            InitializeComponent();
            proizvodiGrid.AutoGenerateColumns = false;//a betreva
            dodajnastavkubtn.Visible = false;
      
        }

        public IndexForm(int ulazIDHLP)
        {
            InitializeComponent();
            proizvodiGrid.AutoGenerateColumns = false;//a betreva
            dodajnastavkubtn.Visible = false;
            dodajnastavkubtn.Visible = true;
            globalUlazID = ulazIDHLP;
           
        }

        private void pretragaProizvodaBtn_Click(object sender, EventArgs e)
        {
      
          
            BindForm();
        }
        private void BindForm()
        {
            //if (Convert.ToInt32(proizvodjacCmb.SelectedValue) == null)
            //    proizvodjacCmb.SelectedValue = 0;
            //if (Convert.ToInt32(vrstaCmb.SelectedValue) == null)
            //    proizvodjacCmb.SelectedValue = 0;
            if (cijenaInput.Text == "")
               cijenaInput.Text ="0" ;
            HttpResponseMessage response;
            if (nazivInput.Text == "" && sifraInput.Text != "")
                nazivInput.Text = "Cant Solve";
            if (SortaCmb.SelectedValue == null)
                       response = proizvodService.GetActionResponse("SearchProizvodi", Convert.ToInt32(proizvodjacCmb.SelectedValue), Convert.ToInt32(vrstaCmb.SelectedValue), 0, Convert.ToDecimal(cijenaInput.Text), nazivInput.Text, sifraInput.Text);
            else         
                      response = proizvodService.GetActionResponse("SearchProizvodi", Convert.ToInt32(proizvodjacCmb.SelectedValue), Convert.ToInt32(vrstaCmb.SelectedValue), Convert.ToInt32(SortaCmb.SelectedValue), Convert.ToDecimal(cijenaInput.Text), nazivInput.Text, sifraInput.Text);

            if (response.IsSuccessStatusCode)
            {

                List<esp_Proizvodi_Pretraga_Result> proizvodi = response.Content.ReadAsAsync<List<esp_Proizvodi_Pretraga_Result>>().Result;
                proizvodiGrid.DataSource = proizvodi;
                if (nazivInput.Text == "Cant Solve")
                    nazivInput.Text = "";
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void BindSortaProizvoda()
        {
            HttpResponseMessage respone = sortaService.GetResponseID(vrstaCmb.SelectedValue);
            if (respone.IsSuccessStatusCode)
            {
                List<SortaProizvoda> sorta = respone.Content.ReadAsAsync<List<SortaProizvoda>>().Result;
                sorta.Insert(0, new SortaProizvoda());
                SortaCmb.DataSource = sorta;
                SortaCmb.DisplayMember = "Naziv";
                SortaCmb.ValueMember = "SortaID";
            }
        }

        private void BindProizvodjaci()
        {
            HttpResponseMessage respone = proizvodjacService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Proizvodjac> proizvodjac = respone.Content.ReadAsAsync<List<Proizvodjac>>().Result;
                proizvodjac.Insert(0, new Proizvodjac());
                proizvodjacCmb.DataSource = proizvodjac;
                proizvodjacCmb.DisplayMember = "Ime";
                proizvodjacCmb.ValueMember = "ProizvodjacID";
            }
        }

        private void BindVrsteProizvoda()
        {
            HttpResponseMessage respone = vrsteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = respone.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrstaCmb.DataSource = vrste;
                vrstaCmb.DisplayMember = "Naziv";
                vrstaCmb.ValueMember = "VrstaID";

            }
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindProizvodjaci();
            BindVrsteProizvoda();
       
            BindForm();

            
        }

        private void vrstaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindSortaProizvoda();
        }

        private void noviProizvodBtn_Click(object sender, EventArgs e)
        {
            Products.AddForm noviF = new Products.AddForm();
            if (noviF.ShowDialog() == DialogResult.OK)
                BindForm();
        }

        private void proizvodiGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int proizvodID = Convert.ToInt32(proizvodiGrid.SelectedRows[0].Cells[0].Value);
            Products.AddForm a = new Products.AddForm(proizvodID);
            if (a.ShowDialog() == DialogResult.OK)
                BindForm();
        }

        private void dodajnastavkubtn_Click(object sender, EventArgs e)
        {
            int proizvodID = Convert.ToInt32(proizvodiGrid.SelectedRows[0].Cells[0].Value);
            string vrsta = Convert.ToString(proizvodiGrid.SelectedRows[0].Cells[5].Value);
            string sorta = Convert.ToString(proizvodiGrid.SelectedRows[0].Cells[6].Value);
            string proizvodjac = Convert.ToString(proizvodiGrid.SelectedRows[0].Cells[7].Value);
            
            Storage.NabavkaStavkaAdd novif = new Storage.NabavkaStavkaAdd(proizvodID,globalUlazID, vrsta,sorta,proizvodjac);
            DialogResult = DialogResult.OK;
            if (novif.ShowDialog() == DialogResult.OK)
                BindForm();
            this.Close();
        }
    }
}
