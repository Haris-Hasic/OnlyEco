namespace eZdravaIshrana_UI.Manufacturer
{
    partial class IndexProizvodjac
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
            this.ImeiPrezimetxt = new System.Windows.Forms.TextBox();
            this.nazivProizvodatxt = new System.Windows.Forms.TextBox();
            this.sortaCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.traziBtn = new System.Windows.Forms.Button();
            this.proizvodjacDataGrid = new System.Windows.Forms.DataGridView();
            this.ProizvodjacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeiPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZiroRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjacDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImeiPrezimetxt
            // 
            this.ImeiPrezimetxt.Location = new System.Drawing.Point(230, 71);
            this.ImeiPrezimetxt.Name = "ImeiPrezimetxt";
            this.ImeiPrezimetxt.Size = new System.Drawing.Size(146, 20);
            this.ImeiPrezimetxt.TabIndex = 0;
            // 
            // nazivProizvodatxt
            // 
            this.nazivProizvodatxt.Location = new System.Drawing.Point(21, 71);
            this.nazivProizvodatxt.Name = "nazivProizvodatxt";
            this.nazivProizvodatxt.Size = new System.Drawing.Size(146, 20);
            this.nazivProizvodatxt.TabIndex = 1;
            // 
            // sortaCmb
            // 
            this.sortaCmb.FormattingEnabled = true;
            this.sortaCmb.Location = new System.Drawing.Point(440, 71);
            this.sortaCmb.Name = "sortaCmb";
            this.sortaCmb.Size = new System.Drawing.Size(146, 21);
            this.sortaCmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proizvodjač";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv proizvoda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sorta";
            // 
            // traziBtn
            // 
            this.traziBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.traziBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traziBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.traziBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.traziBtn.Location = new System.Drawing.Point(501, 113);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(85, 43);
            this.traziBtn.TabIndex = 6;
            this.traziBtn.Text = "Trazi";
            this.traziBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.traziBtn.UseVisualStyleBackColor = false;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // proizvodjacDataGrid
            // 
            this.proizvodjacDataGrid.AllowUserToAddRows = false;
            this.proizvodjacDataGrid.AllowUserToDeleteRows = false;
            this.proizvodjacDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodjacDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.proizvodjacDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proizvodjacDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodjacDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodjacID,
            this.ImeiPrezime,
            this.Naziv,
            this.Sorta,
            this.Email,
            this.Adresa,
            this.Telefon,
            this.ZiroRacuni});
            this.proizvodjacDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodjacDataGrid.Location = new System.Drawing.Point(0, 223);
            this.proizvodjacDataGrid.Name = "proizvodjacDataGrid";
            this.proizvodjacDataGrid.ReadOnly = true;
            this.proizvodjacDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proizvodjacDataGrid.RowHeadersWidth = 40;
            this.proizvodjacDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodjacDataGrid.Size = new System.Drawing.Size(1008, 331);
            this.proizvodjacDataGrid.TabIndex = 7;
            // 
            // ProizvodjacID
            // 
            this.ProizvodjacID.DataPropertyName = "ProizvodjacID";
            this.ProizvodjacID.HeaderText = "ProizvodjacID";
            this.ProizvodjacID.Name = "ProizvodjacID";
            this.ProizvodjacID.ReadOnly = true;
            this.ProizvodjacID.Visible = false;
            // 
            // ImeiPrezime
            // 
            this.ImeiPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImeiPrezime.DataPropertyName = "Ime_i_prezime";
            this.ImeiPrezime.HeaderText = "Ime i prezime";
            this.ImeiPrezime.Name = "ImeiPrezime";
            this.ImeiPrezime.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sorta
            // 
            this.Sorta.DataPropertyName = "Sorta";
            this.Sorta.HeaderText = "Sorta";
            this.Sorta.Name = "Sorta";
            this.Sorta.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
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
            // ZiroRacuni
            // 
            this.ZiroRacuni.DataPropertyName = "ZiroRacuni";
            this.ZiroRacuni.HeaderText = "Ziro racuni";
            this.ZiroRacuni.Name = "ZiroRacuni";
            this.ZiroRacuni.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.traziBtn);
            this.groupBox1.Controls.Add(this.ImeiPrezimetxt);
            this.groupBox1.Controls.Add(this.nazivProizvodatxt);
            this.groupBox1.Controls.Add(this.sortaCmb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(261, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 185);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // IndexProizvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.proizvodjacDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndexProizvodjac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvođači";
            this.Load += new System.EventHandler(this.IndexProizvodjac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjacDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ImeiPrezimetxt;
        private System.Windows.Forms.TextBox nazivProizvodatxt;
        private System.Windows.Forms.ComboBox sortaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.DataGridView proizvodjacDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodjacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeiPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroRacuni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}