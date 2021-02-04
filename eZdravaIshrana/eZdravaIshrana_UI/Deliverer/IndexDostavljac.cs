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

namespace eZdravaIshrana_UI.Deliverer
{
    public partial class IndexDostavljac : Form
    {
        private WebApiHelper dostavljacServices = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");
        public IndexDostavljac()
        {
            InitializeComponent();
            dostavljacdatagrid.AutoGenerateColumns = false;
        }

        private void IndexDostavljac_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response;

            response = dostavljacServices.GetActionResponse("GetDostavljacBystr", ImeiPrezimetxt.Text);

            if (response.IsSuccessStatusCode)
            {
                List<esp_Dostavljac_Pretraga_Result> dostavljaci = response.Content.ReadAsAsync<List<esp_Dostavljac_Pretraga_Result>>().Result;
                dostavljacdatagrid.DataSource = dostavljaci;
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

        private void noviDostavljacbtn_Click(object sender, EventArgs e)
        {
          
            Deliverer.AddDostavljac noviF = new Deliverer.AddDostavljac();
            if (noviF.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void dostavljacdatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dostavljacId = Convert.ToInt32(dostavljacdatagrid.SelectedRows[0].Cells[0].Value);
            Deliverer.AddDostavljac noviF = new Deliverer.AddDostavljac(dostavljacId);
            if (noviF.ShowDialog() == DialogResult.OK)
                BindGrid();
        }
    }
}
