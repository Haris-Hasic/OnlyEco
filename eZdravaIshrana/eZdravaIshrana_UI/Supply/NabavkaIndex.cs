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
    public partial class Nabavka : Form
    {
        private WebApiHelper ulaziServices = new WebApiHelper("http://localhost:2618/", "api/Ulazi");
        private WebApiHelper skladistaServices = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        int brojac;
        public Nabavka()
        {
            InitializeComponent();
            ulazidatagrid.AutoGenerateColumns = false;
            brojac = 1;
        }

        private void Nabavka_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindSkladista();
        }

        private void BindSkladista()
        {
            HttpResponseMessage respone = skladistaServices.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Skladista> skladista = respone.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladistecmb.DataSource = skladista;
                skladistecmb.DisplayMember = "Naziv";
                skladistecmb.ValueMember = "SkladisteID";

            }
        }

        private void BindGrid()
        {
            HttpResponseMessage response;
            string hlp1, hlp2;
            hlp1 = datumOD.Value.Date.ToString("yyyy-MM-dd");
            hlp2 = datumDo.Value.Date.ToString("yyyy-MM-dd");
            if (brojac == 1)
            {
                response = ulaziServices.GetResponse3par("Ulazipretraga", skladistecmb.SelectedValue, null, null);
                brojac++;
            }
            else
                response = ulaziServices.GetResponse3par("Ulazipretraga", skladistecmb.SelectedValue, hlp1, hlp2);
            if (response.IsSuccessStatusCode)
            {
                List<esp_Ulazi_Pretraga_Result> ulazi = response.Content.ReadAsAsync<List<esp_Ulazi_Pretraga_Result>>().Result;
                ulazidatagrid.DataSource = ulazi;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void trazibtn_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.UlazIDHLP = 0;
            Supply.NabavkaAdd novif = new Supply.NabavkaAdd();
            if (novif.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void ulazidatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ulazId = Convert.ToInt32(ulazidatagrid.SelectedRows[0].Cells[0].Value);
            Supply.NabavkaAdd novif = new Supply.NabavkaAdd(ulazId);
            if (novif.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ulazId = Convert.ToInt32(ulazidatagrid.SelectedRows[0].Cells[0].Value);

            HttpResponseMessage response;
            response = ulaziServices.DeleteResponse(ulazId);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspješno ste izbrisali selektovanu stavku");
                BindGrid();
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }
    }
}
