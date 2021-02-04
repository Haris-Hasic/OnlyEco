namespace eZdravaIshrana_UI.Orders
{
    partial class DetailsForm
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
            this.stavkeNarudzbeGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumlbl = new System.Windows.Forms.Label();
            this.brojNarudzbelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kupaclbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iznoslbl = new System.Windows.Forms.Label();
            this.skladistecmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.procesirajbtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lblUdaljenost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblvrijem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // stavkeNarudzbeGrid
            // 
            this.stavkeNarudzbeGrid.AllowUserToAddRows = false;
            this.stavkeNarudzbeGrid.AllowUserToDeleteRows = false;
            this.stavkeNarudzbeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stavkeNarudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeNarudzbeGrid.Location = new System.Drawing.Point(643, 184);
            this.stavkeNarudzbeGrid.Name = "stavkeNarudzbeGrid";
            this.stavkeNarudzbeGrid.ReadOnly = true;
            this.stavkeNarudzbeGrid.Size = new System.Drawing.Size(559, 213);
            this.stavkeNarudzbeGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj narudžbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // datumlbl
            // 
            this.datumlbl.AutoSize = true;
            this.datumlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumlbl.Location = new System.Drawing.Point(819, 90);
            this.datumlbl.Name = "datumlbl";
            this.datumlbl.Size = new System.Drawing.Size(49, 16);
            this.datumlbl.TabIndex = 3;
            this.datumlbl.Text = "Datum";
            // 
            // brojNarudzbelbl
            // 
            this.brojNarudzbelbl.AutoSize = true;
            this.brojNarudzbelbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojNarudzbelbl.Location = new System.Drawing.Point(819, 55);
            this.brojNarudzbelbl.Name = "brojNarudzbelbl";
            this.brojNarudzbelbl.Size = new System.Drawing.Size(98, 16);
            this.brojNarudzbelbl.TabIndex = 4;
            this.brojNarudzbelbl.Text = "Broj narudžbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1011, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kupac:";
            // 
            // kupaclbl
            // 
            this.kupaclbl.AutoSize = true;
            this.kupaclbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kupaclbl.Location = new System.Drawing.Point(1078, 87);
            this.kupaclbl.Name = "kupaclbl";
            this.kupaclbl.Size = new System.Drawing.Size(48, 16);
            this.kupaclbl.TabIndex = 6;
            this.kupaclbl.Text = "Kupac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1015, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iznos:";
            // 
            // iznoslbl
            // 
            this.iznoslbl.AutoSize = true;
            this.iznoslbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iznoslbl.Location = new System.Drawing.Point(1085, 122);
            this.iznoslbl.Name = "iznoslbl";
            this.iznoslbl.Size = new System.Drawing.Size(41, 16);
            this.iznoslbl.TabIndex = 8;
            this.iznoslbl.Text = "Iznos";
            // 
            // skladistecmb
            // 
            this.skladistecmb.FormattingEnabled = true;
            this.skladistecmb.Location = new System.Drawing.Point(990, 418);
            this.skladistecmb.Name = "skladistecmb";
            this.skladistecmb.Size = new System.Drawing.Size(212, 21);
            this.skladistecmb.TabIndex = 9;
            this.skladistecmb.Validating += new System.ComponentModel.CancelEventHandler(this.skladistecmb_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(891, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dostavljač";
            // 
            // procesirajbtn
            // 
            this.procesirajbtn.BackColor = System.Drawing.Color.AliceBlue;
            this.procesirajbtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesirajbtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.procesirajbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.procesirajbtn.Location = new System.Drawing.Point(1088, 456);
            this.procesirajbtn.Name = "procesirajbtn";
            this.procesirajbtn.Size = new System.Drawing.Size(114, 52);
            this.procesirajbtn.TabIndex = 11;
            this.procesirajbtn.Text = "Procesiraj";
            this.procesirajbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.procesirajbtn.UseVisualStyleBackColor = false;
            this.procesirajbtn.Click += new System.EventHandler(this.procesirajbtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(954, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 73;
            this.button1.Text = "Zatvori";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(575, 563);
            this.splitter1.TabIndex = 74;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(575, 563);
            this.map.TabIndex = 75;
            this.map.Zoom = 0D;
            // 
            // lblUdaljenost
            // 
            this.lblUdaljenost.AutoSize = true;
            this.lblUdaljenost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdaljenost.Location = new System.Drawing.Point(819, 122);
            this.lblUdaljenost.Name = "lblUdaljenost";
            this.lblUdaljenost.Size = new System.Drawing.Size(0, 16);
            this.lblUdaljenost.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Udaljenost";
            // 
            // lblvrijem
            // 
            this.lblvrijem.AutoSize = true;
            this.lblvrijem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvrijem.Location = new System.Drawing.Point(819, 155);
            this.lblvrijem.Name = "lblvrijem";
            this.lblvrijem.Size = new System.Drawing.Size(0, 16);
            this.lblvrijem.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(682, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Vrijema potrebno";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1252, 563);
            this.Controls.Add(this.lblvrijem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUdaljenost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.procesirajbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skladistecmb);
            this.Controls.Add(this.iznoslbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kupaclbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brojNarudzbelbl);
            this.Controls.Add(this.datumlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stavkeNarudzbeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji narudžbe";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stavkeNarudzbeGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datumlbl;
        private System.Windows.Forms.Label brojNarudzbelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kupaclbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label iznoslbl;
        private System.Windows.Forms.ComboBox skladistecmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button procesirajbtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblvrijem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUdaljenost;
        private System.Windows.Forms.Label label7;
    }
}