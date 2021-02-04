namespace eZdravaIshrana_UI.Products
{
    partial class IndexForm
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
            this.cijenaInput = new System.Windows.Forms.TextBox();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.SortaCmb = new System.Windows.Forms.ComboBox();
            this.vrstaCmb = new System.Windows.Forms.ComboBox();
            this.proizvodjacCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvođač = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviProizvodBtn = new System.Windows.Forms.Button();
            this.pretragaProizvodaBtn = new System.Windows.Forms.Button();
            this.dodajnastavkubtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(101, 113);
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(164, 21);
            this.cijenaInput.TabIndex = 24;
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(101, 72);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(164, 21);
            this.sifraInput.TabIndex = 23;
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(101, 33);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(164, 21);
            this.nazivInput.TabIndex = 22;
            // 
            // SortaCmb
            // 
            this.SortaCmb.FormattingEnabled = true;
            this.SortaCmb.Location = new System.Drawing.Point(383, 110);
            this.SortaCmb.Name = "SortaCmb";
            this.SortaCmb.Size = new System.Drawing.Size(164, 23);
            this.SortaCmb.TabIndex = 21;
            // 
            // vrstaCmb
            // 
            this.vrstaCmb.FormattingEnabled = true;
            this.vrstaCmb.Location = new System.Drawing.Point(383, 72);
            this.vrstaCmb.Name = "vrstaCmb";
            this.vrstaCmb.Size = new System.Drawing.Size(164, 23);
            this.vrstaCmb.TabIndex = 20;
            this.vrstaCmb.SelectedIndexChanged += new System.EventHandler(this.vrstaCmb_SelectedIndexChanged);
            // 
            // proizvodjacCmb
            // 
            this.proizvodjacCmb.FormattingEnabled = true;
            this.proizvodjacCmb.Location = new System.Drawing.Point(383, 33);
            this.proizvodjacCmb.Name = "proizvodjacCmb";
            this.proizvodjacCmb.Size = new System.Drawing.Size(164, 23);
            this.proizvodjacCmb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sorta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Proizvodjač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sifra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv";
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.SlikaThumb,
            this.Vrsta,
            this.Sorta,
            this.Proizvođač});
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 260);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.RowTemplate.Height = 50;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(1133, 447);
            this.proizvodiGrid.TabIndex = 25;
            this.proizvodiGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proizvodiGrid_CellDoubleClick);
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
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
            // Proizvođač
            // 
            this.Proizvođač.DataPropertyName = "Proizvođač";
            this.Proizvođač.HeaderText = "Proizvođač";
            this.Proizvođač.Name = "Proizvođač";
            this.Proizvođač.ReadOnly = true;
            // 
            // noviProizvodBtn
            // 
            this.noviProizvodBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.noviProizvodBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviProizvodBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_user_male_32;
            this.noviProizvodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noviProizvodBtn.Location = new System.Drawing.Point(972, 17);
            this.noviProizvodBtn.Name = "noviProizvodBtn";
            this.noviProizvodBtn.Size = new System.Drawing.Size(136, 48);
            this.noviProizvodBtn.TabIndex = 26;
            this.noviProizvodBtn.Text = "Novi proizvod";
            this.noviProizvodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noviProizvodBtn.UseVisualStyleBackColor = false;
            this.noviProizvodBtn.Click += new System.EventHandler(this.noviProizvodBtn_Click);
            // 
            // pretragaProizvodaBtn
            // 
            this.pretragaProizvodaBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.pretragaProizvodaBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaProizvodaBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.pretragaProizvodaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pretragaProizvodaBtn.Location = new System.Drawing.Point(449, 160);
            this.pretragaProizvodaBtn.Name = "pretragaProizvodaBtn";
            this.pretragaProizvodaBtn.Size = new System.Drawing.Size(98, 39);
            this.pretragaProizvodaBtn.TabIndex = 27;
            this.pretragaProizvodaBtn.Text = "Traži";
            this.pretragaProizvodaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pretragaProizvodaBtn.UseVisualStyleBackColor = false;
            this.pretragaProizvodaBtn.Click += new System.EventHandler(this.pretragaProizvodaBtn_Click);
            // 
            // dodajnastavkubtn
            // 
            this.dodajnastavkubtn.BackColor = System.Drawing.Color.AliceBlue;
            this.dodajnastavkubtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajnastavkubtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_edit_24;
            this.dodajnastavkubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajnastavkubtn.Location = new System.Drawing.Point(915, 185);
            this.dodajnastavkubtn.Name = "dodajnastavkubtn";
            this.dodajnastavkubtn.Size = new System.Drawing.Size(193, 55);
            this.dodajnastavkubtn.TabIndex = 29;
            this.dodajnastavkubtn.Text = "Dodaj poizvod na stavku";
            this.dodajnastavkubtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajnastavkubtn.UseVisualStyleBackColor = false;
            this.dodajnastavkubtn.Click += new System.EventHandler(this.dodajnastavkubtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretragaProizvodaBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cijenaInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sifraInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nazivInput);
            this.groupBox1.Controls.Add(this.proizvodjacCmb);
            this.groupBox1.Controls.Add(this.SortaCmb);
            this.groupBox1.Controls.Add(this.vrstaCmb);
            this.groupBox1.Location = new System.Drawing.Point(244, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 213);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1133, 707);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dodajnastavkubtn);
            this.Controls.Add(this.noviProizvodBtn);
            this.Controls.Add(this.proizvodiGrid);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija proizvoda";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cijenaInput;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.ComboBox SortaCmb;
        private System.Windows.Forms.ComboBox vrstaCmb;
        private System.Windows.Forms.ComboBox proizvodjacCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView proizvodiGrid;
        private System.Windows.Forms.Button noviProizvodBtn;
        private System.Windows.Forms.Button pretragaProizvodaBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvođač;
        private System.Windows.Forms.Button dodajnastavkubtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}