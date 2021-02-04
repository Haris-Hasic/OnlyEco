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
    public partial class NabavkaAdd : Form
    {
        private WebApiHelper dobavljacService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");
        private WebApiHelper ulazService = new WebApiHelper("http://localhost:2618/", "api/Ulazi");
        private WebApiHelper ulazstavkeService = new WebApiHelper("http://localhost:2618/", "api/UlazStavke");
        private WebApiHelper skladisteService = new WebApiHelper("http://localhost:2618/", "api/Skladista");
        private WebApiHelper dobavljaciService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");
        public int a = 0;
        public int ulazId = 0;
        public Ulazi ulaz;
        public NabavkaAdd()
        {

            InitializeComponent();
            BindDobavljaci();
            BindSkladiste();
            this.AutoValidate = AutoValidate.Disable;
            datagridtemp.AutoGenerateColumns = false;
            datumdtp.Value = DateTime.Now;
            datumdtp.Enabled = false;
            pdvtxt.Text = "0.17";
        }

        public NabavkaAdd(int id)
        {
         
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            BindDobavljaci();
            BindSkladiste();
            datagridtemp.AutoGenerateColumns = false;
            ulazId = id;
            HttpResponseMessage response;
            response = ulazService.GetResponseID(id);
            ulaz = response.Content.ReadAsAsync<Ulazi>().Result;
            pdvtxt.Text = "0.17";
            LoadData();
            BindGrid();
        }

        private void LoadData()
        {
            brojfakturetxt.Text = ulaz.BrojFakture;
            datumdtp.Value = ulaz.Datum;
            iznosracunalbl.Text = ulaz.IznosRacuna.ToString();
            pdvtxt.Text = ulaz.PDV.ToString();
            napomenatxt.Text = ulaz.Napomena;
            skladistecmb.SelectedValue = ulaz.SkladisteID;
            dobavljaccmb.SelectedValue = ulaz.DobavljacID;
        }

        private void NabavkaAdd_Load(object sender, EventArgs e)
        {
     

        }

        private void BindDobavljaci()
        {
            HttpResponseMessage respone = dobavljaciService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Dobavljaci> dobavljaci = respone.Content.ReadAsAsync<List<Dobavljaci>>().Result;
                dobavljaci.Insert(0, new Dobavljaci());
                dobavljaccmb.DataSource = dobavljaci;
                dobavljaccmb.DisplayMember = "Naziv";
                dobavljaccmb.ValueMember = "DobavljacID";
            }
        }

        private void BindSkladiste()
        {
            HttpResponseMessage respone = skladisteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Skladista> skladista = respone.Content.ReadAsAsync<List<Skladista>>().Result;
                skladista.Insert(0, new Skladista());
                skladistecmb.DataSource = skladista;
                skladistecmb.DisplayMember = "Naziv";
                skladistecmb.ValueMember = "SkladisteID";

            }
        }

        private void BindGrid()
        {
            HttpResponseMessage response;
            if (ulazId == 0)
            {
                datagridtemp.DataSource = null;
                datagridtemp.DataSource = Global.ulazstavkeTemp;
            }
            else 
            {
                pdvtxt.ReadOnly = true;
                datumdtp.Enabled = false;
                skladistecmb.Enabled = false;
                brojfakturetxt.ReadOnly = true;
                dobavljaccmb.Enabled = false;
                napomenatxt.ReadOnly = true;
                button1.Visible = false;
            
                button3.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                response = ulazstavkeService.GetActionResponseID("UlazStavkeByUlazID2", ulazId);
                if (response.IsSuccessStatusCode)
                {
                    List<esp_UlazStavkeByUlazID_Prikazi_Result> ulazstavke = response.Content.ReadAsAsync<List<esp_UlazStavkeByUlazID_Prikazi_Result>>().Result;
                    datagridtemp.DataSource = null;
                    datagridtemp.DataSource = ulazstavke;

                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
                }
            }
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
           
                    Storage.IndexSkladiste mored = new Storage.IndexSkladiste(Global.UlazIDHLP);
                if (mored.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                 
                }

            }

        }

        private void ClearInput()
        {
            throw new NotImplementedException();
        }

    

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
      
                Products.IndexForm novif = new Products.IndexForm(Global.UlazIDHLP);
                if (novif.ShowDialog() == DialogResult.OK)
                    BindGrid();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (datagridtemp.Rows.Count != 0)
            {
           
                if (this.ValidateChildren()) { 
                    if (ulazId == 0)
                     {//add post
                    decimal suma = 0;
                    if (ulaz == null)
                        ulaz = new Ulazi();
                    ulaz.Datum = datumdtp.Value;
                    ulaz.BrojFakture = brojfakturetxt.Text;
                    ulaz.DobavljacID = Convert.ToInt32(dobavljaccmb.SelectedValue);

                        foreach (esp_UlazStavkeByUlazID_Prikazi_Result x in Global.ulazstavkeTemp)
                        {
                            suma = suma + (x.Kolicina * x.Cijena);
                        }

                    
                    ulaz.IznosRacuna = suma;
                    ulaz.KorisnikID =  Global.prijavljeniKorisnik.KorisnikID;
                    ulaz.Napomena = napomenatxt.Text;
                    ulaz.SkladisteID = Convert.ToInt32(skladistecmb.SelectedValue);

                    string hlp = pdvtxt.Text.Trim();
                    hlp = hlp.Replace(',', '.');
                    ulaz.PDV = Convert.ToDecimal(hlp);

                    HttpResponseMessage response;
                   
                    DialogResult = DialogResult.OK;
                  
                        response = ulazService.PostResponse(ulaz);
                        Global.UlazIDHLP = response.Content.ReadAsAsync<Ulazi>().Result.UlazID;

                        foreach (var x in Global.ulazstavkeTemp)
                        {
                            UlazStavke hlpunos = new UlazStavke();
                            hlpunos.Cijena = x.Cijena;
                            hlpunos.Kolicina = x.Kolicina;
                            hlpunos.ProizvodID = x.ProizvodID;
                            hlpunos.UlazID = Global.UlazIDHLP;
                            HttpResponseMessage response23;
                            response23 = ulazstavkeService.PostResponse(hlpunos);

                        }
                        Global.ulazstavkeTemp.Clear();
                        Global.UlazIDHLP = 0;
                        MessageBox.Show("Nabavka uspješno dodata");

                    }
    
                this.Close();
                }
            }
        }

        private void brojfakturetxt_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(brojfakturetxt.Text.Trim(), @"^[a-zA-Z0-9]*$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(brojfakturetxt, Global.GetMessage("brojfakture_err"));
            }
            else if (String.IsNullOrEmpty(brojfakturetxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(brojfakturetxt, Global.GetMessage("brojfakture_req"));
            }
            else
                errorProvider.SetError(brojfakturetxt, "");
        }

        private void pdvtxt_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(pdvtxt.Text.Trim(), @"^[0-9]([\.\,][0-9]{1,2})?$$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(pdvtxt, Global.GetMessage("pdv_err"));
            }
            else if (String.IsNullOrEmpty(pdvtxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(pdvtxt, Global.GetMessage("pdv_req"));
            }
            else
                errorProvider.SetError(pdvtxt, "");
        }

        private void skladistecmb_Validating(object sender, CancelEventArgs e)
        {
            if (skladistecmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(skladistecmb, Global.GetMessage("skladiste_req"));
            }
            else
            {
                errorProvider.SetError(skladistecmb, "");
            }
        }

        private void dobavljaccmb_Validating(object sender, CancelEventArgs e)
        {
            if (dobavljaccmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(dobavljaccmb, Global.GetMessage("dobavljac_req"));
            }
            else
            {
                errorProvider.SetError(dobavljaccmb, "");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (datagridtemp.SelectedRows.Count > 0)
            {
                int ulazstavkaID = Convert.ToInt32(datagridtemp.SelectedRows[0].Cells[1].Value);
                esp_UlazStavkeByUlazID_Prikazi_Result hlp = new esp_UlazStavkeByUlazID_Prikazi_Result();
                foreach (var x in Global.ulazstavkeTemp)
                {
                    if (x.ProizvodID == ulazstavkaID)
                    {
                        hlp = x;
                      
                    }
                }
                Global.ulazstavkeTemp.Remove(hlp);
                MessageBox.Show("Uspješno ste izbrisali selektovanu stavku");
                BindGrid();


            }
        }

        private void datagridtemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridtemp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
