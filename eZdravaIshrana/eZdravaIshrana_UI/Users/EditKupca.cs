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

namespace eZdravaIshrana_UI.Users
{
    public partial class EditKupca : Form
    {
        private WebApiHelper kupciService = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        private Kupci kupac { get; set; }

        int kupacID = 0;
        public EditKupca(int id)
        {
            InitializeComponent();
          
            this.AutoValidate = AutoValidate.Disable;

            kupacID = id;
            HttpResponseMessage response = kupciService.GetResponseID(kupacID);
           
            if (response.IsSuccessStatusCode)
            {
                kupac = response.Content.ReadAsAsync<Kupci>().Result;

                LoadForm();
            }
        }

        private void LoadForm()
        {
            imeInput.Text = kupac.Ime;
            prezimeInput.Text = kupac.Prezime;
            emailInput.Text = kupac.Email;
            statuschb.Checked = kupac.Status;
            korisnickoimeInput.Text = kupac.KorisnickoIme;
        }

        private void EditKupca_Load(object sender, EventArgs e)
        {

        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                
                kupac.Ime = imeInput.Text;
                kupac.Prezime = prezimeInput.Text;
                kupac.Email = emailInput.Text;
                kupac.Status = statuschb.Checked;
                kupac.KorisnickoIme = korisnickoimeInput.Text;
                if (lozinkaInput.Text != "")
                {
                    kupac.LozinkaSalt = UIHelper.GenerateSalt();
                    kupac.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, kupac.LozinkaSalt);
                }
          

            
                HttpResponseMessage response;
                
                    response = kupciService.PutResponse(kupac.KupacID, kupac);
                
                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Kupac uspjesno updatovan ! (" + kupac.KupacID + ")");
                

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
            imeInput.Text = prezimeInput.Text = emailInput.Text = korisnickoimeInput.Text = "";

        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Global.GetMessage("fname_req"));
            }
            else if (imeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Global.GetMessage("fname_len"));
            }
            else
            {
                errorProvider.SetError(imeInput, "");
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Global.GetMessage("sname_req"));
            }
            else if (imeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Global.GetMessage("sname_len"));
            }
            else
            {
                errorProvider.SetError(prezimeInput, "");
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Global.GetMessage("email_req"));
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailInput.Text);
                    errorProvider.SetError(emailInput, "");
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Global.GetMessage("email_err"));
                }
            }
        }

        private void korisnickoimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoimeInput, Global.GetMessage("username_req"));
            }
            else if (korisnickoimeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoimeInput, Global.GetMessage("username_len"));
            }
            else
            {
                errorProvider.SetError(korisnickoimeInput, "");
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaInput.Text) && kupacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetMessage("pass_req"));
            }
            else if (lozinkaInput.Text.Length < 3 && kupacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetMessage("pass_len"));
            }
            else
            {
                errorProvider.SetError(lozinkaInput, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
