namespace YurtOtomasyonu.App
{
    partial class frmOdaKayit
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
            this.txtOdaNo = new YurtConrolLib.MyTextBox();
            this.txtKat = new YurtConrolLib.MyTextBox();
            this.txtKontenjan = new YurtConrolLib.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdaKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlTxt = new System.Windows.Forms.Panel();
            this.pnlTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.CalismaModu = YurtConrolLib.WorkMode.Normal;
            this.txtOdaNo.Location = new System.Drawing.Point(3, 15);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(189, 20);
            this.txtOdaNo.TabIndex = 0;
            // 
            // txtKat
            // 
            this.txtKat.CalismaModu = YurtConrolLib.WorkMode.Normal;
            this.txtKat.Location = new System.Drawing.Point(3, 91);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(189, 20);
            this.txtKat.TabIndex = 1;
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.CalismaModu = YurtConrolLib.WorkMode.Normal;
            this.txtKontenjan.Location = new System.Drawing.Point(3, 54);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(189, 20);
            this.txtKontenjan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oda No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kontenjan";
            // 
            // btnOdaKaydet
            // 
            this.btnOdaKaydet.Location = new System.Drawing.Point(278, 170);
            this.btnOdaKaydet.Name = "btnOdaKaydet";
            this.btnOdaKaydet.Size = new System.Drawing.Size(75, 40);
            this.btnOdaKaydet.TabIndex = 6;
            this.btnOdaKaydet.Text = "Kaydet";
            this.btnOdaKaydet.UseVisualStyleBackColor = true;
            this.btnOdaKaydet.Click += new System.EventHandler(this.btnOdaKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(278, 216);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pnlTxt
            // 
            this.pnlTxt.Controls.Add(this.txtOdaNo);
            this.pnlTxt.Controls.Add(this.txtKat);
            this.pnlTxt.Controls.Add(this.txtKontenjan);
            this.pnlTxt.Location = new System.Drawing.Point(106, 31);
            this.pnlTxt.Name = "pnlTxt";
            this.pnlTxt.Size = new System.Drawing.Size(215, 123);
            this.pnlTxt.TabIndex = 8;
            // 
            // frmOdaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 311);
            this.Controls.Add(this.pnlTxt);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOdaKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOdaKayit";
            this.Text = "frmOdaKayit";
            this.pnlTxt.ResumeLayout(false);
            this.pnlTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public YurtConrolLib.MyTextBox txtOdaNo;
        public YurtConrolLib.MyTextBox txtKat;
        public YurtConrolLib.MyTextBox txtKontenjan;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnOdaKaydet;
        private System.Windows.Forms.Panel pnlTxt;
    }
}