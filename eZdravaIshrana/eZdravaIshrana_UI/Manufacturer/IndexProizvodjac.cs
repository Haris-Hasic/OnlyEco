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

namespace eZdravaIshrana_UI.Manufacturer
{
    public partial class IndexProizvodjac : Form
    {
       private WebApiHelper proizvodjacServices = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        private WebApiHelper sortaServices = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        public IndexProizvodjac()
        {
            InitializeComponent();
        }

        private void IndexProizvodjac_Load(object sender, EventArgs e)
        {
            BindSorte();
            Bindgrid();
        }

        private void Bindgrid()
        {
            HttpResponseMessage response;
            if(ImeiPrezimetxt.Text!="" && nazivProizvodatxt.Text=="")
                response = proizvodjacServices.GetResponse3par("PretragaProizvodjaca", sortaCmb.SelectedValue , ImeiPrezimetxt.Text,nazivProizvodatxt.Text);
            else
                response = proizvodjacServices.GetResponse3par("PretragaProizvodjaca", sortaCmb.SelectedValue, "Cant solve", nazivProizvodatxt.Text);

            if (response.IsSuccessStatusCode)
            {
                List<esp_Proizvodjac_Pretraga_Result> proizvodjaci = response.Content.ReadAsAsync<List<esp_Proizvodjac_Pretraga_Result>>().Result;
                proizvodjacDataGrid.DataSource = proizvodjaci;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void BindSorte()
        {
            HttpResponseMessage respone = sortaServices.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<SortaProizvoda> sorta = respone.Content.ReadAsAsync<List<SortaProizvoda>>().Result;
                sorta.Insert(0, new SortaProizvoda());
                sortaCmb.DataSource = sorta;
                sortaCmb.DisplayMember = "Naziv";
                sortaCmb.ValueMember = "SortaID";
            }
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            Bindgrid();
        }
    }
}
