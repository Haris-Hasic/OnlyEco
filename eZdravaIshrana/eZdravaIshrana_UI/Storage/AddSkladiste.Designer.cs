namespace eZdravaIshrana_UI.Storage
{
    partial class AddSkladiste
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivtxt = new System.Windows.Forms.TextBox();
            this.adresatxt = new System.Windows.Forms.TextBox();
            this.spasibtn = new System.Windows.Forms.Button();
            this.odstanibtn = new System.Windows.Forms.Button();
            this.opistxt = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // nazivtxt
            // 
            this.nazivtxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivtxt.Location = new System.Drawing.Point(616, 30);
            this.nazivtxt.Name = "nazivtxt";
            this.nazivtxt.Size = new System.Drawing.Size(153, 22);
            this.nazivtxt.TabIndex = 3;
            this.nazivtxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivtxt_Validating);
            // 
            // adresatxt
            // 
            this.adresatxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresatxt.Location = new System.Drawing.Point(616, 63);
            this.adresatxt.Name = "adresatxt";
            this.adresatxt.Size = new System.Drawing.Size(153, 22);
            this.adresatxt.TabIndex = 4;
            this.adresatxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresatxt_Validating);
            // 
            // spasibtn
            // 
            this.spasibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.spasibtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spasibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.spasibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spasibtn.Location = new System.Drawing.Point(666, 339);
            this.spasibtn.Name = "spasibtn";
            this.spasibtn.Size = new System.Drawing.Size(103, 45);
            this.spasibtn.TabIndex = 6;
            this.spasibtn.Text = "Spasi";
            this.spasibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spasibtn.UseVisualStyleBackColor = false;
            this.spasibtn.Click += new System.EventHandler(this.spasibtn_Click);
            // 
            // odstanibtn
            // 
            this.odstanibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.odstanibtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odstanibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.odstanibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odstanibtn.Location = new System.Drawing.Point(529, 339);
            this.odstanibtn.Name = "odstanibtn";
            this.odstanibtn.Size = new System.Drawing.Size(109, 45);
            this.odstanibtn.TabIndex = 7;
            this.odstanibtn.Text = "Odustani";
            this.odstanibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odstanibtn.UseVisualStyleBackColor = false;
            this.odstanibtn.Click += new System.EventHandler(this.odstanibtn_Click);
            // 
            // opistxt
            // 
            this.opistxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opistxt.Location = new System.Drawing.Point(616, 106);
            this.opistxt.Name = "opistxt";
            this.opistxt.Size = new System.Drawing.Size(153, 96);
            this.opistxt.TabIndex = 8;
            this.opistxt.Text = "";
            this.opistxt.Validating += new System.ComponentModel.CancelEventHandler(this.opistxt_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(476, 512);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.map.Size = new System.Drawing.Size(476, 512);
            this.map.TabIndex = 10;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // txtLng
            // 
            this.txtLng.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLng.Location = new System.Drawing.Point(616, 260);
            this.txtLng.Name = "txtLng";
            this.txtLng.ReadOnly = true;
            this.txtLng.Size = new System.Drawing.Size(153, 22);
            this.txtLng.TabIndex = 14;
            this.txtLng.Validating += new System.ComponentModel.CancelEventHandler(this.txtLng_Validating);
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(616, 227);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(153, 22);
            this.txtLat.TabIndex = 13;
            this.txtLat.Validating += new System.ComponentModel.CancelEventHandler(this.txtLat_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Latitude";
            // 
            // AddSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(841, 512);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.opistxt);
            this.Controls.Add(this.odstanibtn);
            this.Controls.Add(this.spasibtn);
            this.Controls.Add(this.adresatxt);
            this.Controls.Add(this.nazivtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddSkladiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija skladišta";
            this.Load += new System.EventHandler(this.AddSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivtxt;
        private System.Windows.Forms.TextBox adresatxt;
        private System.Windows.Forms.Button spasibtn;
        private System.Windows.Forms.Button odstanibtn;
        private System.Windows.Forms.RichTextBox opistxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Splitter splitter1;
    }
}