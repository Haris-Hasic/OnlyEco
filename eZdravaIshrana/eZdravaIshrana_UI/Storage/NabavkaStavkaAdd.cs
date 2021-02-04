using eZdravaIshrana_API.Models;
using eZdravaIshrana_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZdravaIshrana_UI.Storage
{
    public partial class NabavkaStavkaAdd : Form
    {
        private WebApiHelper proizvodServices = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        private WebApiHelper ulazstavkeServices = new WebApiHelper("http://localhost:2618/", "api/UlazStavke");
        private WebApiHelper sortaServices = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        private WebApiHelper proizvodjacServices = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        private WebApiHelper vrstaServices = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        UlazStavke ulazstavke;
        esp_UlazStavkeByUlazID_Prikazi_Result temp;
        Proizvodi proizvod;
        int proizvodID;

        UlazStavke ulazstavkeedit;


        public NabavkaStavkaAdd(int proizvodID,string vrsta, string sorta, string ime, string prezime)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            
            HttpResponseMessage response = proizvodServices.GetResponseID(proizvodID);
            proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
            this.proizvodID = proizvodID;
            
            HttpResponseMessage responsetest = ulazstavkeServices.GetResponse2par("Provjera", proizvodID, Global.UlazIDHLP);

            ulazstavkeedit = responsetest.Content.ReadAsAsync<UlazStavke>().Result;
            if (ulazstavkeedit!=null)
            {
                LoadDate(vrsta, sorta, ime, prezime);
              
                kolicinatxt.Text = Convert.ToString(ulazstavkeedit.Kolicina);
                cijenatxt.Text = ulazstavkeedit.Cijena.ToString();
            }
            else
            {
                if (response.IsSuccessStatusCode)
                {
                    LoadDate(vrsta, sorta, ime, prezime);
                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
            }
        }
        public NabavkaStavkaAdd(int proizvodID,int globalUlazID,string vrsta,string sorta,string proizvodjac)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = proizvodServices.GetResponseID(proizvodID);
            proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
            this.proizvodID = proizvodID;

            HttpResponseMessage responsetest = ulazstavkeServices.GetResponse2par("Provjera", proizvodID, Global.UlazIDHLP);
       
            ulazstavkeedit = responsetest.Content.ReadAsAsync<UlazStavke>().Result;
            if (ulazstavkeedit != null)
            {
                LoadDate(vrsta, sorta, proizvodjac, "");

                kolicinatxt.Text = Convert.ToString(ulazstavkeedit.Kolicina);
                cijenatxt.Text = ulazstavkeedit.Cijena.ToString();
            }
            else
            {
                if (response.IsSuccessStatusCode)
                {
                    LoadDate(vrsta, sorta, proizvodjac, "");
                }
                else
                {
                    MessageBox.Show("Error code : " + response.StatusCode + Environment.NewLine + "Message " + response.ReasonPhrase);
                }
            }
        }


        public NabavkaStavkaAdd()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
         
        }

        private void LoadDate(string vrsta, string sorta, string ime, string prezime)
        {
            proizvodlbl.Text = proizvod.Naziv;
            vrstalbl.Text = vrsta;
            sortalbl.Text = sorta;
            proizvodjaclbl.Text = ime + " " + prezime;
            if (proizvod.SlikaThumb != null)
            {
                var ms = new MemoryStream(proizvod.SlikaThumb);

                Image thumbImage = Image.FromStream(ms);
                pictureBox.Image = thumbImage;
            }
        }

        private void NabavkaStavkaAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (ulazstavke == null)
                    ulazstavke = new UlazStavke();

                HttpResponseMessage response;

                temp = new esp_UlazStavkeByUlazID_Prikazi_Result();
                if (ulazstavkeedit==null) {
                    ulazstavke.Kolicina = Convert.ToInt32(kolicinatxt.Text);
                    string hlp = cijenatxt.Text.Trim();
                    hlp = hlp.Replace(',', '.');
                    ulazstavke.Cijena = Convert.ToDecimal(hlp);

                    ulazstavke.ProizvodID = proizvod.ProizvodID;
                    ulazstavke.UlazID = Global.UlazIDHLP;

                    temp.Cijena = ulazstavke.Cijena;
                    temp.Kolicina = ulazstavke.Kolicina;
                    temp.ProizvodID = ulazstavke.ProizvodID;
                    temp.Sifra = proizvod.Sifra;
                    temp.Slika = proizvod.SlikaThumb;
                    temp.Proizvodjac = proizvodjaclbl.Text;
                    temp.Sorta = sortalbl.Text;
                    temp.Vrsta = vrstalbl.Text;
                    temp.Proizvod = proizvod.Naziv;
                    temp.UlazStavkaID = ulazstavke.UlazID;
                    Global.ulazstavkeTemp.Add(temp);
         
                    MessageBox.Show("Uspjesno dodato ! ");

                }
                else
                {
                    ulazstavkeedit.Kolicina = Convert.ToInt32(kolicinatxt.Text);
                    string hlp = cijenatxt.Text.Trim();
                    hlp = hlp.Replace(',', '.');
                    ulazstavkeedit.Cijena = Convert.ToDecimal(hlp);
                    temp.Cijena = ulazstavkeedit.Cijena;
                    temp.Kolicina = ulazstavkeedit.Kolicina;
                    temp.ProizvodID = proizvod.ProizvodID;
                    temp.Sifra = proizvod.Sifra;
                    temp.Slika = proizvod.SlikaThumb;
                    temp.Proizvodjac = proizvodjaclbl.Text;
                    temp.Sorta = sortalbl.Text;
                    temp.Vrsta = vrstalbl.Text;
                    temp.Proizvod = proizvod.Naziv;
                    temp.UlazStavkaID = Global.UlazIDHLP;
                    foreach (var x in Global.ulazstavkeTemp)
                    {
                        if (x.ProizvodID == temp.ProizvodID)
                        {
                            x.Kolicina = temp.Kolicina;
                            x.Cijena = temp.Cijena;
                        }
                    }
                    MessageBox.Show("Uspjesno promjenjana stavka u nabavci ! ");
                  ///  response = ulazstavkeServices.PutResponse(ulazstavkeedit.UlazStavkaID, ulazstavkeedit);
                }
              
           
                DialogResult = DialogResult.OK;
                ClearInput();
                this.Close();

            }
        }

        private void ClearInput()
        {
            
        }

        private void kolicinatxt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(kolicinatxt.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(kolicinatxt, Global.GetMessage("kolicina_req"));
            }
            else
            {
                errorProvider.SetError(kolicinatxt, "");
            }
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
