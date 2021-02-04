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

namespace eZdravaIshrana_UI.Supply
{
    public partial class NabavkaEdit : Form
    {
        private WebApiHelper ulaziService = new WebApiHelper("http://localhost:2618/", "api/Ulazi");
        private WebApiHelper dobavljacService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");
        private WebApiHelper skladistaService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        Ulazi ulaz;
        int ulazID;

        public NabavkaEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = ulaziService.GetResponseID(id);
         
            ulazID = id;
            if (response.IsSuccessStatusCode)
            {
                ulaz = response.Content.ReadAsAsync<Ulazi>().Result;
                BindDobavljaci(ulaz.DobavljacID);
                BindSkladiste(ulaz.SkladisteID);
                brojfaktureinput.Text = ulaz.BrojFakture;
                datumtp.Value = ulaz.Datum;
             
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void BindSkladiste(int id)
        {
            HttpResponseMessage respone = skladistaService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Skladista> skladista = respone.Content.ReadAsAsync<List<Skladista>>().Result;
            
                Skladistecmb.DataSource = skladista;
                Skladistecmb.DisplayMember = "Naziv";
                Skladistecmb.ValueMember = "SkladisteID";
                Skladistecmb.SelectedValue = id;


            }
        }

        private void NabavkaEdit_Load(object sender, EventArgs e)
        {
        
        }
        private void BindDobavljaci(int id)
        {
            HttpResponseMessage respone = dobavljacService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Dobavljaci> dobavljaci = respone.Content.ReadAsAsync<List<Dobavljaci>>().Result;
                dobavljaccmb.DataSource = dobavljaci;
                dobavljaccmb.DisplayMember = "Naziv";
                dobavljaccmb.ValueMember = "DobavljacID";
                dobavljaccmb.SelectedValue = id;
            
            }
        }

        private void spasibtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                ulaz.BrojFakture = brojfaktureinput.Text;
                ulaz.Datum = datumtp.Value;
                ulaz.SkladisteID = Convert.ToInt32(Skladistecmb.SelectedValue);
                ulaz.DobavljacID = Convert.ToInt32(dobavljaccmb.SelectedValue);
                HttpResponseMessage response = ulaziService.PutResponse(ulaz.UlazID, ulaz);
                DialogResult = DialogResult.OK;
                if (response.IsSuccessStatusCode)
                {

                    MessageBox.Show("Stavka uspjesno updatovan ! ");

                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
                this.Close();

            }
        }

        private void brojfaktureinput_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(brojfaktureinput.Text.Trim(), @"^[0-9]*$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(brojfaktureinput, Global.GetMessage("brojfakture_err"));
            }
            else if (String.IsNullOrEmpty(brojfaktureinput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(brojfaktureinput, Global.GetMessage("brojfakture_req"));
            }
            else
                errorProvider.SetError(brojfaktureinput, "");
        }

        private void Skladistecmb_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dobavljaccmb_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
