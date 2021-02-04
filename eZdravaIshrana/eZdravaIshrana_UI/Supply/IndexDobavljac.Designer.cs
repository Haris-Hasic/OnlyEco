namespace eZdravaIshrana_UI.Supply
{
    partial class IndexDobavljac
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
            this.dobavljaciGrid = new System.Windows.Forms.DataGridView();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZiroRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNabavki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaPotrosnja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.brojNabavkiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.traziBtn = new System.Windows.Forms.Button();
            this.noviDobavljacBtn = new System.Windows.Forms.Button();
            this.nabavkeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavljaciGrid
            // 
            this.dobavljaciGrid.AllowUserToAddRows = false;
            this.dobavljaciGrid.AllowUserToDeleteRows = false;
            this.dobavljaciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dobavljaciGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dobavljaciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljaciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.Email,
            this.Telefon,
            this.Adresa,
            this.ZiroRacuni,
            this.BrojNabavki,
            this.UkupnaPotrosnja});
            this.dobavljaciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dobavljaciGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dobavljaciGrid.Location = new System.Drawing.Point(0, 191);
            this.dobavljaciGrid.Name = "dobavljaciGrid";
            this.dobavljaciGrid.ReadOnly = true;
            this.dobavljaciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dobavljaciGrid.Size = new System.Drawing.Size(919, 195);
            this.dobavljaciGrid.TabIndex = 0;
            this.dobavljaciGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobavljaciGrid_CellDoubleClick);
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.ReadOnly = true;
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // ZiroRacuni
            // 
            this.ZiroRacuni.DataPropertyName = "ZiroRacuni";
            this.ZiroRacuni.HeaderText = "ZiroRacuni";
            this.ZiroRacuni.Name = "ZiroRacuni";
            this.ZiroRacuni.ReadOnly = true;
            // 
            // BrojNabavki
            // 
            this.BrojNabavki.DataPropertyName = "BrojNabavki";
            this.BrojNabavki.HeaderText = "Broj nabavki";
            this.BrojNabavki.Name = "BrojNabavki";
            this.BrojNabavki.ReadOnly = true;
            // 
            // UkupnaPotrosnja
            // 
            this.UkupnaPotrosnja.DataPropertyName = "UkupnaPotrosnja";
            this.UkupnaPotrosnja.HeaderText = "Ukupna potrosnja";
            this.UkupnaPotrosnja.Name = "UkupnaPotrosnja";
            this.UkupnaPotrosnja.ReadOnly = true;
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(363, 41);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(229, 20);
            this.nazivTxt.TabIndex = 1;
            // 
            // brojNabavkiTxt
            // 
            this.brojNabavkiTxt.Location = new System.Drawing.Point(363, 78);
            this.brojNabavkiTxt.Name = "brojNabavkiTxt";
            this.brojNabavkiTxt.Size = new System.Drawing.Size(130, 20);
            this.brojNabavkiTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj nabavki";
            // 
            // traziBtn
            // 
            this.traziBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.traziBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traziBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.traziBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traziBtn.Location = new System.Drawing.Point(502, 94);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(90, 55);
            this.traziBtn.TabIndex = 5;
            this.traziBtn.Text = "Traži";
            this.traziBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traziBtn.UseVisualStyleBackColor = false;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // noviDobavljacBtn
            // 
            this.noviDobavljacBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.noviDobavljacBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviDobavljacBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_user_male_32;
            this.noviDobavljacBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noviDobavljacBtn.Location = new System.Drawing.Point(751, 12);
            this.noviDobavljacBtn.Name = "noviDobavljacBtn";
            this.noviDobavljacBtn.Size = new System.Drawing.Size(140, 60);
            this.noviDobavljacBtn.TabIndex = 6;
            this.noviDobavljacBtn.Text = "Novi dobavljac";
            this.noviDobavljacBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noviDobavljacBtn.UseVisualStyleBackColor = false;
            this.noviDobavljacBtn.Click += new System.EventHandler(this.noviDobavljacBtn_Click);
            // 
            // nabavkeBtn
            // 
            this.nabavkeBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.nabavkeBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nabavkeBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.nabavkeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nabavkeBtn.Location = new System.Drawing.Point(751, 93);
            this.nabavkeBtn.Name = "nabavkeBtn";
            this.nabavkeBtn.Size = new System.Drawing.Size(140, 57);
            this.nabavkeBtn.TabIndex = 7;
            this.nabavkeBtn.Text = "Prikazi nabavke";
            this.nabavkeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nabavkeBtn.UseVisualStyleBackColor = false;
            this.nabavkeBtn.Click += new System.EventHandler(this.nabavkeBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // IndexDobavljac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 386);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nabavkeBtn);
            this.Controls.Add(this.noviDobavljacBtn);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brojNabavkiTxt);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.dobavljaciGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndexDobavljac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dobavljača";
            this.Load += new System.EventHandler(this.IndexDobavljac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljaciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dobavljaciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNabavki;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaPotrosnja;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox brojNabavkiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button noviDobavljacBtn;
        private System.Windows.Forms.Button nabavkeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}