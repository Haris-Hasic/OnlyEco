namespace eZdravaIshrana_UI.Deliverer
{
    partial class IndexDostavljac
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
            this.dostavljacdatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ImeiPrezimetxt = new System.Windows.Forms.TextBox();
            this.noviDostavljacbtn = new System.Windows.Forms.Button();
            this.trazibtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DostavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZiroRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dostavljacdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dostavljacdatagrid
            // 
            this.dostavljacdatagrid.AllowUserToAddRows = false;
            this.dostavljacdatagrid.AllowUserToDeleteRows = false;
            this.dostavljacdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dostavljacdatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dostavljacdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dostavljacdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DostavljacID,
            this.Naziv,
            this.KontaktOsoba,
            this.Adresa,
            this.Telefon,
            this.Fax,
            this.Web,
            this.Email,
            this.ZiroRacuni,
            this.Napomena,
            this.Prosjek,
            this.Status});
            this.dostavljacdatagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dostavljacdatagrid.Location = new System.Drawing.Point(0, 221);
            this.dostavljacdatagrid.Name = "dostavljacdatagrid";
            this.dostavljacdatagrid.ReadOnly = true;
            this.dostavljacdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dostavljacdatagrid.Size = new System.Drawing.Size(1066, 338);
            this.dostavljacdatagrid.TabIndex = 0;
            this.dostavljacdatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dostavljacdatagrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime i prezime";
            // 
            // ImeiPrezimetxt
            // 
            this.ImeiPrezimetxt.Location = new System.Drawing.Point(119, 49);
            this.ImeiPrezimetxt.Name = "ImeiPrezimetxt";
            this.ImeiPrezimetxt.Size = new System.Drawing.Size(253, 20);
            this.ImeiPrezimetxt.TabIndex = 5;
            // 
            // noviDostavljacbtn
            // 
            this.noviDostavljacbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.noviDostavljacbtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviDostavljacbtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_user_male_32;
            this.noviDostavljacbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noviDostavljacbtn.Location = new System.Drawing.Point(889, 14);
            this.noviDostavljacbtn.Name = "noviDostavljacbtn";
            this.noviDostavljacbtn.Size = new System.Drawing.Size(156, 49);
            this.noviDostavljacbtn.TabIndex = 8;
            this.noviDostavljacbtn.Text = "Novi dostavljač";
            this.noviDostavljacbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noviDostavljacbtn.UseVisualStyleBackColor = false;
            this.noviDostavljacbtn.Click += new System.EventHandler(this.noviDostavljacbtn_Click);
            // 
            // trazibtn
            // 
            this.trazibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.trazibtn.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trazibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.trazibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trazibtn.Location = new System.Drawing.Point(298, 92);
            this.trazibtn.Name = "trazibtn";
            this.trazibtn.Size = new System.Drawing.Size(74, 38);
            this.trazibtn.TabIndex = 7;
            this.trazibtn.Text = "Traži";
            this.trazibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trazibtn.UseVisualStyleBackColor = false;
            this.trazibtn.Click += new System.EventHandler(this.trazibtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trazibtn);
            this.groupBox1.Controls.Add(this.ImeiPrezimetxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(293, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 164);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // DostavljacID
            // 
            this.DostavljacID.DataPropertyName = "DostavljacID";
            this.DostavljacID.HeaderText = "DostavljacID";
            this.DostavljacID.Name = "DostavljacID";
            this.DostavljacID.ReadOnly = true;
            this.DostavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt Osoba";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            // 
            // Web
            // 
            this.Web.DataPropertyName = "Web";
            this.Web.HeaderText = "Web";
            this.Web.Name = "Web";
            this.Web.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ZiroRacuni
            // 
            this.ZiroRacuni.DataPropertyName = "ZiroRacuni";
            this.ZiroRacuni.HeaderText = "Ziro Racun";
            this.ZiroRacuni.Name = "ZiroRacuni";
            this.ZiroRacuni.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IndexDostavljac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.noviDostavljacbtn);
            this.Controls.Add(this.dostavljacdatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndexDostavljac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dostavljači";
            this.Load += new System.EventHandler(this.IndexDostavljac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dostavljacdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dostavljacdatagrid;
        private System.Windows.Forms.Button noviDostavljacbtn;
        private System.Windows.Forms.Button trazibtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImeiPrezimetxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DostavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Web;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}