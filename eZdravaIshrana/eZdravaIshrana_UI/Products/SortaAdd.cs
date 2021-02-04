using eZdravaIshrana_API.Models;
using eZdravaIshrana_PCL.Util;
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

namespace eZdravaIshrana_UI.Products
{
    public partial class SortaAdd : Form
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper sortaService = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        List<SortaProizvoda> globalsorte = new List<SortaProizvoda>();
        public SortaAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void SortaAdd_Load(object sender, EventArgs e)
        {
         
            HttpResponseMessage respone = vrsteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = respone.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrstaCmb.DataSource = vrste;
                vrstaCmb.DisplayMember = "Naziv";
                vrstaCmb.ValueMember = "VrstaID";

            }
            HttpResponseMessage respone2 = sortaService.GetResponse();
            globalsorte = respone2.Content.ReadAsAsync<List<SortaProizvoda>>().Result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                SortaProizvoda a = new SortaProizvoda();
                VrsteProizvoda b = new VrsteProizvoda();
                b = vrstaCmb.SelectedItem as VrsteProizvoda;
                a.VrstaID = b.VrstaID;
                a.Naziv = textBox1.Text;
                DialogResult = DialogResult.OK;
                HttpResponseMessage respone = sortaService.PostResponse(a);
                if (respone.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspjesno ste dodali novu sortu");
                }
                else 
                {
                    MessageBox.Show("Došlo je do greške");
                }
                this.Close();
            }
        }

        private void vrstaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (vrstaCmb.SelectedIndex == 0)
            {
                e.Cancel = true;

                errorProvider.SetError(vrstaCmb, Global.GetMessage("pvrs_req"));
            }
            else
            {
                errorProvider.SetError(vrstaCmb, "");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBox1, Global.GetMessage("sortaobavezna"));
                return;
            }
            else
            {
                errorProvider.SetError(textBox1, "");
            }
            bool postoji = false;
            foreach (var x in globalsorte)
            {
                if (x.Naziv == textBox1.Text)
                    postoji = true;
            }
            if (postoji == true)
            {
                e.Cancel = true;
                errorProvider.SetError(textBox1, Global.GetMessage("sortapostoji"));
            }
            else 
            {
                errorProvider.SetError(textBox1, "");
            }

        }
    }
}
