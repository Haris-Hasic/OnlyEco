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

namespace eZdravaIshrana_UI.Orders
{
    public partial class IndexNarudzbe : Form
    {
        private WebApiHelper izlaziServices = new WebApiHelper("http://localhost:2618/", "api/Izlazi");
        private WebApiHelper izlazStavkeServices = new WebApiHelper("http://localhost:2618/", "api/IzlazStavke");
        int brojac = 0;
        public IndexNarudzbe()
        {
            InitializeComponent();
            HttpResponseMessage response = izlaziServices.GetResponse3par("Izlazipretraga", null, null, brojracunatxt.Text);
            if (response.IsSuccessStatusCode)
            {
                List<esp_Izlaz_Pretraga_Result> izlazi = response.Content.ReadAsAsync<List<esp_Izlaz_Pretraga_Result>>().Result;
                izlazidatagrid.DataSource = izlazi;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }

        }

        private void IndexNarudzbe_Load(object sender, EventArgs e)
        {
            izlazstavkedatagrid.AutoGenerateColumns = false;
        }

        private void BindGrid()
        {
            HttpResponseMessage response;
            string hlp1, hlp2;
            hlp1 = datumOD.Value.Date.ToString("yyyy-MM-dd");
            hlp2 = datumDo.Value.Date.ToString("yyyy-MM-dd");
            
            response = izlaziServices.GetResponse3par("Izlazipretraga", hlp1, hlp2, brojracunatxt.Text);
            if (response.IsSuccessStatusCode)
            {
                List<esp_Izlaz_Pretraga_Result> izlazi = response.Content.ReadAsAsync<List<esp_Izlaz_Pretraga_Result>>().Result;
                izlazidatagrid.DataSource = izlazi;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void izlazidatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int izlazID = Convert.ToInt32(izlazidatagrid.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = izlazStavkeServices.GetResponseID(izlazID);
            List<esp_IzlazStavke_ByIzlazID_Result> izlazStavke = response.Content.ReadAsAsync<List<esp_IzlazStavke_ByIzlazID_Result>>().Result;
            if (response.IsSuccessStatusCode)
            {
                izlazstavkedatagrid.DataSource = izlazStavke;

            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (izlazstavkedatagrid.RowCount != 0)
            {
                int izlazstavkaID = Convert.ToInt32(izlazstavkedatagrid.SelectedRows[0].Cells[0].Value);
                Orders.EditNarudzbe form = new Orders.EditNarudzbe(izlazstavkaID);
                if (form.ShowDialog() == DialogResult.OK)
                    BindGrid();

            }
        }
    }
}
