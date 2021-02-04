using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Manufacturer
{
    public partial class AddProizvodjac : Form
    {
        private WebApiHelper proizvodjacServices = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        Proizvodjac proizvodjac;
        int ProizvodjacID;
        public AddProizvodjac()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
        }
        public AddProizvodjac(int id)
        {
            InitializeComponent();
  
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = proizvodjacServices.GetResponseID(id);
            proizvodjac = response.Content.ReadAsAsync<Proizvodjac>().Result;
            ProizvodjacID = id;
            if (response.IsSuccessStatusCode)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void LoadData()
        {
            imetxt.Text = proizvodjac.Ime;
            prezimetxt.Text = proizvodjac.Prezime;
            adresaTxt.Text = proizvodjac.Adresa;
            telefonTxt.Text = proizvodjac.Telefon;
            faxTxt.Text = proizvodjac.Fax;
            emailTxt.Text = proizvodjac.Email;
            ziroTxt.Text = proizvodjac.ZiroRacuni;
            napomenaTxt.Text = proizvodjac.Napomena;
        }

        private void AddProizvodjac_Load(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (proizvodjac == null)
                    proizvodjac = new Proizvodjac();
                proizvodjac.Ime = imetxt.Text;
                proizvodjac.Prezime = prezimetxt.Text;
                proizvodjac.Adresa = adresaTxt.Text;
                proizvodjac.Telefon = telefonTxt.Text;
                proizvodjac.Fax = faxTxt.Text;
                proizvodjac.Email = emailTxt.Text;
                proizvodjac.ZiroRacuni = ziroTxt.Text;
                proizvodjac.Napomena = napomenaTxt.Text;
                proizvodjac.Status = true;

                HttpResponseMessage response;

                if (proizvodjac.ProizvodjacID == 0)
                    response = proizvodjacServices.PostResponse(proizvodjac);
                else
                {
                   
                    response = proizvodjacServices.PutResponse(proizvodjac.ProizvodjacID, proizvodjac);
                }
                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    if (proizvodjac.ProizvodjacID == 0)
                        MessageBox.Show("Proizvodjač uspjesno dodat ! (" + response.Content.ReadAsAsync<Proizvodjac>().Result.ProizvodjacID + ")");
                    else
                        MessageBox.Show("Proizvodjač uspjesno updatovan ! ");

                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
                ClearInput();
                this.Close();
            }
        }

        private void ClearInput()
        {
            imetxt.Text = prezimetxt.Text = adresaTxt.Text
             = telefonTxt.Text = faxTxt.Text = emailTxt.Text = ziroTxt.Text = napomenaTxt.Text = "";
        }

        private void imetxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imetxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imetxt, Global.GetMessage("fname_req"));
            }
            else if (imetxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(imetxt, Global.GetMessage("fname_len"));
            }
            else
            {
                errorProvider.SetError(imetxt, "");
            }
        }

        private void prezimetxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimetxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimetxt, Global.GetMessage("sname_req"));
            }
            else if (prezimetxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(prezimetxt, Global.GetMessage("sname_len"));
            }
            else
            {
                errorProvider.SetError(prezimetxt, "");
            }
        }

        private void adresaTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(adresaTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(adresaTxt, Global.GetMessage("dadresa_req"));
            }
            else if (adresaTxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(adresaTxt, Global.GetMessage("dadresa_len"));
            }
            else
            {
                errorProvider.SetError(adresaTxt, "");
            }
        }

        private void telefonTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonTxt, Global.GetMessage("tel_req"));
            }
            else if (!telefonTxt.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(telefonTxt, Global.GetMessage("tel_len"));
            }
            else
            {
                errorProvider.SetError(telefonTxt, "");
            }
        }

        private void emailTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailTxt, Global.GetMessage("email_req"));
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailTxt.Text);
                    errorProvider.SetError(emailTxt, "");
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailTxt, Global.GetMessage("email_err"));
                }
            }
        }

        private void faxTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(faxTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(faxTxt, Global.GetMessage("fax_req"));
            }
            else if (faxTxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(faxTxt, Global.GetMessage("fax_len"));
            }
            else
            {
                errorProvider.SetError(faxTxt, "");
            }
        }

        private void ziroTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ziroTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ziroTxt, Global.GetMessage("zir_req"));
            }
            else if (!ziroTxt.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(ziroTxt, Global.GetMessage("zir_len"));
            }
            else
            {
                errorProvider.SetError(ziroTxt, "");
            }
        }

        private void napomenaTxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(napomenaTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(napomenaTxt, Global.GetMessage("nap_req"));
            }
            else
            {
                errorProvider.SetError(napomenaTxt, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
