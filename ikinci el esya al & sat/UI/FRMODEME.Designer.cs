namespace ikinci_el_esya_al___sat.UI
{
    partial class FRMODEME
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
            this.DTTARIH = new System.Windows.Forms.DateTimePicker();
            this.BTNIPTAL = new System.Windows.Forms.Button();
            this.BTNTAMAM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NMTUTAR = new System.Windows.Forms.Label();
            this.TXTMUSTERI = new System.Windows.Forms.TextBox();
            this.TXTMUSTERİ = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTACIKLAMA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBODEMETURU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NMTUTARR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMTUTARR)).BeginInit();
            this.SuspendLayout();
            // 
            // DTTARIH
            // 
            this.DTTARIH.Location = new System.Drawing.Point(115, 124);
            this.DTTARIH.Name = "DTTARIH";
            this.DTTARIH.Size = new System.Drawing.Size(300, 22);
            this.DTTARIH.TabIndex = 3;
            // 
            // BTNIPTAL
            // 
            this.BTNIPTAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNIPTAL.Location = new System.Drawing.Point(344, 325);
            this.BTNIPTAL.Name = "BTNIPTAL";
            this.BTNIPTAL.Size = new System.Drawing.Size(75, 31);
            this.BTNIPTAL.TabIndex = 7;
            this.BTNIPTAL.Text = "İPTAL";
            this.BTNIPTAL.UseVisualStyleBackColor = true;
            this.BTNIPTAL.Click += new System.EventHandler(this.BTNIPTAL_Click);
            // 
            // BTNTAMAM
            // 
            this.BTNTAMAM.Location = new System.Drawing.Point(263, 325);
            this.BTNTAMAM.Name = "BTNTAMAM";
            this.BTNTAMAM.Size = new System.Drawing.Size(75, 31);
            this.BTNTAMAM.TabIndex = 6;
            this.BTNTAMAM.Text = "TAMAM";
            this.BTNTAMAM.UseVisualStyleBackColor = true;
            this.BTNTAMAM.Click += new System.EventHandler(this.BTNTAMAM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tarih";
            // 
            // NMTUTAR
            // 
            this.NMTUTAR.AutoSize = true;
            this.NMTUTAR.Location = new System.Drawing.Point(60, 99);
            this.NMTUTAR.Name = "NMTUTAR";
            this.NMTUTAR.Size = new System.Drawing.Size(38, 16);
            this.NMTUTAR.TabIndex = 21;
            this.NMTUTAR.Text = "Tutar";
            // 
            // TXTMUSTERI
            // 
            this.TXTMUSTERI.Location = new System.Drawing.Point(112, 68);
            this.TXTMUSTERI.Name = "TXTMUSTERI";
            this.TXTMUSTERI.ReadOnly = true;
            this.TXTMUSTERI.Size = new System.Drawing.Size(303, 22);
            this.TXTMUSTERI.TabIndex = 1;
            this.TXTMUSTERI.TabStop = false;
            // 
            // TXTMUSTERİ
            // 
            this.TXTMUSTERİ.AutoSize = true;
            this.TXTMUSTERİ.Location = new System.Drawing.Point(48, 74);
            this.TXTMUSTERİ.Name = "TXTMUSTERİ";
            this.TXTMUSTERİ.Size = new System.Drawing.Size(50, 16);
            this.TXTMUSTERİ.TabIndex = 23;
            this.TXTMUSTERİ.Text = "Müşteri";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(112, 40);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(303, 22);
            this.TXTID.TabIndex = 0;
            this.TXTID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // TXTACIKLAMA
            // 
            this.TXTACIKLAMA.Location = new System.Drawing.Point(115, 212);
            this.TXTACIKLAMA.Multiline = true;
            this.TXTACIKLAMA.Name = "TXTACIKLAMA";
            this.TXTACIKLAMA.Size = new System.Drawing.Size(304, 97);
            this.TXTACIKLAMA.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Açıklama";
            // 
            // CBODEMETURU
            // 
            this.CBODEMETURU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBODEMETURU.FormattingEnabled = true;
            this.CBODEMETURU.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Banka Kartı",
            "Banka Ödemesi"});
            this.CBODEMETURU.Location = new System.Drawing.Point(115, 164);
            this.CBODEMETURU.Name = "CBODEMETURU";
            this.CBODEMETURU.Size = new System.Drawing.Size(304, 24);
            this.CBODEMETURU.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "ödeme türü";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NMTUTARR
            // 
            this.NMTUTARR.Location = new System.Drawing.Point(115, 92);
            this.NMTUTARR.Name = "NMTUTARR";
            this.NMTUTARR.Size = new System.Drawing.Size(304, 22);
            this.NMTUTARR.TabIndex = 29;
            // 
            // FRMODEME
            // 
            this.AcceptButton = this.BTNTAMAM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNIPTAL;
            this.ClientSize = new System.Drawing.Size(522, 417);
            this.Controls.Add(this.NMTUTARR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBODEMETURU);
            this.Controls.Add(this.TXTACIKLAMA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTTARIH);
            this.Controls.Add(this.BTNIPTAL);
            this.Controls.Add(this.BTNTAMAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NMTUTAR);
            this.Controls.Add(this.TXTMUSTERI);
            this.Controls.Add(this.TXTMUSTERİ);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMODEME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMODEME";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMTUTARR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DTTARIH;
        private System.Windows.Forms.Button BTNIPTAL;
        private System.Windows.Forms.Button BTNTAMAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NMTUTAR;
        private System.Windows.Forms.TextBox TXTMUSTERI;
        private System.Windows.Forms.Label TXTMUSTERİ;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTACIKLAMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBODEMETURU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown NMTUTARR;
    }
}