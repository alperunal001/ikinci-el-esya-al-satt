namespace ikinci_el_esya_al___sat.UI
{
    partial class FRMURUN
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
            this.BTNIPTAL = new System.Windows.Forms.Button();
            this.BTNTAMAM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTRENK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTMODEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTMARKA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CINS = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCINS = new System.Windows.Forms.ComboBox();
            this.NMFIYAT = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NMFIYAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNIPTAL
            // 
            this.BTNIPTAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNIPTAL.Location = new System.Drawing.Point(327, 227);
            this.BTNIPTAL.Name = "BTNIPTAL";
            this.BTNIPTAL.Size = new System.Drawing.Size(75, 23);
            this.BTNIPTAL.TabIndex = 7;
            this.BTNIPTAL.Text = "İPTAL";
            this.BTNIPTAL.UseVisualStyleBackColor = true;
            this.BTNIPTAL.Click += new System.EventHandler(this.BTNIPTAL_Click);
            // 
            // BTNTAMAM
            // 
            this.BTNTAMAM.Location = new System.Drawing.Point(246, 227);
            this.BTNTAMAM.Name = "BTNTAMAM";
            this.BTNTAMAM.Size = new System.Drawing.Size(75, 23);
            this.BTNTAMAM.TabIndex = 6;
            this.BTNTAMAM.Text = "TAMAM";
            this.BTNTAMAM.UseVisualStyleBackColor = true;
            this.BTNTAMAM.Click += new System.EventHandler(this.BTNTAMAM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "RENK";
            // 
            // TXTRENK
            // 
            this.TXTRENK.Location = new System.Drawing.Point(141, 145);
            this.TXTRENK.Name = "TXTRENK";
            this.TXTRENK.Size = new System.Drawing.Size(261, 22);
            this.TXTRENK.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "FİYAT";
            // 
            // TXTMODEL
            // 
            this.TXTMODEL.Location = new System.Drawing.Point(141, 117);
            this.TXTMODEL.Name = "TXTMODEL";
            this.TXTMODEL.Size = new System.Drawing.Size(261, 22);
            this.TXTMODEL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "MODEL";
            // 
            // TXTMARKA
            // 
            this.TXTMARKA.Location = new System.Drawing.Point(141, 89);
            this.TXTMARKA.Name = "TXTMARKA";
            this.TXTMARKA.Size = new System.Drawing.Size(261, 22);
            this.TXTMARKA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "MARKA";
            // 
            // CINS
            // 
            this.CINS.AutoSize = true;
            this.CINS.Location = new System.Drawing.Point(75, 64);
            this.CINS.Name = "CINS";
            this.CINS.Size = new System.Drawing.Size(38, 16);
            this.CINS.TabIndex = 11;
            this.CINS.Text = "CİNS";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(141, 30);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(261, 22);
            this.TXTID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // CBCINS
            // 
            this.CBCINS.FormattingEnabled = true;
            this.CBCINS.Items.AddRange(new object[] {
            "Araba",
            "Beyaz eşya",
            "Elektronik",
            "Telefon",
            "Bebek ve çocuk",
            "Spor ve outdoor",
            "Motorsiklet"});
            this.CBCINS.Location = new System.Drawing.Point(141, 61);
            this.CBCINS.Name = "CBCINS";
            this.CBCINS.Size = new System.Drawing.Size(258, 24);
            this.CBCINS.TabIndex = 1;
            // 
            // NMFIYAT
            // 
            this.NMFIYAT.Location = new System.Drawing.Point(141, 180);
            this.NMFIYAT.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NMFIYAT.Name = "NMFIYAT";
            this.NMFIYAT.Size = new System.Drawing.Size(261, 22);
            this.NMFIYAT.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMURUN
            // 
            this.AcceptButton = this.BTNTAMAM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNIPTAL;
            this.ClientSize = new System.Drawing.Size(471, 337);
            this.Controls.Add(this.NMFIYAT);
            this.Controls.Add(this.CBCINS);
            this.Controls.Add(this.BTNIPTAL);
            this.Controls.Add(this.BTNTAMAM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTRENK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTMODEL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTMARKA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CINS);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMURUN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMURUN";
            ((System.ComponentModel.ISupportInitialize)(this.NMFIYAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIPTAL;
        private System.Windows.Forms.Button BTNTAMAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTRENK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTMODEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTMARKA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CINS;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBCINS;
        private System.Windows.Forms.NumericUpDown NMFIYAT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}