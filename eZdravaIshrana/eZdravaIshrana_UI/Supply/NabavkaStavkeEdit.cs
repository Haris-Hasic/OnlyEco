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
    public partial class NabavkaStavkeEdit : Form
    {
        private WebApiHelper ulazistavkeService = new WebApiHelper("http://localhost:2618/", "api/UlazStavke");
      
        UlazStavke ulazStavke;
        int ulazstavkeID;
       
        public NabavkaStavkeEdit(int id)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = ulazistavkeService.GetResponseID(id);
          
            ulazstavkeID = id;
            if (response.IsSuccessStatusCode)
            {
                ulazStavke = response.Content.ReadAsAsync<UlazStavke>().Result;

                kolicinatxt.Text = ulazStavke.Kolicina.ToString();
                cijenatxt.Text= ulazStavke.Cijena.ToString();
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void NabavkaStavkeEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
               
                ulazStavke.Kolicina = Convert.ToInt32(kolicinatxt.Text);
             
                string hlp = cijenatxt.Text.Trim();
                hlp = hlp.Replace(',', '.');
                ulazStavke.Cijena = Convert.ToDecimal(hlp);

                HttpResponseMessage response = ulazistavkeService.PutResponse(ulazstavkeID, ulazStavke);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
