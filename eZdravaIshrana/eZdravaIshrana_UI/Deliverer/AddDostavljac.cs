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
using System.Text.RegularExpressions;
namespace eZdravaIshrana_UI.Deliverer
{
    public partial class AddDostavljac : Form
    {
        private WebApiHelper dostavljacServices = new WebApiHelper("http://localhost:2618/", "api/Dostavljaci");
        private WebApiHelper kupciServices = new WebApiHelper("http://localhost:2618/", "api/Kupci");
        Dostavljaci dostavljac;
        int DostavljacID = 0;
        public AddDostavljac()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

        }
        public AddDostavljac(int id)
        {
            InitializeComponent();
           

            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = dostavljacServices.GetResponseID(id);
            dostavljac = response.Content.ReadAsAsync<Dostavljaci>().Result;
            DostavljacID = id;
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
            nazivtxt.Text = dostavljac.Naziv;         
            adresaTxt.Text = dostavljac.Adresa;
            telefonTxt.Text = dostavljac.Telefon;
            faxTxt.Text = dostavljac.Fax;
            emailTxt.Text = dostavljac.Email;
            ziroTxt.Text = dostavljac.ZiroRacuni;
            napomenaTxt.Text = dostavljac.Napomena;
            txtKontaktOsoba.Text = dostavljac.KontaktOsoba;
            txtKorisnickoIme.Text = dostavljac.KorisnickoIme;
            txtWeb.Text = dostavljac.Web;
       } 

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
               
                if (dostavljac == null)
                    dostavljac = new Dostavljaci();
                dostavljac.Naziv = nazivtxt.Text;
                dostavljac.Adresa = adresaTxt.Text;
                dostavljac.Telefon = telefonTxt.Text;
                dostavljac.Fax = faxTxt.Text;
                dostavljac.Email = emailTxt.Text;
                dostavljac.ZiroRacuni = ziroTxt.Text;
                dostavljac.Napomena = napomenaTxt.Text;
                dostavljac.Status = true;
                dostavljac.KorisnickoIme = txtKorisnickoIme.Text;
                dostavljac.KontaktOsoba = txtKontaktOsoba.Text;
                dostavljac.Web = txtWeb.Text;
                if (txtLozinka.Text != "")
                {
                    dostavljac.LozinkaSalt = UIHelper.GenerateSalt();
                    dostavljac.LozinkaHash = UIHelper.GenerateHash(txtLozinka.Text, dostavljac.LozinkaSalt);
                }
                HttpResponseMessage response;

                if (dostavljac.DostavljacID == 0)
                    response = dostavljacServices.PostResponse(dostavljac);
                else
                {
                   
                    response = dostavljacServices.PutResponse(dostavljac.DostavljacID, dostavljac);
                }
                if (response.IsSuccessStatusCode)
                {
                    DialogResult = DialogResult.OK;
                    if (dostavljac.DostavljacID == 0)
                        MessageBox.Show("Dostavljac uspjesno dodat ! (" + response.Content.ReadAsAsync<Dostavljaci>().Result.DostavljacID + ")");
                    else
                        MessageBox.Show("Dostavljac uspjesno updatovan ! ");

                    ClearInput();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
           
            }
        }

        private void ClearInput()
        {
            nazivtxt.Text =  adresaTxt.Text
             = telefonTxt.Text = faxTxt.Text = emailTxt.Text = ziroTxt.Text = napomenaTxt.Text = "";
        }

        private void AddDostavljac_Load(object sender, EventArgs e)
        {

        }



        private void nazivtxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivtxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("naziv_req"));
            }
            else if (nazivtxt.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivtxt, Global.GetMessage("naziv_req"));
            }
            else
            {
                errorProvider.SetError(nazivtxt, "");
            }
        }

        private void adresaTxt_Validating_1(object sender, CancelEventArgs e)
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

        private void emailTxt_Validating_1(object sender, CancelEventArgs e)
        {
            string a = emailTxt.Text;
           
            bool regextacan = false;
            //[a-z]|[A-Z]|[0-9]|[ ]|[-]|[_][.]

            if (Regex.Match(a, "^[a-zA-Z0-9_@.-]*$").Success)
            {
                a = a.Replace('.', ',');
                regextacan = true;
            }
            else {
                e.Cancel = true;
                errorProvider.SetError(emailTxt, Global.GetMessage("string_sc"));
            }

            if (regextacan) { 
            if (String.IsNullOrEmpty(emailTxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailTxt, Global.GetMessage("email_req"));
            }
            else
            {
                try
                {
                    HttpResponseMessage response = dostavljacServices.GetActionResponse("GetCheckEmail", a);
                        Kupci abc = new Kupci();
                        abc = null;
                    MailAddress mail = new MailAddress(emailTxt.Text);
                        if (response.IsSuccessStatusCode)
                        {
                           abc= response.Content.ReadAsAsync<Kupci>().Result;
                        }
                        else
                        {
                            abc = null;
                        }
                        if (abc==null)
                    {
                            errorProvider.SetError(emailTxt, "");
                        }
                    else
                    {
                            e.Cancel = true;
                            errorProvider.SetError(emailTxt, Global.GetMessage("email_ex"));
                          
                    }
             
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailTxt, Global.GetMessage("email_err"));
                }
              }
            }
        }

        private void faxTxt_Validating_1(object sender, CancelEventArgs e)
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

        private void ziroTxt_Validating_1(object sender, CancelEventArgs e)
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

        private void napomenaTxt_Validating_1(object sender, CancelEventArgs e)
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

        private void txtKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
        
            if (String.IsNullOrEmpty(txtKontaktOsoba.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKontaktOsoba, Global.GetMessage("ko_req"));
            }
            else
            {
                errorProvider.SetError(txtKontaktOsoba, "");
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            string a = txtKorisnickoIme.Text;
         

            if (String.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("username_req"));
            }
            else if (txtKorisnickoIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("username_len"));
                return;
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, "");
            }

            if (Regex.Match(a, "^[a-zA-Z0-9_.-]*$").Success)
            {
                a = a.Replace('.', ',');
                HttpResponseMessage response2 = dostavljacServices.GetActionResponse("CheckAcc", a);
                Kupci ab = null;
                if (response2.IsSuccessStatusCode)
                {
                     ab = response2.Content.ReadAsAsync<Kupci>().Result;
                   
                }
                else
                {
                    ab = null;
                  
                }
                if (ab == null)
                {
                    errorProvider.SetError(txtKorisnickoIme, "");
                }
                else { 
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("Acc_exist"));
                }

            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, Global.GetMessage("string_scACC"));
            }

          
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLozinka.Text) && DostavljacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("pass_req"));
            }
            else if (txtLozinka.Text.Length < 3 && DostavljacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, Global.GetMessage("pass_len"));
            }
            else
            {
                errorProvider.SetError(txtLozinka, "");
            }
        }

        private void txtPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtPotvrdaLozinke.Text) && DostavljacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdaLozinke, Global.GetMessage("pass_req"));
            }
            else if (txtPotvrdaLozinke.Text.Length < 3 && DostavljacID == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdaLozinke, Global.GetMessage("pass_len"));
            }
            else if (txtPotvrdaLozinke.Text!=txtLozinka.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrdaLozinke, Global.GetMessage("pass_dismatch"));
            }
            else
            {
                errorProvider.SetError(txtPotvrdaLozinke, "");
            }
        }

      

        private void txtWeb_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtWeb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtWeb, Global.GetMessage("web_req"));
            }
            else
            {
                errorProvider.SetError(txtWeb, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
