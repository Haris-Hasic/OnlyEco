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
    public partial class StartMain : Form
    {
        WebApiHelper narudzbeServices = new WebApiHelper("http://localhost:2618/", "api/Narudzbe");
        public StartMain()
        {
            InitializeComponent();
            sakriPanele();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void sakriPanele()
        {
            panelOsoblje.Visible = false;
            ProizvodiPanel.Visible = false;
            NNpanel.Visible = false;
        }

        private void sakriSubmenu()
        {
            if(panelOsoblje.Visible==true)
              panelOsoblje.Visible = false;

            if (ProizvodiPanel.Visible == true)
                ProizvodiPanel.Visible = false;

            if (NNpanel.Visible == true)
                NNpanel.Visible = false;

        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false) {
                sakriSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;


        }

        private void btnosoblje_Click(object sender, EventArgs e)
        {
            //adminstacija sakri prva 2 buttona
            ShowSubMenu(panelOsoblje);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users.IndexForm pretragaF = new Users.IndexForm();
         
            //pretragaF.Show();
      
            openChildForm(pretragaF);

            sakriSubmenu();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Users.AddForm noviF = new Users.AddForm();
        //    openChildForm(noviF);
        //    sakriSubmenu();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            // otvoriti formu

            Users.IndexKupci noviF = new Users.IndexKupci();
            openChildForm(noviF);

            sakriSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // otvoriti formu
            Deliverer.IndexDostavljac noviF = new Deliverer.IndexDostavljac();
            openChildForm(noviF);

            sakriSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Supply.IndexDobavljac noviF = new Supply.IndexDobavljac();
            openChildForm(noviF);
            sakriSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manufacturer.PretragaProizvodjac noviF = new Manufacturer.PretragaProizvodjac();
            openChildForm(noviF);
            sakriSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // otvoriti formu
            Manufacturer.IndexProizvodjac noviF = new Manufacturer.IndexProizvodjac();
            
            openChildForm(noviF);
            sakriSubmenu();
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
         
            ShowSubMenu(ProizvodiPanel);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Products.IndexForm noviF = new Products.IndexForm();
         

            openChildForm(noviF);
            sakriSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // otvoriti formu
            Storage.IndexSkladiste noviF = new Storage.IndexSkladiste();

    

            openChildForm(noviF);
            sakriSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            ShowSubMenu(NNpanel);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Orders.ActiveForm aktivneNarudzbeForm = new Orders.ActiveForm();
 

            openChildForm(aktivneNarudzbeForm);
            sakriSubmenu();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // otvoriti formu
            Supply.NabavkaAdd noviF = new Supply.NabavkaAdd();


            openChildForm(noviF);
            sakriSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // otvoriti formu

            Supply.Nabavka noviF = new Supply.Nabavka();
            
             openChildForm(noviF);
            sakriSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Orders.IndexNarudzbe noviF = new Orders.IndexNarudzbe();

            openChildForm(noviF);

            //openChildForm(noviF);
            sakriSubmenu();
        }

        private  void StartMain_Load(object sender, EventArgs e)
        {
            bool adminhlp = false;
            lblprijavljeni.Text = Global.prijavljeniKorisnik.Ime + " " + Global.prijavljeniKorisnik.Prezime;
            HttpResponseMessage response = narudzbeServices.GetActionResponseNoPar("GetBrojAktivnihNarudzbi");
            foreach (var x in Global.prijavljeniKorisnik.KorisniciUloge)
            {
                if (x.UlogaID == 1)
                    adminhlp = true;
            }
            if (adminhlp == false)
            {
                button2.Visible = false;
                button4.Visible = false;
                panelOsoblje.Height = 170;

            }
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


            openChildForm(aktivneNarudzbeForm);
            sakriSubmenu();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Products.AmbalazaIndex aktivneNarudzbeForm = new Products.AmbalazaIndex();

            openChildForm(aktivneNarudzbeForm);
            sakriSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders.OtkazaneNarudzbeKreditna aktivneNarudzbeForm = new Orders.OtkazaneNarudzbeKreditna();

            openChildForm(aktivneNarudzbeForm);
            sakriSubmenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Global.logout = true;
       
            LoginForm a = new LoginForm();
            a.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblprijavljeni_Click(object sender, EventArgs e)
        {

        }
    }
}
