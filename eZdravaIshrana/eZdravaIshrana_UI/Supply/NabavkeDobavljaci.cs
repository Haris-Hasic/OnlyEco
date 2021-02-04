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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Supply
{
    public partial class NabavkeDobavljaci : Form
    {

        private WebApiHelper ulaziServices = new WebApiHelper("http://localhost:2618/", "api/Ulazi");
        private WebApiHelper dobavljacService = new WebApiHelper("http://localhost:2618/", "api/Dobavljaci");
        private WebApiHelper ulazistavkeService = new WebApiHelper("http://localhost:2618/", "api/UlazStavke");
        int idhlp;
        int ulazhlpID;
        public NabavkeDobavljaci(int id)
        {
            idhlp = id;
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage responseDobavljac = dobavljacService.GetResponseID(id);
            Dobavljaci dobavljac = responseDobavljac.Content.ReadAsAsync<Dobavljaci>().Result;
            HttpResponseMessage response = ulaziServices.GetActionResponseID("UlaziDobaljaca",id);
            List<esp_Ulazi_Dobavljaca_Result> ulazi = response.Content.ReadAsAsync<List<esp_Ulazi_Dobavljaca_Result>>().Result;
        //    dobavljacID = id;
            if (response.IsSuccessStatusCode)
            {
                ulaziGrid.DataSource = ulazi;
                Nazivlbl.Text = dobavljac.Naziv;
                adresalbl.Text = dobavljac.Adresa;
                telefonlbl.Text = dobavljac.Telefon;
                emaillbl.Text = dobavljac.Email;
                if (dobavljac.Status == true)
                    statuslbl.Text = "aktivan";
                else
                    statuslbl.Text = "nije aktivan";
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
           
        }

        private void BindGrid2()
        {
            HttpResponseMessage response = ulazistavkeService.GetActionResponseID("UlazStavkeByUlazID", ulazhlpID);
            List<esp_UlaziStavke_byUlazID_Result> ulazStavke = response.Content.ReadAsAsync<List<esp_UlaziStavke_byUlazID_Result>>().Result;
            if (response.IsSuccessStatusCode)
            {
                UlaziStavkeGrid.DataSource = ulazStavke;

            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void NabavkeDobavljaci_Load(object sender, EventArgs e)
        {
            ulaziGrid.AutoGenerateColumns = false;
            UlaziStavkeGrid.AutoGenerateColumns = false;
        }

      

        private void ulaziGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ulazID = Convert.ToInt32(ulaziGrid.SelectedRows[0].Cells[0].Value);
            ulazhlpID = ulazID;
            HttpResponseMessage response = ulazistavkeService.GetActionResponseID("UlazStavkeByUlazID", ulazID);
            List<esp_UlaziStavke_byUlazID_Result> ulazStavke = response.Content.ReadAsAsync<List<esp_UlaziStavke_byUlazID_Result>>().Result;
            if (response.IsSuccessStatusCode)
            {
                UlaziStavkeGrid.DataSource = ulazStavke;

            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }

        private void editUlazStavkeBtn_Click(object sender, EventArgs e)
        {
            if (UlaziStavkeGrid.RowCount!=0)
            {
                int ulazStavkeID = Convert.ToInt32(UlaziStavkeGrid.SelectedRows[0].Cells[0].Value);
                Supply.NabavkaStavkeEdit form = new Supply.NabavkaStavkeEdit(ulazStavkeID);
                if (form.ShowDialog() == DialogResult.OK)
                    BindGrid2();
            }
        }

     
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            HttpResponseMessage response = ulaziServices.GetActionResponseID("UlaziDobaljaca", idhlp);
            List<esp_Ulazi_Dobavljaca_Result> ulazi = response.Content.ReadAsAsync<List<esp_Ulazi_Dobavljaca_Result>>().Result;

            ulaziGrid.DataSource = ulazi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ulaziGrid.RowCount != 0)
            {
                int ulaz = Convert.ToInt32(ulaziGrid.SelectedRows[0].Cells[0].Value);
                Supply.NabavkaEdit form = new Supply.NabavkaEdit(ulaz);
                if (form.ShowDialog() == DialogResult.OK)
                    BindGrid1();
            }
        }

        private void BindGrid1()
        {
            HttpResponseMessage responseDobavljac = dobavljacService.GetResponseID(idhlp);
            Dobavljaci dobavljac = responseDobavljac.Content.ReadAsAsync<Dobavljaci>().Result;
            HttpResponseMessage response = ulaziServices.GetActionResponseID("UlaziDobaljaca", idhlp);
            List<esp_Ulazi_Dobavljaca_Result> ulazi = response.Content.ReadAsAsync<List<esp_Ulazi_Dobavljaca_Result>>().Result;
            //    dobavljacID = id;
            if (response.IsSuccessStatusCode)
            {
                ulaziGrid.DataSource = ulazi;
                Nazivlbl.Text = dobavljac.Naziv;
                adresalbl.Text = dobavljac.Adresa;
                telefonlbl.Text = dobavljac.Telefon;
                emaillbl.Text = dobavljac.Email;
                if (dobavljac.Status == true)
                    statuslbl.Text = "aktivan";
                else
                    statuslbl.Text = "nije aktivan";
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
            }
        }
    }
}
