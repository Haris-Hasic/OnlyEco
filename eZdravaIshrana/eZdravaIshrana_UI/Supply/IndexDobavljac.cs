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

namespace eZdravaIshrana_UI.Supply
{
    public partial class IndexDobavljac : Form
    {
        private WebApiHelper dobavljacService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");
        public IndexDobavljac()
        {
            InitializeComponent();
            dobavljaciGrid.AutoGenerateColumns = false;
        }

        private void IndexDobavljac_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            HttpResponseMessage response;
            if (brojNabavkiTxt.Text == "")                
                 response = dobavljacService.GetResponse2par("PretragaDobavljaci", 0, nazivTxt.Text.Trim());
            else
             response = dobavljacService.GetResponse2par("PretragaDobavljaci", Convert.ToInt32(brojNabavkiTxt.Text), nazivTxt.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<esp_Dobavljaci_Pretraga_Result> dobavljaci = response.Content.ReadAsAsync<List<esp_Dobavljaci_Pretraga_Result>>().Result;
                dobavljaciGrid.DataSource = dobavljaci;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindForm();
        }

        private void noviDobavljacBtn_Click(object sender, EventArgs e)
        {
            Supply.AddDobavljac novif = new Supply.AddDobavljac();
            if (novif.ShowDialog() == DialogResult.OK)
                BindForm();
        }

        private void dobavljaciGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dobavljacID = Convert.ToInt32(dobavljaciGrid.SelectedRows[0].Cells[0].Value);
            Supply.AddDobavljac novif = new Supply.AddDobavljac(dobavljacID);
            if (novif.ShowDialog() == DialogResult.OK)
                BindForm();
        }

        private void nabavkeBtn_Click(object sender, EventArgs e)
        {
            int dobavljacID = Convert.ToInt32(dobavljaciGrid.SelectedRows[0].Cells[0].Value);
        
            Supply.NabavkeDobavljaci novif = new Supply.NabavkeDobavljaci(dobavljacID);
            if (novif.ShowDialog() == DialogResult.OK)
                BindForm();
        }
    }
}
