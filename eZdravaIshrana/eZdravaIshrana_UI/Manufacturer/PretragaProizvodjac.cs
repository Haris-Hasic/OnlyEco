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
    public partial class PretragaProizvodjac : Form
    {
        private WebApiHelper proizvodjacServices = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
     
        public PretragaProizvodjac()
        {
            InitializeComponent();
            datagridProizvodjaci.AutoGenerateColumns = false;
            
        }

        private void PretragaProizvodjac_Load(object sender, EventArgs e)
        {
            Bindgrid();
        }

        private void Bindgrid()
        {
            HttpResponseMessage response;
         
                response = proizvodjacServices.GetActionResponse("GetProizvodjacBystr",ImeiPrezimetxt.Text);

            if (response.IsSuccessStatusCode)
            {
                List<Proizvodjac> proizvodjaci = response.Content.ReadAsAsync<List<Proizvodjac>>().Result;
                datagridProizvodjaci.DataSource = proizvodjaci;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manufacturer.AddProizvodjac noviF = new Manufacturer.AddProizvodjac();
            if (noviF.ShowDialog() == DialogResult.OK)
                Bindgrid();
        }

        private void datagridProizvodjaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int proizvodjacId = Convert.ToInt32(datagridProizvodjaci.SelectedRows[0].Cells[0].Value);
            Manufacturer.AddProizvodjac noviF = new Manufacturer.AddProizvodjac(proizvodjacId);
            if (noviF.ShowDialog() == DialogResult.OK)
                Bindgrid();
        }

        private void trazibtn_Click(object sender, EventArgs e)
        {
            Bindgrid();
        }
    }
}
