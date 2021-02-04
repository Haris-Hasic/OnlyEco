using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eZdravaIshrana_API.Models;

using eZdravaIshrana_UI.Util;
using System.Net.Http;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace eZdravaIshrana_UI.Products
{
    public partial class AddForm : Form
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:2618/", "api/VrsteProizvoda");
        WebApiHelper proizvodjacService = new WebApiHelper("http://localhost:2618/", "api/Proizvodjac");
        WebApiHelper sortaService = new WebApiHelper("http://localhost:2618/", "api/SortaProizvoda");
        WebApiHelper proizvodService = new WebApiHelper("http://localhost:2618/", "api/Proizvodi");
        private Proizvodi proizvod { get; set; }
        int proizvodIDhlp = 0;
        public AddForm()
        {
            InitializeComponent();
            BindVrsteProizvoda();

            BindProizvodjaci();
            this.AutoValidate = AutoValidate.Disable;

        }
        public AddForm(int a)
        {
            InitializeComponent();
            BindVrsteProizvoda();

            BindProizvodjaci();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = proizvodService.GetResponseID(a);
            proizvodIDhlp = a;
            if (response.IsSuccessStatusCode)
            {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
                BindSortaProizvodaEdit(proizvod.VrstaID);
                LoadData();
                Cursor.Current = Cursors.Default;
            }

        }

        private void LoadData()
        {
            nazivInput.Text = proizvod.Naziv;
            sifraInput.Text = proizvod.Sifra;
            cijenaInput.Text = proizvod.Cijena.ToString();
            proizvodjacCmb.SelectedValue = proizvod.ProizvodjacID;
            vrstaCmb.SelectedValue = proizvod.VrstaID;
            SortaCmb.SelectedValue = proizvod.SortaID;
            if (proizvod.SlikaThumb != null)
            {
                var ms = new MemoryStream(proizvod.SlikaThumb);

                Image thumbImage = Image.FromStream(ms);
                pictureBox.Image = thumbImage;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void BindSortaProizvoda()
        {
            HttpResponseMessage respone = sortaService.GetResponseID(vrstaCmb.SelectedValue);
            if (respone.IsSuccessStatusCode)
            {
                List<SortaProizvoda> sorta = respone.Content.ReadAsAsync<List<SortaProizvoda>>().Result;
                sorta.Insert(0, new SortaProizvoda());
                SortaCmb.DataSource = sorta;
                SortaCmb.DisplayMember = "Naziv";
                SortaCmb.ValueMember = "SortaID";
            }
        }
        private void BindSortaProizvodaEdit(int vrstaID)
        {
            HttpResponseMessage respone = sortaService.GetResponseID(vrstaID);
            if (respone.IsSuccessStatusCode)
            {
                List<SortaProizvoda> sorta = respone.Content.ReadAsAsync<List<SortaProizvoda>>().Result;
                sorta.Insert(0, new SortaProizvoda());
                SortaCmb.DataSource = sorta;
                SortaCmb.DisplayMember = "Naziv";
                SortaCmb.ValueMember = "SortaID";
            }
        }

        private void BindProizvodjaci()
        {
            HttpResponseMessage respone = proizvodjacService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<Proizvodjac> proizvodjac = respone.Content.ReadAsAsync<List<Proizvodjac>>().Result;
                proizvodjac.Insert(0, new Proizvodjac());
                proizvodjacCmb.DataSource = proizvodjac;
                proizvodjacCmb.DisplayMember = "Ime";
                proizvodjacCmb.ValueMember = "ProizvodjacID";
                // proizvodjacCmb.SelectionLength = 0;
            }
        }

        private void BindVrsteProizvoda()
        {
            HttpResponseMessage respone = vrsteService.GetResponse();
            if (respone.IsSuccessStatusCode)
            {
                List<VrsteProizvoda> vrste = respone.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
                vrste.Insert(0, new VrsteProizvoda());
                vrstaCmb.DataSource = vrste;
                vrstaCmb.DisplayMember = "Naziv";
                vrstaCmb.ValueMember = "VrstaID";

            }
        }



      
        private void vrstaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindSortaProizvoda();
        }
        private void slikaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //sve staviti u try catch block da se provjeri da li je slika jpeg pa izbaciti error opet
                if (proizvod == null)
                    proizvod = new Proizvodi();
                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                Image image;
                if (slikaInput.Text != "openFileDialog1")
                {
                    image = Image.FromFile(slikaInput.Text);
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    proizvod.Slika = ms.ToArray();

                    int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                    int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                    int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                    int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);
                    if (image.Height>120 && image.Width > 120)
                    {
                        if (image.Width > resizedImgWidth)
                        {
                            Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));


                            Image croppedImage = resizedImage;

                            int croppedXPosition = (resizedImage.Width - croppedImgWidth) / 2;
                            int croppedYPosition = (resizedImage.Height - croppedImgHeight) / 2;
                            if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                            {
                                croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                                ms = new MemoryStream();
                                croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                proizvod.SlikaThumb = ms.ToArray();


                                pictureBox.Image = croppedImage;
                            }
                            else
                            {
                                MessageBox.Show(Global.GetMessage("picture_war") + " " + resizedImgHeight + "x" + resizedImgHeight + ".", Global.GetMessage("warning"),
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                proizvod = null;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Global.GetMessage("picture_size"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        proizvod = null;
                        slikaInput.Text = "";
                    }
                }
                else
                    slikaInput.Text = "";
            }
            catch (Exception)
            {
                proizvod = null;
                pictureBox.Image = null;
                slikaInput.Text = "";
            }
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (proizvod == null)
                    proizvod = new Proizvodi();
                if (vrstaCmb.SelectedIndex != 0)
                    proizvod.VrstaID = Convert.ToInt32(vrstaCmb.SelectedValue);
                proizvod.Sifra = sifraInput.Text;
                proizvod.Naziv = nazivInput.Text;
                proizvod.Status = true;
                if (SortaCmb.SelectedIndex != 0)
                    proizvod.SortaID = Convert.ToInt32(SortaCmb.SelectedValue);
                if (proizvodjacCmb.SelectedIndex != 0)
                    proizvod.ProizvodjacID = Convert.ToInt32(proizvodjacCmb.SelectedValue);
                string hlp = cijenaInput.Text.Trim();
                hlp = hlp.Replace(',', '.');
                proizvod.Cijena = Convert.ToDecimal(hlp);
                DialogResult = DialogResult.OK;
                HttpResponseMessage response;
                if (proizvod.ProizvodID == 0)
                    response = proizvodService.PostResponse(proizvod);
                else
                    response = proizvodService.PutResponse(proizvod.ProizvodID, proizvod);

                if (response.IsSuccessStatusCode)
                {
                    this.Close();
                }
            }

        }
        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Global.GetMessage("pname_req"));
            }
            else if (nazivInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, Global.GetMessage("pname_len"));
            }
            else
            {
                errorProvider.SetError(nazivInput, "");
            }
        }
        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sifraInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(sifraInput, Global.GetMessage("psif_req"));
            }
            else if (sifraInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(sifraInput, Global.GetMessage("psif_len"));
            }
            else
            {
                errorProvider.SetError(sifraInput, "");
            }
        }
        private void cijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(cijenaInput.Text.Trim(), @"^[0-9]([\.\,][0-9]{1,2})?$$") == false)
            {
                e.Cancel = true;
                errorProvider.SetError(cijenaInput, Global.GetMessage("pcijena_err"));
            }
            else if (String.IsNullOrEmpty(cijenaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cijenaInput, Global.GetMessage("pcijena_req"));
            }
            else
                errorProvider.SetError(cijenaInput, "");
        }
        private void slikaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(slikaInput.Text) && proizvodIDhlp == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(slikaInput, Global.GetMessage("psli_req"));
            }
            else
            {
                errorProvider.SetError(slikaInput, "");
            }
        }
        private void proizvodjacCmb_Validating_1(object sender, CancelEventArgs e)
        {
            if (proizvodjacCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(proizvodjacCmb, Global.GetMessage("pproi_req"));
            }
            else
            {
                errorProvider.SetError(proizvodjacCmb, "");
            }
        }

        private void vrstaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (vrstaCmb.SelectedIndex == 0)
            {
                e.Cancel = true;

                errorProvider.SetError(vrstaCmb, Global.GetMessage("pvrs_req"));
            }
            else
            {
                errorProvider.SetError(vrstaCmb, "");
            }
        }

        private void SortaCmb_Validating(object sender, CancelEventArgs e)
        {
            if (SortaCmb.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(SortaCmb, Global.GetMessage("psor_req"));
            }
            else
            {
                errorProvider.SetError(SortaCmb, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new SortaAdd();
            a.ShowDialog();
        }
    }
}

