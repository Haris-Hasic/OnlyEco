namespace eZdravaIshrana_UI.Supply
{
    partial class Nabavka
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
            this.datumOD = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.skladistecmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ulazidatagrid = new System.Windows.Forms.DataGridView();
            this.UlazID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosRacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dobavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trazibtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ulazidatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datumOD
            // 
            this.datumOD.Location = new System.Drawing.Point(13, 67);
            this.datumOD.Name = "datumOD";
            this.datumOD.Size = new System.Drawing.Size(200, 20);
            this.datumOD.TabIndex = 0;
            this.datumOD.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(267, 67);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 20);
            this.datumDo.TabIndex = 1;
            this.datumDo.Value = new System.DateTime(2020, 9, 22, 0, 0, 0, 0);
            // 
            // skladistecmb
            // 
            this.skladistecmb.FormattingEnabled = true;
            this.skladistecmb.Location = new System.Drawing.Point(13, 137);
            this.skladistecmb.Name = "skladistecmb";
            this.skladistecmb.Size = new System.Drawing.Size(200, 21);
            this.skladistecmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skladiste";
            // 
            // ulazidatagrid
            // 
            this.ulazidatagrid.AllowUserToAddRows = false;
            this.ulazidatagrid.AllowUserToDeleteRows = false;
            this.ulazidatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ulazidatagrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ulazidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulazidatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UlazID,
            this.BrojFakture,
            this.Datum,
            this.IznosRacuna,
            this.PDV,
            this.Napomena,
            this.Skladiste,
            this.Korisnik,
            this.Dobavljac});
            this.ulazidatagrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ulazidatagrid.Location = new System.Drawing.Point(0, 241);
            this.ulazidatagrid.Name = "ulazidatagrid";
            this.ulazidatagrid.ReadOnly = true;
            this.ulazidatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ulazidatagrid.Size = new System.Drawing.Size(952, 267);
            this.ulazidatagrid.TabIndex = 6;
            this.ulazidatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ulazidatagrid_CellDoubleClick);
            // 
            // UlazID
            // 
            this.UlazID.DataPropertyName = "UlazID";
            this.UlazID.HeaderText = "UlazID";
            this.UlazID.Name = "UlazID";
            this.UlazID.ReadOnly = true;
            this.UlazID.Visible = false;
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
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Skladiste
            // 
            this.Skladiste.DataPropertyName = "Skladiste";
            this.Skladiste.HeaderText = "Skladiste";
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Dobavljac
            // 
            this.Dobavljac.DataPropertyName = "Dobavljac";
            this.Dobavljac.HeaderText = "Dobavljac";
            this.Dobavljac.Name = "Dobavljac";
            this.Dobavljac.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_delete_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Izbriši nabavku";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_user_male_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(801, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Nova nabavka";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trazibtn
            // 
            this.trazibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.trazibtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trazibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_search_26;
            this.trazibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trazibtn.Location = new System.Drawing.Point(363, 122);
            this.trazibtn.Name = "trazibtn";
            this.trazibtn.Size = new System.Drawing.Size(104, 49);
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
            this.pictureBox2.Size = new System.Drawing.Size(200, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trazibtn);
            this.groupBox1.Controls.Add(this.datumOD);
            this.groupBox1.Controls.Add(this.datumDo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.skladistecmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(250, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 194);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // Nabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(952, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ulazidatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Nabavka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nabavka";
            this.Load += new System.EventHandler(this.Nabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulazidatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumOD;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.ComboBox skladistecmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ulazidatagrid;
        private System.Windows.Forms.Button trazibtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlazID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosRacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dobavljac;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}