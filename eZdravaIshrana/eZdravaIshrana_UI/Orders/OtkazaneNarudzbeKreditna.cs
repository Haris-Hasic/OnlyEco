using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace eZdravaIshrana_UI.Orders
{
    public partial class OtkazaneNarudzbeKreditna : Form
    {
        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        public OtkazaneNarudzbeKreditna()
        {
            InitializeComponent();
            System.Diagnostics.Process.Start("https://dashboard.stripe.com/login");
        }

        private void OtkazaneNarudzbeKreditna_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgvkarticaa.AutoGenerateColumns = false;
            HttpResponseMessage response = narudzbeService.GetResponse3par("GetPonisteneCC", checkBox1.Checked, txtKupac.Text, txtBrojNar.Text);
            List<esp_Narudzbe_PonistiCC_Result> lista = response.Content.ReadAsAsync<List<esp_Narudzbe_PonistiCC_Result>>().Result;
            dgvkarticaa.DataSource = lista;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dgvkarticaa.DataSource = null;
            HttpResponseMessage response = narudzbeService.GetResponse3par("GetPonisteneCC", checkBox1.Checked, "", "");
            List<esp_Narudzbe_PonistiCC_Result> lista = response.Content.ReadAsAsync<List<esp_Narudzbe_PonistiCC_Result>>().Result;
            dgvkarticaa.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvkarticaa.DataSource = null;
            HttpResponseMessage response;
            if (txtKupac.Text == "" && txtBrojNar.Text != "")
            {
                response = narudzbeService.GetResponse3par("GetPonisteneCC", checkBox1.Checked, "Cant solve", txtBrojNar.Text);
                List<esp_Narudzbe_PonistiCC_Result> lista = response.Content.ReadAsAsync<List<esp_Narudzbe_PonistiCC_Result>>().Result;
                dgvkarticaa.DataSource = lista;
            }
            else {
                response = narudzbeService.GetResponse3par("GetPonisteneCC", checkBox1.Checked, txtKupac.Text, txtBrojNar.Text);
                List<esp_Narudzbe_PonistiCC_Result> lista = response.Content.ReadAsAsync<List<esp_Narudzbe_PonistiCC_Result>>().Result;
                dgvkarticaa.DataSource = lista;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int narudzba = Convert.ToInt32(dgvkarticaa.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response;
            response = narudzbeService.DeleteResponse(narudzba);

            MessageBox.Show("Uspješno ste obrisali narudžbu ( NE ZABORAVITE je izbrisati sa stanice ako je placanje bilo karticom)");

            BindGrid();
        }
    }
}
