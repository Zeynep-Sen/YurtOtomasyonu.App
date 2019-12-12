namespace YurtOtomasyonu.App
{
    partial class frmOgrenciListele
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
            this.dgvOgrListele = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOkul = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBolum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmEposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnneAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnneSyd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBabaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBabaSyd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrListele
            // 
            this.dgvOgrListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmTc,
            this.clmOkul,
            this.clmBolum,
            this.clmEposta,
            this.clmAnneAd,
            this.clmAnneSyd,
            this.clmBabaAd,
            this.clmBabaSyd,
            this.clmOda});
            this.dgvOgrListele.Location = new System.Drawing.Point(12, 12);
            this.dgvOgrListele.Name = "dgvOgrListele";
            this.dgvOgrListele.Size = new System.Drawing.Size(1124, 216);
            this.dgvOgrListele.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(418, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(192, 74);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "ad";
            this.clmAd.HeaderText = "Öğrencinin Adı";
            this.clmAd.Name = "clmAd";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "soyad";
            this.clmSoyad.HeaderText = "Soyadı";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmTc
            // 
            this.clmTc.DataPropertyName = "tc";
            this.clmTc.HeaderText = "TC Kimlik Numarası";
            this.clmTc.Name = "clmTc";
            // 
            // clmOkul
            // 
            this.clmOkul.DataPropertyName = "Okul_Id";
            this.clmOkul.HeaderText = "Okulu";
            this.clmOkul.Name = "clmOkul";
            this.clmOkul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmOkul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmBolum
            // 
            this.clmBolum.DataPropertyName = "ad";
            this.clmBolum.HeaderText = "Bölümü";
            this.clmBolum.Name = "clmBolum";
            this.clmBolum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBolum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmEposta
            // 
            this.clmEposta.DataPropertyName = "ad";
            this.clmEposta.HeaderText = "E-Posta";
            this.clmEposta.Name = "clmEposta";
            // 
            // clmAnneAd
            // 
            this.clmAnneAd.DataPropertyName = "anneAd";
            this.clmAnneAd.HeaderText = "Anne Adı";
            this.clmAnneAd.Name = "clmAnneAd";
            // 
            // clmAnneSyd
            // 
            this.clmAnneSyd.DataPropertyName = "anneSoyad";
            this.clmAnneSyd.HeaderText = "Anne Soyadı";
            this.clmAnneSyd.Name = "clmAnneSyd";
            // 
            // clmBabaAd
            // 
            this.clmBabaAd.DataPropertyName = "babaAd";
            this.clmBabaAd.HeaderText = "Baba Adı";
            this.clmBabaAd.Name = "clmBabaAd";
            // 
            // clmBabaSyd
            // 
            this.clmBabaSyd.DataPropertyName = "babaSoyad";
            this.clmBabaSyd.HeaderText = "Baba Soyadı";
            this.clmBabaSyd.Name = "clmBabaSyd";
            // 
            // clmOda
            // 
            this.clmOda.DataPropertyName = "odaıd";
            this.clmOda.HeaderText = "Oda Numarası";
            this.clmOda.Name = "clmOda";
            // 
            // frmOgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 363);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvOgrListele);
            this.Name = "frmOgrenciListele";
            this.Text = "frmOgrenciListele";
            this.Load += new System.EventHandler(this.frmOgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTc;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmOkul;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmBolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnneAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnneSyd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBabaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBabaSyd;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmOda;
    }
}