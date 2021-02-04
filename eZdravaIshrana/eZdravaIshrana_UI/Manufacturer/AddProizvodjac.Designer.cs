namespace eZdravaIshrana_UI.Manufacturer
{
    partial class AddProizvodjac
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
            this.telefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
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
            this.imetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prezimetxt = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ziroTxt = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(97, 147);
            this.telefonTxt.Mask = "(999) 000-000";
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(175, 21);
            this.telefonTxt.TabIndex = 40;
            this.telefonTxt.Validating += new System.ComponentModel.CancelEventHandler(this.telefonTxt_Validating);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.dodajBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.dodajBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajBtn.Location = new System.Drawing.Point(570, 256);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(98, 61);
            this.dodajBtn.TabIndex = 39;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Napomena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Žiro račun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ime";
            // 
            // faxTxt
            // 
            this.faxTxt.Location = new System.Drawing.Point(429, 23);
            this.faxTxt.Name = "faxTxt";
            this.faxTxt.Size = new System.Drawing.Size(200, 21);
            this.faxTxt.TabIndex = 26;
            this.faxTxt.Validating += new System.ComponentModel.CancelEventHandler(this.faxTxt_Validating);
            // 
            // napomenaTxt
            // 
            this.napomenaTxt.Location = new System.Drawing.Point(429, 113);
            this.napomenaTxt.Multiline = true;
            this.napomenaTxt.Name = "napomenaTxt";
            this.napomenaTxt.Size = new System.Drawing.Size(200, 78);
            this.napomenaTxt.TabIndex = 25;
            this.napomenaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.napomenaTxt_Validating);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(97, 186);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(175, 21);
            this.emailTxt.TabIndex = 24;
            this.emailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxt_Validating);
            // 
            // adresaTxt
            // 
            this.adresaTxt.Location = new System.Drawing.Point(97, 109);
            this.adresaTxt.Name = "adresaTxt";
            this.adresaTxt.Size = new System.Drawing.Size(175, 21);
            this.adresaTxt.TabIndex = 23;
            this.adresaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresaTxt_Validating);
            // 
            // imetxt
            // 
            this.imetxt.Location = new System.Drawing.Point(97, 18);
            this.imetxt.Name = "imetxt";
            this.imetxt.Size = new System.Drawing.Size(175, 21);
            this.imetxt.TabIndex = 22;
            this.imetxt.Validating += new System.ComponentModel.CancelEventHandler(this.imetxt_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Prezime";
            // 
            // prezimetxt
            // 
            this.prezimetxt.Location = new System.Drawing.Point(97, 61);
            this.prezimetxt.Name = "prezimetxt";
            this.prezimetxt.Size = new System.Drawing.Size(175, 21);
            this.prezimetxt.TabIndex = 41;
            this.prezimetxt.Validating += new System.ComponentModel.CancelEventHandler(this.prezimetxt_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ziroTxt
            // 
            this.ziroTxt.Location = new System.Drawing.Point(429, 69);
            this.ziroTxt.Mask = "000000000000000000";
            this.ziroTxt.Name = "ziroTxt";
            this.ziroTxt.Size = new System.Drawing.Size(200, 21);
            this.ziroTxt.TabIndex = 43;
            this.ziroTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ziroTxt_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(444, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 61);
            this.button1.TabIndex = 72;
            this.button1.Text = "Zatvori";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProizvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ziroTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prezimetxt);
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
            this.Controls.Add(this.imetxt);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProizvodjac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija proizvođača";
            this.Load += new System.EventHandler(this.AddProizvodjac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox imetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prezimetxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox ziroTxt;
        private System.Windows.Forms.Button button1;
    }
}