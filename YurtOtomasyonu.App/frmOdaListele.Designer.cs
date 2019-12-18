namespace YurtOtomasyonu.App
{
    partial class frmOdaListele
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
            this.dgOda = new System.Windows.Forms.DataGridView();
            this.clmOdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKontenjan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOda
            // 
            this.dgOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOdaNo,
            this.clmKat,
            this.clmKontenjan});
            this.dgOda.Location = new System.Drawing.Point(12, 12);
            this.dgOda.Name = "dgOda";
            this.dgOda.Size = new System.Drawing.Size(558, 214);
            this.dgOda.TabIndex = 0;
            // 
            // clmOdaNo
            // 
            this.clmOdaNo.DataPropertyName = "Oda_No";
            this.clmOdaNo.HeaderText = "Oda Numarası";
            this.clmOdaNo.Name = "clmOdaNo";
            // 
            // clmKat
            // 
            this.clmKat.DataPropertyName = "Kat";
            this.clmKat.HeaderText = "Kat";
            this.clmKat.Name = "clmKat";
            // 
            // clmKontenjan
            // 
            this.clmKontenjan.DataPropertyName = "Kontenjan";
            this.clmKontenjan.HeaderText = "Kontenjan";
            this.clmKontenjan.Name = "clmKontenjan";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(315, 233);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOdaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 301);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgOda);
            this.Name = "frmOdaListele";
            this.Text = "frmOdaListele";
            this.Load += new System.EventHandler(this.frmOdaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOdaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKontenjan;
        private System.Windows.Forms.Button btnKaydet;
    }
}