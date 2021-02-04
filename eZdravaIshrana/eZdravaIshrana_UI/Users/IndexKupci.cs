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

namespace eZdravaIshrana_UI.Users
{
    public partial class IndexKupci : Form
    {
        private WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        public IndexKupci()
        {
            InitializeComponent();
            kupcidatagrid.AutoGenerateColumns = false;
        }

        public IndexKupci(int id)
        {
            InitializeComponent();
            kupcidatagrid.AutoGenerateColumns = false;
        }

        private void IndexKupci_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            HttpResponseMessage response = kupciService.GetActionResponse("GetByName", imeiprezimeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Kupci> kupci = response.Content.ReadAsAsync<List<Kupci>>().Result;
                kupcidatagrid.DataSource = kupci;
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

        private void kupcidatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kupacID = Convert.ToInt32(kupcidatagrid.SelectedRows[0].Cells[0].Value);
            Users.EditKupca a = new Users.EditKupca(kupacID);
            if (a.ShowDialog() == DialogResult.OK)
                BindForm();
          
        }
    }
}
