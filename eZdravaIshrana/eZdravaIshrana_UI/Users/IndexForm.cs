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
    public partial class IndexForm : Form
    {
        private WebApiHelper korisniciService = new WebApiHelper("http://localhost:2618/", "api/Korisnici");
        public IndexForm()
        {
            InitializeComponent();
            korisniciGrid.AutoGenerateColumns = false;
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            BindForm();
            
        }
        private void BindForm()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici",imeiprezimeInput.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<Korisnici> korisnici = response.Content.ReadAsAsync<List<Korisnici>>().Result;
                korisniciGrid.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void noviKorisnikBtn_Click(object sender, EventArgs e)
        {
            Users.AddForm noviF = new Users.AddForm();
            
           if(noviF.ShowDialog()== DialogResult.OK)
                      BindForm();
         
        }

        private void traziBtn_Click(object sender, EventArgs e)
        {
            BindForm();
        }

        private void korisniciGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int korisnikID = Convert.ToInt32(korisniciGrid.SelectedRows[0].Cells[0].Value);
            Users.AddForm a = new Users.AddForm(korisnikID);
            if (a.ShowDialog() == DialogResult.OK)
                BindForm();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (korisniciGrid.SelectedRows.Count>0) {
                Korisnici id = korisniciGrid.SelectedRows[0].DataBoundItem as Korisnici;
                id.Status = !id.Status;
                HttpResponseMessage response;
                response = korisniciService.PutCustomResponse("PutcustomKorisnicistatus", id.KorisnikID,id);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno ste promjenili status  korisnika"+ "( " +id.Status.ToString()+" )");
                    BindForm();
                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
                }
            }
        }
    }
}
