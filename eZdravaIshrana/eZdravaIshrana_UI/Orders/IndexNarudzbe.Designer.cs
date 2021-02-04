namespace eZdravaIshrana_UI.Orders
{
    partial class IndexNarudzbe
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
            this.izlazidatagrid = new System.Windows.Forms.DataGridView();
            this.IzlazID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakljucen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izlazstavkedatagrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOD = new System.Windows.Forms.DateTimePicker();
            this.brojracunatxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IzlazStavkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzlazID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.izlazidatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izlazstavkedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // izlazidatagrid
            // 
            this.izlazidatagrid.AllowUserToAddRows = false;
            this.izlazidatagrid.AllowUserToDeleteRows = false;
            this.izlazidatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izlazidatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izlazidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izlazidatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzlazID,
            this.BrojRacuna,
            this.Datum,
            this.Zakljucen,
            this.IznosBezPDV,
            this.IznosSaPDV,
            this.Korisnik,
            this.Skladiste,
            this.Dostavljac});
            this.izlazidatagrid.Location = new System.Drawing.Point(12, 101);
            this.izlazidatagrid.Name = "izlazidatagrid";
            this.izlazidatagrid.ReadOnly = true;
            this.izlazidatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izlazidatagrid.Size = new System.Drawing.Size(897, 181);
            this.izlazidatagrid.TabIndex = 0;
            this.izlazidatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izlazidatagrid_CellDoubleClick);
            // 
            // IzlazID
            // 
            this.IzlazID.DataPropertyName = "IzlazID";
            this.IzlazID.HeaderText = "IzlazID";
            this.IzlazID.Name = "IzlazID";
            this.IzlazID.ReadOnly = true;
            this.IzlazID.Visible = false;
            // 
            // BrojRacuna
            // 
            this.BrojRacuna.DataPropertyName = "BrojRacuna";
            this.BrojRacuna.HeaderText = "Broj racuna";
            this.BrojRacuna.Name = "BrojRacuna";
            this.BrojRacuna.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Zakljucen
            // 
            this.Zakljucen.DataPropertyName = "Zakljucen";
            this.Zakljucen.HeaderText = "Zakljucen";
            this.Zakljucen.Name = "Zakljucen";
            this.Zakljucen.ReadOnly = true;
            // 
            // IznosBezPDV
            // 
            this.IznosBezPDV.DataPropertyName = "IznosBezPDV";
            this.IznosBezPDV.HeaderText = "Iznos bez PDV";
            this.IznosBezPDV.Name = "IznosBezPDV";
            this.IznosBezPDV.ReadOnly = true;
            // 
            // IznosSaPDV
            // 
            this.IznosSaPDV.DataPropertyName = "IznosSaPDV";
            this.IznosSaPDV.HeaderText = "Iznos sa PDV";
            this.IznosSaPDV.Name = "IznosSaPDV";
            this.IznosSaPDV.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Skladiste
            // 
            this.Skladiste.DataPropertyName = "Skladiste";
            this.Skladiste.HeaderText = "Skladiste";
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            // 
            // Dostavljac
            // 
            this.Dostavljac.DataPropertyName = "Dostavljac";
            this.Dostavljac.HeaderText = "Dostavljac";
            this.Dostavljac.Name = "Dostavljac";
            this.Dostavljac.ReadOnly = true;
            // 
            // izlazstavkedatagrid
            // 
            this.izlazstavkedatagrid.AllowUserToAddRows = false;
            this.izlazstavkedatagrid.AllowUserToDeleteRows = false;
            this.izlazstavkedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izlazstavkedatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izlazstavkedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izlazstavkedatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzlazStavkaID,
            this.IzlazID2,
            this.Proizvod,
            this.Sorta,
            this.Kolicina,
            this.Cijena});
            this.izlazstavkedatagrid.Location = new System.Drawing.Point(12, 350);
            this.izlazstavkedatagrid.Name = "izlazstavkedatagrid";
            this.izlazstavkedatagrid.ReadOnly = true;
            this.izlazstavkedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izlazstavkedatagrid.Size = new System.Drawing.Size(897, 188);
            this.izlazstavkedatagrid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Broj racuna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Datum od";
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(354, 61);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 20);
            this.datumDo.TabIndex = 11;
            this.datumDo.Value = new System.DateTime(2020, 9, 12, 0, 0, 0, 0);
            // 
            // datumOD
            // 
            this.datumOD.Location = new System.Drawing.Point(98, 61);
            this.datumOD.Name = "datumOD";
            this.datumOD.Size = new System.Drawing.Size(200, 20);
            this.datumOD.TabIndex = 10;
            this.datumOD.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // brojracunatxt
            // 
            this.brojracunatxt.Location = new System.Drawing.Point(616, 61);
            this.brojracunatxt.Name = "brojracunatxt";
            this.brojracunatxt.Size = new System.Drawing.Size(110, 20);
            this.brojracunatxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Narudzba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Narudzba stavke";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_edit_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(768, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Promjeni stavku";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(808, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Trazi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzlazStavkaID
            // 
            this.IzlazStavkaID.DataPropertyName = "IzlazStavkaID";
            this.IzlazStavkaID.HeaderText = "IzlazStavkaID";
            this.IzlazStavkaID.Name = "IzlazStavkaID";
            this.IzlazStavkaID.ReadOnly = true;
            this.IzlazStavkaID.Visible = false;
            // 
            // IzlazID2
            // 
            this.IzlazID2.DataPropertyName = "IzlazID";
            this.IzlazID2.HeaderText = "IzlazID2";
            this.IzlazID2.Name = "IzlazID2";
            this.IzlazID2.ReadOnly = true;
            this.IzlazID2.Visible = false;
            // 
            // Proizvod
            // 
            this.Proizvod.DataPropertyName = "Proizvod";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.ReadOnly = true;
            // 
            // Sorta
            // 
            this.Sorta.DataPropertyName = "Sorta";
            this.Sorta.HeaderText = "Sorta";
            this.Sorta.Name = "Sorta";
            this.Sorta.ReadOnly = true;
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
            // IndexNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(928, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brojracunatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOD);
            this.Controls.Add(this.izlazstavkedatagrid);
            this.Controls.Add(this.izlazidatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndexNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija narudžbe";
            this.Load += new System.EventHandler(this.IndexNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.izlazidatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izlazstavkedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView izlazidatagrid;
        private System.Windows.Forms.DataGridView izlazstavkedatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzlazID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zakljucen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostavljac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOD;
        private System.Windows.Forms.TextBox brojracunatxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzlazStavkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzlazID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}