namespace eZdravaIshrana_UI.Users
{
    partial class IndexKupci
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
            this.traziBtn = new System.Windows.Forms.Button();
            this.imeiprezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kupcidatagrid = new System.Windows.Forms.DataGridView();
            this.KupacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRegistracije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kupcidatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // traziBtn
            // 
            this.traziBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.traziBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.traziBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traziBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.traziBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traziBtn.Location = new System.Drawing.Point(743, 57);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(86, 42);
            this.traziBtn.TabIndex = 5;
            this.traziBtn.Text = "Trazi";
            this.traziBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traziBtn.UseVisualStyleBackColor = false;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // imeiprezimeInput
            // 
            this.imeiprezimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imeiprezimeInput.Location = new System.Drawing.Point(361, 69);
            this.imeiprezimeInput.Name = "imeiprezimeInput";
            this.imeiprezimeInput.Size = new System.Drawing.Size(362, 20);
            this.imeiprezimeInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime i prezime";
            // 
            // kupcidatagrid
            // 
            this.kupcidatagrid.AllowUserToAddRows = false;
            this.kupcidatagrid.AllowUserToDeleteRows = false;
            this.kupcidatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kupcidatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kupcidatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kupcidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kupcidatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KupacID,
            this.Ime,
            this.Prezime,
            this.DatumRegistracije,
            this.Email,
            this.KorisnickoIme,
            this.Status});
            this.kupcidatagrid.Location = new System.Drawing.Point(0, 182);
            this.kupcidatagrid.Name = "kupcidatagrid";
            this.kupcidatagrid.ReadOnly = true;
            this.kupcidatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kupcidatagrid.Size = new System.Drawing.Size(999, 461);
            this.kupcidatagrid.TabIndex = 6;
            this.kupcidatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kupcidatagrid_CellDoubleClick);
            // 
            // KupacID
            // 
            this.KupacID.DataPropertyName = "KupacID";
            this.KupacID.HeaderText = "KupacID";
            this.KupacID.Name = "KupacID";
            this.KupacID.ReadOnly = true;
            this.KupacID.Visible = false;
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
            // DatumRegistracije
            // 
            this.DatumRegistracije.DataPropertyName = "DatumRegistracije";
            this.DatumRegistracije.HeaderText = "Datum registracije";
            this.DatumRegistracije.Name = "DatumRegistracije";
            this.DatumRegistracije.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // IndexKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(999, 643);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kupcidatagrid);
            this.Controls.Add(this.traziBtn);
            this.Controls.Add(this.imeiprezimeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndexKupci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga Kupaca";
            this.Load += new System.EventHandler(this.IndexKupci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kupcidatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.TextBox imeiprezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kupcidatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRegistracije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}