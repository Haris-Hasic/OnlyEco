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

namespace eZdravaIshrana_UI
{
    public partial class LoginForm : Form
    {
        private WebApiHelper korisniciService = new WebApiHelper("http://localhost:2618/", "api/Korisnici");
        private WebApiHelper korisniciUlogeService = new WebApiHelper("http://localhost:2618/", "api/KorisniciUloge");

        public LoginForm()
        {
            InitializeComponent();
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

        private void privajabtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse(korisnickoimetxt.Text);
            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;
                if (UIHelper.GenerateHash(lozinkatxt.Text, k.LozinkaSalt) == k.LozinkaHash)
                {
                   
                    List<KorisniciUloge> a = new List<KorisniciUloge>();
                    HttpResponseMessage response2 = korisniciUlogeService.GetResponseID(k.KorisnikID);
                    a = response2.Content.ReadAsAsync<List<KorisniciUloge>>().Result;
                    foreach (var x in a)
                    {
                        k.KorisniciUloge.Add(x);
                    }
                    Global.prijavljeniKorisnik = k;
                    if (Global.logout==true)
                    {
                        StartMain abc = new StartMain();
                        abc.ShowDialog();
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show(Global.GetMessage("login_pass_user_error"),Global.GetMessage("Warning"),MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error code : " + response.StatusCode + "message " + response.ReasonPhrase);
            }
        }

        private void odustanibtn_Click(object sender, EventArgs e)
        {
            korisnickoimetxt.Text = "";
            lozinkatxt.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
