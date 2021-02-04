namespace eZdravaIshrana_UI.Products
{
    partial class AddForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cijenaInput = new System.Windows.Forms.TextBox();
            this.proizvodjacCmb = new System.Windows.Forms.ComboBox();
            this.vrstaCmb = new System.Windows.Forms.ComboBox();
            this.SortaCmb = new System.Windows.Forms.ComboBox();
            this.slikaBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proizvodjač";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sorta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Slika";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(102, 24);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(141, 20);
            this.nazivInput.TabIndex = 10;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(102, 57);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(141, 20);
            this.sifraInput.TabIndex = 11;
            this.sifraInput.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(300, 41);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(177, 20);
            this.slikaInput.TabIndex = 13;
            this.slikaInput.Validating += new System.ComponentModel.CancelEventHandler(this.slikaInput_Validating);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.dodajBtn.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_checkmark_40;
            this.dodajBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajBtn.Location = new System.Drawing.Point(592, 189);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(104, 47);
            this.dodajBtn.TabIndex = 16;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(102, 92);
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(141, 20);
            this.cijenaInput.TabIndex = 18;
            this.cijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaInput_Validating);
            // 
            // proizvodjacCmb
            // 
            this.proizvodjacCmb.FormattingEnabled = true;
            this.proizvodjacCmb.Location = new System.Drawing.Point(102, 134);
            this.proizvodjacCmb.Name = "proizvodjacCmb";
            this.proizvodjacCmb.Size = new System.Drawing.Size(141, 21);
            this.proizvodjacCmb.TabIndex = 19;
            this.proizvodjacCmb.Validating += new System.ComponentModel.CancelEventHandler(this.proizvodjacCmb_Validating_1);
            // 
            // vrstaCmb
            // 
            this.vrstaCmb.FormattingEnabled = true;
            this.vrstaCmb.Location = new System.Drawing.Point(102, 176);
            this.vrstaCmb.Name = "vrstaCmb";
            this.vrstaCmb.Size = new System.Drawing.Size(141, 21);
            this.vrstaCmb.TabIndex = 20;
            this.vrstaCmb.SelectedIndexChanged += new System.EventHandler(this.vrstaCmb_SelectedIndexChanged);
            this.vrstaCmb.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaCmb_Validating);
            // 
            // SortaCmb
            // 
            this.SortaCmb.FormattingEnabled = true;
            this.SortaCmb.Location = new System.Drawing.Point(102, 215);
            this.SortaCmb.Name = "SortaCmb";
            this.SortaCmb.Size = new System.Drawing.Size(141, 21);
            this.SortaCmb.TabIndex = 21;
            this.SortaCmb.Validating += new System.ComponentModel.CancelEventHandler(this.SortaCmb_Validating);
            // 
            // slikaBtn
            // 
            this.slikaBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.slikaBtn.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_add_image_30;
            this.slikaBtn.Location = new System.Drawing.Point(429, 67);
            this.slikaBtn.Name = "slikaBtn";
            this.slikaBtn.Size = new System.Drawing.Size(48, 30);
            this.slikaBtn.TabIndex = 15;
            this.slikaBtn.UseVisualStyleBackColor = false;
            this.slikaBtn.Click += new System.EventHandler(this.slikaBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(576, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::eZdravaIshrana_UI.Properties.Resources.icons8_xbox_x_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(443, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "Odustani";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(249, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Dodaj sortu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortaCmb);
            this.Controls.Add(this.vrstaCmb);
            this.Controls.Add(this.proizvodjacCmb);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.slikaBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi proizvod";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button slikaBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox cijenaInput;
        private System.Windows.Forms.ComboBox proizvodjacCmb;
        private System.Windows.Forms.ComboBox SortaCmb;
        private System.Windows.Forms.ComboBox vrstaCmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}