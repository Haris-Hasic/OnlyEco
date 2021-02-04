namespace eZdravaIshrana_UI.Storage
{
    partial class IndexSkladiste
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
            this.skladistedatagrid = new System.Windows.Forms.DataGridView();
            this.SkladisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime_proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime_proizvodjaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nabavljeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naruceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanje_na_skladistu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstacmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.traziBtn = new System.Windows.Forms.Button();
            this.novoskladistebtn = new System.Windows.Forms.Button();
            this.narucibtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.skladistedatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skladistedatagrid
            // 
            this.skladistedatagrid.AllowUserToAddRows = false;
            this.skladistedatagrid.AllowUserToDeleteRows = false;
            this.skladistedatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skladistedatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skladistedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladistedatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkladisteID,
            this.ProizvodID,
            this.Skladiste,
            this.Adresa,
            this.Proizvod,
            this.Vrsta,
            this.Sorta,
            this.Ime_proizvodjac,
            this.Prezime_proizvodjaca,
            this.Nabavljeno,
            this.Naruceno,
            this.Stanje_na_skladistu});
            this.skladistedatagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skladistedatagrid.Location = new System.Drawing.Point(0, 248);
            this.skladistedatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.skladistedatagrid.Name = "skladistedatagrid";
            this.skladistedatagrid.ReadOnly = true;
            this.skladistedatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skladistedatagrid.Size = new System.Drawing.Size(1289, 384);
            this.skladistedatagrid.TabIndex = 0;
            this.skladistedatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skladistedatagrid_CellDoubleClick);
            // 
            // SkladisteID
            // 
            this.SkladisteID.DataPropertyName = "SkladisteID";
            this.SkladisteID.HeaderText = "SkladisteID";
            this.SkladisteID.Name = "SkladisteID";
            this.SkladisteID.ReadOnly = true;
            this.SkladisteID.Visible = false;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            // 
            // Skladiste
            // 
            this.Skladiste.DataPropertyName = "Skladiste";
            this.Skladiste.HeaderText = "Skladiste";
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Proizvod
            // 
            this.Proizvod.DataPropertyName = "Proizvod";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Sorta
            // 
            this.Sorta.DataPropertyName = "Sorta";
            this.Sorta.HeaderText = "Sorta";
            this.Sorta.Name = "Sorta";
            this.Sorta.ReadOnly = true;
            // 
            // Ime_proizvodjac
            // 
            this.Ime_proizvodjac.DataPropertyName = "Ime_proizvodjac";
            this.Ime_proizvodjac.HeaderText = "Ime proizvodjača";
            this.Ime_proizvodjac.Name = "Ime_proizvodjac";
            this.Ime_proizvodjac.ReadOnly = true;
            // 
            // Prezime_proizvodjaca
            // 
            this.Prezime_proizvodjaca.DataPropertyName = "Prezime_proizvodjaca";
            this.Prezime_proizvodjaca.HeaderText = "Prezime proizvodjaca";
            this.Prezime_proizvodjaca.Name = "Prezime_proizvodjaca";
            this.Prezime_proizvodjaca.ReadOnly = true;
            // 
            // Nabavljeno
            // 
            this.Nabavljeno.DataPropertyName = "Nabavljeno";
            this.Nabavljeno.HeaderText = "Stanje na skladištu";
            this.Nabavljeno.Name = "Nabavljeno";
            this.Nabavljeno.ReadOnly = true;
            // 
            // Naruceno
            // 
            this.Naruceno.DataPropertyName = "Naruceno";
            this.Naruceno.HeaderText = "Naruceno";
            this.Naruceno.Name = "Naruceno";
            this.Naruceno.ReadOnly = true;
            // 
            // Stanje_na_skladistu
            // 
            this.Stanje_na_skladistu.DataPropertyName = "Stanje_na_skladistu";
            this.Stanje_na_skladistu.HeaderText = "Razlika";
            this.Stanje_na_skladistu.Name = "Stanje_na_skladistu";
            this.Stanje_na_skladistu.ReadOnly = true;
            // 
            // vrstacmb
            // 
            this.vrstacmb.FormattingEnabled = true;
            this.vrstacmb.Location = new System.Drawing.Point(185, 63);
            this.vrstacmb.Margin = new System.Windows.Forms.Padding(4);
            this.vrstacmb.Name = "vrstacmb";
            this.vrstacmb.Size = new System.Drawing.Size(256, 24);
            this.vrstacmb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Skladište";
            // 
            // traziBtn
            // 
            this.traziBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.traziBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traziBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.traziBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traziBtn.Location = new System.Drawing.Point(343, 107);
            this.traziBtn.Margin = new System.Windows.Forms.Padding(4);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(98, 56);
            this.traziBtn.TabIndex = 9;
            this.traziBtn.Text = "Traži";
            this.traziBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traziBtn.UseVisualStyleBackColor = false;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // novoskladistebtn
            // 
            this.novoskladistebtn.BackColor = System.Drawing.Color.AliceBlue;
            this.novoskladistebtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoskladistebtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_user_male_32;
            this.novoskladistebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoskladistebtn.Location = new System.Drawing.Point(1115, 13);
            this.novoskladistebtn.Margin = new System.Windows.Forms.Padding(4);
            this.novoskladistebtn.Name = "novoskladistebtn";
            this.novoskladistebtn.Size = new System.Drawing.Size(147, 53);
            this.novoskladistebtn.TabIndex = 10;
            this.novoskladistebtn.Text = "Novo skladište";
            this.novoskladistebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoskladistebtn.UseVisualStyleBackColor = false;
            this.novoskladistebtn.Click += new System.EventHandler(this.novoskladistebtn_Click);
            // 
            // narucibtn
            // 
            this.narucibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.narucibtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narucibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_edit_24;
            this.narucibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.narucibtn.Location = new System.Drawing.Point(1059, 157);
            this.narucibtn.Margin = new System.Windows.Forms.Padding(4);
            this.narucibtn.Name = "narucibtn";
            this.narucibtn.Size = new System.Drawing.Size(203, 66);
            this.narucibtn.TabIndex = 11;
            this.narucibtn.Text = "Naruči odabranu stavku";
            this.narucibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.narucibtn.UseVisualStyleBackColor = false;
            this.narucibtn.Click += new System.EventHandler(this.narucibtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.traziBtn);
            this.groupBox1.Controls.Add(this.vrstacmb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(338, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 185);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // IndexSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1289, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.narucibtn);
            this.Controls.Add(this.novoskladistebtn);
            this.Controls.Add(this.skladistedatagrid);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IndexSkladiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje na skladištu";
            this.Load += new System.EventHandler(this.IndexSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladistedatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView skladistedatagrid;
        private System.Windows.Forms.ComboBox vrstacmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button novoskladistebtn;
        private System.Windows.Forms.Button narucibtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkladisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime_proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime_proizvodjaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nabavljeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naruceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje_na_skladistu;
    }
}