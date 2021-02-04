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

namespace eZdravaIshrana_UI.Supply
{
    public partial class AddDobavljac : Form
    {
        private WebApiHelper dobavljacService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");

        Dobavljaci dobavljac;
        int dobavljacID = 0;
        public AddDobavljac()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }
        public AddDobavljac(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = dobavljacService.GetResponseID(id);
            dobavljac = response.Content.ReadAsAsync<Dobavljaci>().Result;
            dobavljacID = id;
            if (response.IsSuccessStatusCode)
            {
                LoadDate();
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }

        }

        private void LoadDate()
        {
            nazivtxt.Text = dobavljac.Naziv;
            kontaktOsobaTxt.Text = dobavljac.KontaktOsoba;
            adresaTxt.Text = dobavljac.Adresa;
            telefonTxt.Text = dobavljac.Telefon;
            faxTxt.Text = dobavljac.Fax;
            webtxt.Text = dobavljac.Web;
            emailTxt.Text = dobavljac.Email;
            ziroTxt.Text = dobavljac.ZiroRacuni;
            napomenaTxt.Text = dobavljac.Napomena;
       
        }

        private void AddDobavljac_Load(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (dobavljac == null)
                    dobavljac = new Dobavljaci();
               dobavljac.Naziv = nazivtxt.Text ;
               dobavljac.KontaktOsoba = kontaktOsobaTxt.Text;
               dobavljac.Adresa = adresaTxt.Text;
               dobavljac.Telefon = telefonTxt.Text;
               dobavljac.Fax= faxTxt.Text ;
               dobavljac.Web = webtxt.Text;
               dobavljac.Email= emailTxt.Text;
               dobavljac.ZiroRacuni= ziroTxt.Text;
               dobavljac.Napomena = napomenaTxt.Text;
               dobavljac.Status = true;

                HttpResponseMessage response;
                DialogResult = DialogResult.OK;
                if (dobavljac.DobavljacID == 0)
                    response = dobavljacService.PostResponse(dobavljac);
                else
                {
                 
                    response = dobavljacService.PutResponse(dobavljac.DobavljacID, dobavljac);
                }
                if (response.IsSuccessStatusCode)
                {
                    if (dobavljac.DobavljacID == 0)
                        MessageBox.Show("Dobavljač uspjesno dodat ! (" + response.Content.ReadAsAsync<Dobavljaci>().Result.DobavljacID + ")");
                    else
                        MessageBox.Show("Dobavljač uspjesno updatovan ! ");

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
            nazivtxt.Text = kontaktOsobaTxt.Text = adresaTxt.Text
               = telefonTxt.Text = faxTxt.Text = webtxt.Text = emailTxt.Text = ziroTxt.Text = napomenaTxt.Text = "";
        }

        private void nazivtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivtxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("dnaziv_req"));
            }
            else if (nazivtxt.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("dnaziv_len"));
            }
            else
            {
                errorProvider.SetError(nazivtxt, "");
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

        private void telefonTxt_Validating_1(object sender, CancelEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
