namespace eZdravaIshrana_UI
{
    partial class LoginForm
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
            this.lozinkatxt = new System.Windows.Forms.TextBox();
            this.korisnickoimetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.odustanibtn = new System.Windows.Forms.Button();
            this.privajabtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lozinkatxt
            // 
            this.lozinkatxt.Location = new System.Drawing.Point(146, 85);
            this.lozinkatxt.Name = "lozinkatxt";
            this.lozinkatxt.PasswordChar = '*';
            this.lozinkatxt.Size = new System.Drawing.Size(182, 20);
            this.lozinkatxt.TabIndex = 13;
            // 
            // korisnickoimetxt
            // 
            this.korisnickoimetxt.Location = new System.Drawing.Point(146, 35);
            this.korisnickoimetxt.Name = "korisnickoimetxt";
            this.korisnickoimetxt.Size = new System.Drawing.Size(182, 20);
            this.korisnickoimetxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Korisničko ime:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eZdravaIshrana_UI.Properties.Resources.cef9c8ec_60ca_4abe_9618_9d541b230a5f_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(27, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // odustanibtn
            // 
            this.odustanibtn.BackColor = System.Drawing.Color.AliceBlue;
            this.odustanibtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odustanibtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_delete_30;
            this.odustanibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odustanibtn.Location = new System.Drawing.Point(120, 160);
            this.odustanibtn.Name = "odustanibtn";
            this.odustanibtn.Size = new System.Drawing.Size(112, 56);
            this.odustanibtn.TabIndex = 15;
            this.odustanibtn.Text = "Poništi";
            this.odustanibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odustanibtn.UseVisualStyleBackColor = false;
            this.odustanibtn.Click += new System.EventHandler(this.odustanibtn_Click);
            // 
            // privajabtn
            // 
            this.privajabtn.BackColor = System.Drawing.Color.AliceBlue;
            this.privajabtn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privajabtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.privajabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.privajabtn.Location = new System.Drawing.Point(252, 160);
            this.privajabtn.Name = "privajabtn";
            this.privajabtn.Size = new System.Drawing.Size(111, 56);
            this.privajabtn.TabIndex = 14;
            this.privajabtn.Text = "Prijava";
            this.privajabtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.privajabtn.UseVisualStyleBackColor = false;
            this.privajabtn.Click += new System.EventHandler(this.privajabtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.privajabtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.odustanibtn);
            this.groupBox1.Controls.Add(this.korisnickoimetxt);
            this.groupBox1.Controls.Add(this.lozinkatxt);
            this.groupBox1.Location = new System.Drawing.Point(293, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 249);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijava";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox lozinkatxt;
        private System.Windows.Forms.TextBox korisnickoimetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button privajabtn;
        private System.Windows.Forms.Button odustanibtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}