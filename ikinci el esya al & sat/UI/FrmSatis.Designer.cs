namespace ikinci_el_esya_al___sat.UI
{
    partial class FrmSatis
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
            this.TXTURUN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTMUSTERI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTTARIH = new System.Windows.Forms.DateTimePicker();
            this.NMFIYAT = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NMFIYAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNIPTAL
            // 
            this.BTNIPTAL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNIPTAL.Location = new System.Drawing.Point(286, 191);
            this.BTNIPTAL.Name = "BTNIPTAL";
            this.BTNIPTAL.Size = new System.Drawing.Size(75, 23);
            this.BTNIPTAL.TabIndex = 6;
            this.BTNIPTAL.Text = "İPTAL";
            this.BTNIPTAL.UseVisualStyleBackColor = true;
            this.BTNIPTAL.Click += new System.EventHandler(this.BTNIPTAL_Click);
            // 
            // BTNTAMAM
            // 
            this.BTNTAMAM.Location = new System.Drawing.Point(205, 191);
            this.BTNTAMAM.Name = "BTNTAMAM";
            this.BTNTAMAM.Size = new System.Drawing.Size(75, 23);
            this.BTNTAMAM.TabIndex = 5;
            this.BTNTAMAM.Text = "TAMAM";
            this.BTNTAMAM.UseVisualStyleBackColor = true;
            this.BTNTAMAM.Click += new System.EventHandler(this.BTNTAMAM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "FİYAT";
            // 
            // TXTURUN
            // 
            this.TXTURUN.Location = new System.Drawing.Point(64, 86);
            this.TXTURUN.Name = "TXTURUN";
            this.TXTURUN.Size = new System.Drawing.Size(303, 22);
            this.TXTURUN.TabIndex = 2;
            this.TXTURUN.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÜRÜN";
            // 
            // TXTMUSTERI
            // 
            this.TXTMUSTERI.Location = new System.Drawing.Point(64, 61);
            this.TXTMUSTERI.Name = "TXTMUSTERI";
            this.TXTMUSTERI.ReadOnly = true;
            this.TXTMUSTERI.Size = new System.Drawing.Size(303, 22);
            this.TXTMUSTERI.TabIndex = 1;
            this.TXTMUSTERI.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(64, 33);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(303, 22);
            this.TXTID.TabIndex = 0;
            this.TXTID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TARİH";
            // 
            // DTTARIH
            // 
            this.DTTARIH.Location = new System.Drawing.Point(67, 145);
            this.DTTARIH.Name = "DTTARIH";
            this.DTTARIH.Size = new System.Drawing.Size(300, 22);
            this.DTTARIH.TabIndex = 4;
            // 
            // NMFIYAT
            // 
            this.NMFIYAT.Location = new System.Drawing.Point(67, 117);
            this.NMFIYAT.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NMFIYAT.Name = "NMFIYAT";
            this.NMFIYAT.Size = new System.Drawing.Size(300, 22);
            this.NMFIYAT.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSatis
            // 
            this.AcceptButton = this.BTNTAMAM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNIPTAL;
            this.ClientSize = new System.Drawing.Size(443, 303);
            this.Controls.Add(this.NMFIYAT);
            this.Controls.Add(this.DTTARIH);
            this.Controls.Add(this.BTNIPTAL);
            this.Controls.Add(this.BTNTAMAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTURUN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTMUSTERI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatis";
            ((System.ComponentModel.ISupportInitialize)(this.NMFIYAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIPTAL;
        private System.Windows.Forms.Button BTNTAMAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTURUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTMUSTERI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTTARIH;
        private System.Windows.Forms.NumericUpDown NMFIYAT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}