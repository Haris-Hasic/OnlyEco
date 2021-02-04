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
    public partial class ActiveForm : Form
    {
        WebApiHelper narudzbeServices = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");

        private List<esp_Narudzbe_SelectAktivne_Result> aktivneNarudzbe { get; set; }
        public ActiveForm()
        {
            InitializeComponent();
        }

        private void ActiveForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = narudzbeServices.GetActionResponseNoPar("GetAktivneNarudzbe");
            if (response.IsSuccessStatusCode)
            {
                aktivneNarudzbe = response.Content.ReadAsAsync<List<esp_Narudzbe_SelectAktivne_Result>>().Result;
                narudzbeGrid.DataSource = aktivneNarudzbe;
                narudzbeGrid.Columns[0].Visible = false;
                narudzbeGrid.Columns[2].Visible = false;
            }
        }

        private void narudzbeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsForm detaljiNarudzbeForm = new DetailsForm(aktivneNarudzbe[e.RowIndex]);
            if (detaljiNarudzbeForm.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void narudzbeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
