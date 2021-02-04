namespace eZdravaIshrana_UI.Supply
{
    partial class NabavkeDobavljaci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ulaziGrid = new System.Windows.Forms.DataGridView();
            this.UlazID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UlaziStavkeGrid = new System.Windows.Forms.DataGridView();
            this.UlazStavkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Nazivlbl = new System.Windows.Forms.Label();
            this.adresalbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editUlazStavkeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ulaziGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaziStavkeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nabavke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stavke nabavke";
            // 
            // ulaziGrid
            // 
            this.ulaziGrid.AllowUserToAddRows = false;
            this.ulaziGrid.AllowUserToDeleteRows = false;
            this.ulaziGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ulaziGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ulaziGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulaziGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlazID,
            this.KorisnikID,
            this.BrojFakture,
            this.Datum,
            this.IznosRacuna,
            this.PDV,
            this.Naziv,
            this.Adresa});
            this.ulaziGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ulaziGrid.Location = new System.Drawing.Point(15, 109);
            this.ulaziGrid.Name = "ulaziGrid";
            this.ulaziGrid.ReadOnly = true;
            this.ulaziGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ulaziGrid.Size = new System.Drawing.Size(674, 150);
            this.ulaziGrid.TabIndex = 2;
            this.ulaziGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ulaziGrid_CellClick);
            // 
            // UlazID
            // 
            this.UlazID.DataPropertyName = "UlazID";
            this.UlazID.HeaderText = "UlazID";
            this.UlazID.Name = "UlazID";
            this.UlazID.ReadOnly = true;
            this.UlazID.Visible = false;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // BrojFakture
            // 
            this.BrojFakture.DataPropertyName = "BrojFakture";
            this.BrojFakture.HeaderText = "Broj fakture";
            this.BrojFakture.Name = "BrojFakture";
            this.BrojFakture.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // IznosRacuna
            // 
            this.IznosRacuna.DataPropertyName = "IznosRacuna";
            this.IznosRacuna.HeaderText = "Iznos racuna";
            this.IznosRacuna.Name = "IznosRacuna";
            this.IznosRacuna.ReadOnly = true;
            // 
            // PDV
            // 
            this.PDV.DataPropertyName = "PDV";
            this.PDV.HeaderText = "PDV";
            this.PDV.Name = "PDV";
            this.PDV.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // UlaziStavkeGrid
            // 
            this.UlaziStavkeGrid.AllowUserToAddRows = false;
            this.UlaziStavkeGrid.AllowUserToDeleteRows = false;
            this.UlaziStavkeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UlaziStavkeGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.UlaziStavkeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UlaziStavkeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlazStavkaID,
            this.Naziv2,
            this.Kolicina,
            this.Cijena,
            this.Ime,
            this.Prezime});
            this.UlaziStavkeGrid.Location = new System.Drawing.Point(15, 325);
            this.UlaziStavkeGrid.Name = "UlaziStavkeGrid";
            this.UlaziStavkeGrid.ReadOnly = true;
            this.UlaziStavkeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UlaziStavkeGrid.Size = new System.Drawing.Size(674, 162);
            this.UlaziStavkeGrid.TabIndex = 3;
            // 
            // UlazStavkaID
            // 
            this.UlazStavkaID.DataPropertyName = "UlazStavkaID";
            this.UlazStavkaID.HeaderText = "UlazStavkaID";
            this.UlazStavkaID.Name = "UlazStavkaID";
            this.UlazStavkaID.ReadOnly = true;
            this.UlazStavkaID.Visible = false;
            // 
            // Naziv2
            // 
            this.Naziv2.DataPropertyName = "Naziv2";
            this.Naziv2.HeaderText = "Naziv";
            this.Naziv2.Name = "Naziv2";
            this.Naziv2.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime dobavljaca";
            // 
            // Nazivlbl
            // 
            this.Nazivlbl.AutoSize = true;
            this.Nazivlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazivlbl.Location = new System.Drawing.Point(107, 34);
            this.Nazivlbl.Name = "Nazivlbl";
            this.Nazivlbl.Size = new System.Drawing.Size(0, 16);
            this.Nazivlbl.TabIndex = 5;
            // 
            // adresalbl
            // 
            this.adresalbl.AutoSize = true;
            this.adresalbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresalbl.Location = new System.Drawing.Point(228, 34);
            this.adresalbl.Name = "adresalbl";
            this.adresalbl.Size = new System.Drawing.Size(0, 16);
            this.adresalbl.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adresa";
            // 
            // telefonlbl
            // 
            this.telefonlbl.AutoSize = true;
            this.telefonlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonlbl.Location = new System.Drawing.Point(298, 34);
            this.telefonlbl.Name = "telefonlbl";
            this.telefonlbl.Size = new System.Drawing.Size(0, 16);
            this.telefonlbl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon";
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(485, 34);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 16);
            this.emaillbl.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email";
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(382, 34);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 16);
            this.statuslbl.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status";
            // 
            // editUlazStavkeBtn
            // 
            this.editUlazStavkeBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.editUlazStavkeBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUlazStavkeBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_edit_24;
            this.editUlazStavkeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUlazStavkeBtn.Location = new System.Drawing.Point(550, 493);
            this.editUlazStavkeBtn.Name = "editUlazStavkeBtn";
            this.editUlazStavkeBtn.Size = new System.Drawing.Size(139, 39);
            this.editUlazStavkeBtn.TabIndex = 14;
            this.editUlazStavkeBtn.Text = "Promjeni stavku";
            this.editUlazStavkeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editUlazStavkeBtn.UseVisualStyleBackColor = false;
            this.editUlazStavkeBtn.Click += new System.EventHandler(this.editUlazStavkeBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_change_user_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(584, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_edit_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(584, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Promjeni nabavku";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NabavkeDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(712, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editUlazStavkeBtn);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefonlbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresalbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nazivlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UlaziStavkeGrid);
            this.Controls.Add(this.ulaziGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NabavkeDobavljaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija nabavke";
            this.Load += new System.EventHandler(this.NabavkeDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulaziGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlaziStavkeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ulaziGrid;
        private System.Windows.Forms.DataGridView UlaziStavkeGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nazivlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlazID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.Label adresalbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label telefonlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlazStavkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.Button editUlazStavkeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}