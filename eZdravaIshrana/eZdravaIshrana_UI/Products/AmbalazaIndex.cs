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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Products
{
    public partial class AmbalazaIndex : Form
    {

        private WebApiHelper AmbalazaService = new WebApiHelper("http://localhost:2618/", "api/Ambalaza");
        List<Ambalaza> ambalazas = new List<Ambalaza>();
        Ambalaza ambalazasedit = new Ambalaza();
        int ambalazaID = 0;
        public AmbalazaIndex()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void AmbalazaIndex_Load(object sender, EventArgs e)
        {
            BindForm();

        }

        private void BindForm(List<Ambalaza> nova = null)
        {
            if (nova == null)
            {
                HttpResponseMessage response = AmbalazaService.GetResponse();
                dataGridView1.AutoGenerateColumns = false;
                if (response.IsSuccessStatusCode)
                {
                    ambalazas = response.Content.ReadAsAsync<List<Ambalaza>>().Result;
                    dataGridView1.DataSource = ambalazas;
                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
                }
            }
            else
                dataGridView1.DataSource = nova;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ambalaza> nova = new List<Ambalaza>();
            foreach (var x in ambalazas)
            {
                if (x.Naziv.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    nova.Add(x);
                }
            }
            BindForm(nova);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Ambalaza nova = new Ambalaza();
            nova.Naziv = textBox2.Text;
            nova.Brbodova = Convert.ToInt32(textBox3.Text);
            if (ambalazaID == 0)
            {
               
                AmbalazaService.PostResponse(nova);
              
         MessageBox.Show("Uspjesno ste dodali novu ambalažu");
               
            }
            else {
                nova.AmbalazaID = ambalazaID;
                AmbalazaService.PutResponse(nova.AmbalazaID, nova);
                MessageBox.Show("Uspjesno ste editovali  ambalažu");

            }
            BindForm();
            textBox2.Text = "";
            textBox3.Text = "";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             ambalazaID =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = AmbalazaService.GetResponseID(ambalazaID);
            ambalazasedit = response.Content.ReadAsAsync<Ambalaza>().Result;
                
           
            textBox2.Text=ambalazasedit.Naziv;
            textBox3.Text=ambalazasedit.Brbodova.ToString();

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox2, Global.GetMessage("dnaziv_req"));
            }
            else if (textBox2.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox2, Global.GetMessage("dnaziv_len"));
            }
            else
            {
                errorProvider.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text.Trim(), @"^[0-9]*$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox3, Global.GetMessage("kolicina_err"));
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox3, Global.GetMessage("kolicina_req"));
            }
            else
                errorProvider.SetError(textBox3, "");
        }
    }
}
