using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Users
{
    public partial class AddForm : Form
    {
        private WebApiHelper korisniciService = new WebApiHelper("http://localhost:2618/", "api/Korisnici");
        private WebApiHelper ulogeService = new WebApiHelper("http://localhost:2618/", "api/Uloge");
        private WebApiHelper korisnikUlogeService = new WebApiHelper("http://localhost:2618/", "api/KorisniciUloge");
        private Korisnici korisnik { get; set; }

        int korisnikhlp=0;

        List<KorisniciUloge> ulogekorisnika;
        public AddForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            BindUloge();
        }
        public AddForm(int korisnikID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            BindUloge();
            korisnikhlp = korisnikID;
            HttpResponseMessage response = korisniciService.GetActionResponseID("GetKorisniciByID", korisnikID);
            HttpResponseMessage uloge = korisnikUlogeService.GetResponseID(korisnikID);
            if (response.IsSuccessStatusCode)
            {
                korisnik = response.Content.ReadAsAsync<Korisnici>().Result;
                ulogekorisnika = uloge.Content.ReadAsAsync<List<KorisniciUloge>>().Result;
                
                LoadForm();
            }
        }

        private void LoadForm()
        {
            imeInput.Text = korisnik.Ime;
            prezimeInput.Text = korisnik.Prezime;
            emailInput.Text = korisnik.Email;
            telefonInput.Text = korisnik.Telefon;
            korisnickoimeInput.Text = korisnik.KorisnickoIme;


            for (int i = 0; i < ulogeList.Items.Count; i++)
            {
                for (int j = 0; j < ulogekorisnika.Count; j++)
                {
                    if (((ListBox)ulogeList).Items.Cast<Uloge>().ToList()[i].UlogaID == ulogekorisnika[j].UlogaID)
                    {
                        ulogeList.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
          //  BindUloge();
        }

        private void BindUloge()
        {
            HttpResponseMessage response = ulogeService.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ((ListBox)ulogeList).DataSource = response.Content.ReadAsAsync<List<Uloge>>().Result;
                ((ListBox)ulogeList).DisplayMember = "Naziv";
                ((ListBox)ulogeList).ValueMember = "UlogaID";
                ulogeList.ClearSelected();
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            bool hlp = false;
            if(this.ValidateChildren())
            { 
                if(korisnik==null)
                 korisnik = new Korisnici();
                korisnik.Ime = imeInput.Text;
                korisnik.Prezime = prezimeInput.Text;
                korisnik.Email = emailInput.Text;
                korisnik.Telefon = telefonInput.Text;
                korisnik.KorisnickoIme = korisnickoimeInput.Text;
                if (lozinkaInput.Text != "")
                {
                    korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                    korisnik.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, korisnik.LozinkaSalt);
                }
                korisnik.Status = true;

                korisnik.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();
                HttpResponseMessage response;
                if (korisnik.KorisnikID == 0)
                    response = korisniciService.PostResponse(korisnik);
                else
                {
            
                     response = korisniciService.PutCustomResponse("PutCustomKorisnici", korisnik.KorisnikID, korisnik);
                }
                    if (response.IsSuccessStatusCode)
            {
                    DialogResult = DialogResult.OK;
                    if (korisnik.KorisnikID == 0) {
                        hlp = true;
                MessageBox.Show("Korisnik uspjesno dodat ! (" + response.Content.ReadAsAsync<Korisnici>().Result.KorisnikID + ")");
                    }
                    else
                    {
                        hlp = true;
                        MessageBox.Show("Korisnik uspjesno updatovan ! ");
                    }

                }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode+Environment.NewLine + "Message " + response.ReasonPhrase);
            }
                if (hlp == true) { 
                      this.Close();
                    ClearInput();

                }
            }
        }

      

        private void ClearInput()
        {
            imeInput.Text = prezimeInput.Text = emailInput.Text = telefonInput.Text = lozinkaInput.Text = korisnickoimeInput.Text = "";
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Global.GetMessage("fname_req"));
            }
            else if(imeInput.Text.Length<3)
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
            else if (prezimeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Global.GetMessage("sname_len"));
            }
            else
            {
                errorProvider.SetError(prezimeInput, "");
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(telefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, Global.GetMessage("tel_req"));
            }
            else if (!telefonInput.MaskCompleted)
            {
                e.Cancel = true;
                errorProvider.SetError(telefonInput, Global.GetMessage("tel_len"));
            }
            else
            {
                errorProvider.SetError(telefonInput, "");
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
            if (String.IsNullOrEmpty(lozinkaInput.Text) && korisnikhlp==0)
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetMessage("pass_req"));
            }
            else if (lozinkaInput.Text.Length < 3 && korisnikhlp==0 )
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaInput, Global.GetMessage("pass_len"));
            }
            else
            {
                errorProvider.SetError(lozinkaInput, "");
            }
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Global.GetMessage("uloge_req"));
            }
            else
            {
                errorProvider.SetError(ulogeList, "");
            }
        }

        private void emailInput_Validating_1(object sender, CancelEventArgs e)
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
    }
}
