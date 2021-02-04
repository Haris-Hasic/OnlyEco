namespace eZdravaIshrana_UI.Deliverer
{
    partial class AddDostavljac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ziroTxt = new System.Windows.Forms.MaskedTextBox();
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faxTxt = new System.Windows.Forms.TextBox();
            this.napomenaTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.adresaTxt = new System.Windows.Forms.TextBox();
            this.nazivtxt = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ziroTxt
            // 
            this.ziroTxt.Location = new System.Drawing.Point(516, 242);
            this.ziroTxt.Mask = "000000000000000000";
            this.ziroTxt.Name = "ziroTxt";
            this.ziroTxt.Size = new System.Drawing.Size(228, 21);
            this.ziroTxt.TabIndex = 60;
            this.ziroTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ziroTxt_Validating_1);
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(128, 144);
            this.telefonTxt.Mask = "(999) 000-000";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(228, 21);
            this.telefonTxt.TabIndex = 57;
            this.telefonTxt.Validating += new System.ComponentModel.CancelEventHandler(this.telefonTxt_Validating_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Napomena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Žiro račun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ime i prezime";
            // 
            // faxTxt
            // 
            this.faxTxt.Location = new System.Drawing.Point(516, 196);
            this.faxTxt.Name = "faxTxt";
            this.faxTxt.Size = new System.Drawing.Size(228, 21);
            this.faxTxt.TabIndex = 48;
            this.faxTxt.Validating += new System.ComponentModel.CancelEventHandler(this.faxTxt_Validating_1);
            // 
            // napomenaTxt
            // 
            this.napomenaTxt.Location = new System.Drawing.Point(128, 353);
            this.napomenaTxt.Multiline = true;
            this.napomenaTxt.Name = "napomenaTxt";
            this.napomenaTxt.Size = new System.Drawing.Size(228, 119);
            this.napomenaTxt.TabIndex = 47;
            this.napomenaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.napomenaTxt_Validating_1);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(128, 200);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(228, 21);
            this.emailTxt.TabIndex = 46;
            this.emailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxt_Validating_1);
            // 
            // adresaTxt
            // 
            this.adresaTxt.Location = new System.Drawing.Point(128, 92);
            this.adresaTxt.Name = "adresaTxt";
            this.adresaTxt.Size = new System.Drawing.Size(228, 21);
            this.adresaTxt.TabIndex = 45;
            this.adresaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresaTxt_Validating_1);
            // 
            // nazivtxt
            // 
            this.nazivtxt.Location = new System.Drawing.Point(128, 38);
            this.nazivtxt.Name = "nazivtxt";
            this.nazivtxt.Size = new System.Drawing.Size(228, 21);
            this.nazivtxt.TabIndex = 44;
            this.nazivtxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivtxt_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Kontakt osoba";
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Location = new System.Drawing.Point(128, 260);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(228, 21);
            this.txtKontaktOsoba.TabIndex = 62;
            this.txtKontaktOsoba.Validating += new System.ComponentModel.CancelEventHandler(this.txtKontaktOsoba_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Potvrda Lozinke";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "Lozinka";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(371, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Korisničko ime";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(516, 96);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(228, 21);
            this.txtLozinka.TabIndex = 64;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinka_Validating);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(516, 42);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(228, 21);
            this.txtKorisnickoIme.TabIndex = 63;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // txtPotvrdaLozinke
            // 
            this.txtPotvrdaLozinke.Location = new System.Drawing.Point(516, 143);
            this.txtPotvrdaLozinke.Name = "txtPotvrdaLozinke";
            this.txtPotvrdaLozinke.PasswordChar = '*';
            this.txtPotvrdaLozinke.Size = new System.Drawing.Size(228, 21);
            this.txtPotvrdaLozinke.TabIndex = 68;
            this.txtPotvrdaLozinke.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotvrdaLozinke_Validating);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(128, 310);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(228, 21);
            this.txtWeb.TabIndex = 70;
            this.txtWeb.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeb_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 69;
            this.label12.Text = "Web";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(516, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 71;
            this.button1.Text = "Zatvori";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.dodajBtn.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dodajBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.dodajBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajBtn.Location = new System.Drawing.Point(645, 341);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(99, 53);
            this.dodajBtn.TabIndex = 56;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // AddDostavljac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(773, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPotvrdaLozinke);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtKontaktOsoba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ziroTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faxTxt);
            this.Controls.Add(this.napomenaTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.adresaTxt);
            this.Controls.Add(this.nazivtxt);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDostavljac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dostavljača";
            this.Load += new System.EventHandler(this.AddDostavljac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ziroTxt;
        private System.Windows.Forms.MaskedTextBox telefonTxt;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faxTxt;
        private System.Windows.Forms.TextBox napomenaTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox adresaTxt;
        private System.Windows.Forms.TextBox nazivtxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtPotvrdaLozinke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}