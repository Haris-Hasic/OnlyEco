namespace eZdravaIshrana_UI.Supply
{
    partial class NabavkaEdit
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
            this.datumtp = new System.Windows.Forms.DateTimePicker();
            this.brojfaktureinput = new System.Windows.Forms.TextBox();
            this.Skladistecmb = new System.Windows.Forms.ComboBox();
            this.dobavljaccmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spasibtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datumtp
            // 
            this.datumtp.Location = new System.Drawing.Point(117, 53);
            this.datumtp.Name = "datumtp";
            this.datumtp.Size = new System.Drawing.Size(200, 20);
            this.datumtp.TabIndex = 0;
            this.datumtp.Value = new System.DateTime(2020, 9, 22, 2, 21, 39, 0);
            // 
            // brojfaktureinput
            // 
            this.brojfaktureinput.Location = new System.Drawing.Point(117, 25);
            this.brojfaktureinput.Name = "brojfaktureinput";
            this.brojfaktureinput.Size = new System.Drawing.Size(200, 20);
            this.brojfaktureinput.TabIndex = 1;
            this.brojfaktureinput.Validating += new System.ComponentModel.CancelEventHandler(this.brojfaktureinput_Validating);
            // 
            // Skladistecmb
            // 
            this.Skladistecmb.FormattingEnabled = true;
            this.Skladistecmb.Location = new System.Drawing.Point(117, 83);
            this.Skladistecmb.Name = "Skladistecmb";
            this.Skladistecmb.Size = new System.Drawing.Size(200, 21);
            this.Skladistecmb.TabIndex = 2;
            this.Skladistecmb.Validating += new System.ComponentModel.CancelEventHandler(this.Skladistecmb_Validating);
            // 
            // dobavljaccmb
            // 
            this.dobavljaccmb.FormattingEnabled = true;
            this.dobavljaccmb.Location = new System.Drawing.Point(117, 110);
            this.dobavljaccmb.Name = "dobavljaccmb";
            this.dobavljaccmb.Size = new System.Drawing.Size(200, 21);
            this.dobavljaccmb.TabIndex = 3;
            this.dobavljaccmb.Validating += new System.ComponentModel.CancelEventHandler(this.dobavljaccmb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj fakture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skladiste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dobavljac";
            // 
            // spasibtn
            // 
            this.spasibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.spasibtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spasibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.spasibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spasibtn.Location = new System.Drawing.Point(222, 151);
            this.spasibtn.Name = "spasibtn";
            this.spasibtn.Size = new System.Drawing.Size(100, 46);
            this.spasibtn.TabIndex = 8;
            this.spasibtn.Text = "Spasi";
            this.spasibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spasibtn.UseVisualStyleBackColor = false;
            this.spasibtn.Click += new System.EventHandler(this.spasibtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.odustaniBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustaniBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.odustaniBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odustaniBtn.Location = new System.Drawing.Point(96, 151);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(109, 46);
            this.odustaniBtn.TabIndex = 9;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odustaniBtn.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // NabavkaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(355, 234);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.spasibtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dobavljaccmb);
            this.Controls.Add(this.Skladistecmb);
            this.Controls.Add(this.brojfaktureinput);
            this.Controls.Add(this.datumtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NabavkaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editivanje nabavke";
            this.Load += new System.EventHandler(this.NabavkaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumtp;
        private System.Windows.Forms.TextBox brojfaktureinput;
        private System.Windows.Forms.ComboBox Skladistecmb;
        private System.Windows.Forms.ComboBox dobavljaccmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button spasibtn;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}