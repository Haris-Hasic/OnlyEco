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

namespace eZdravaIshrana_UI
{
    public partial class MainForm : Form
    {
        WebApiHelper narudzbeServices = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        public MainForm()
        {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pretragaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.IndexForm pretragaF = new Users.IndexForm();
            pretragaF.MdiParent = this;
            pretragaF.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.AddForm noviF = new Users.AddForm();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.IndexForm noviF = new Products.IndexForm();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaDobavljacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supply.IndexDobavljac noviF = new Supply.IndexDobavljac();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void proizvodjaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void proizvodjaciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manufacturer.PretragaProizvodjac noviF = new Manufacturer.PretragaProizvodjac();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pproizvodjacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manufacturer.IndexProizvodjac noviF = new Manufacturer.IndexProizvodjac();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deliverer.IndexDostavljac noviF = new Deliverer.IndexDostavljac();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaSkladistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage.IndexSkladiste noviF = new Storage.IndexSkladiste();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.IndexKupci noviF = new Users.IndexKupci();
            noviF.MdiParent = this;
            noviF.Show();

        }

        private void novaNabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supply.NabavkaAdd noviF = new Supply.NabavkaAdd();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaNabavkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supply.Nabavka noviF = new Supply.Nabavka();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaKupacaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Users.IndexKupci noviF = new Users.IndexKupci();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void pretragaNarudzbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders.IndexNarudzbe noviF = new Orders.IndexNarudzbe();
            noviF.MdiParent = this;
            noviF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = narudzbeServices.GetActionResponseNoPar("GetBrojAktivnihNarudzbi");

            if (response.IsSuccessStatusCode)
            {
                int brojNarudzbi = response.Content.ReadAsAsync<int>().Result;
             
                if (brojNarudzbi > 0)
                {
                    notifyIcon.ShowBalloonTip(5000, "Nove narudžbe", "Broj narudžbi: " + brojNarudzbi, ToolTipIcon.Info);
                }
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Orders.ActiveForm aktivneNarudzbeForm = new Orders.ActiveForm();
            aktivneNarudzbeForm.MdiParent = this;
            aktivneNarudzbeForm.Show();
        }

        private void aktivneNarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders.ActiveForm aktivneNarudzbeForm = new Orders.ActiveForm();
            aktivneNarudzbeForm.MdiParent = this;
            aktivneNarudzbeForm.Show();
        }

        private void narudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
