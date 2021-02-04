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

namespace eZdravaIshrana_UI.Orders
{
    public partial class EditNarudzbe : Form
    {
        WebApiHelper izlazStavkeServices = new WebApiHelper("http://localhost:2618/", "api/IzlazStavke");
        IzlazStavke izlazStavke;
        int IzlazStavkaID;
     

        public EditNarudzbe(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = izlazStavkeServices.GetActionResponseID("GetIzlaziStavkehlp", id);

            IzlazStavkaID = id;
            if (response.IsSuccessStatusCode)
            {
               
                izlazStavke = response.Content.ReadAsAsync<IzlazStavke>().Result;

                kolicinatxt.Text = izlazStavke.Kolicina.ToString();
                cijenatxt.Text = izlazStavke.Cijena.ToString();
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }
        private void EditNarudzbe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                izlazStavke.Kolicina = Convert.ToInt32(kolicinatxt.Text);

                string hlp = cijenatxt.Text.Trim();
                hlp = hlp.Replace(',', '.');
                izlazStavke.Cijena = Convert.ToDecimal(hlp);

                HttpResponseMessage response = izlazStavkeServices.PutResponse(IzlazStavkaID, izlazStavke);

                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Stavka uspjesno updatovan ! ");

                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void kolicinatxt_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(kolicinatxt.Text.Trim(), @"^[0-9]*$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(kolicinatxt, Global.GetMessage("kolicina_err"));
            }
            else if (String.IsNullOrEmpty(kolicinatxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(kolicinatxt, Global.GetMessage("kolicina_req"));
            }
            else
                errorProvider.SetError(kolicinatxt, "");
        }

        private void cijenatxt_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(cijenatxt.Text.Trim(), @"^[0-9]([\.\,][0-9]{1,2})?$$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(cijenatxt, Global.GetMessage("pcijena_err"));
            }
            else if (String.IsNullOrEmpty(cijenatxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cijenatxt, Global.GetMessage("pcijena_req"));
            }
            else
                errorProvider.SetError(cijenatxt, "");
        }
    }
}
