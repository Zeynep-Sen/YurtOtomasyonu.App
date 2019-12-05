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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrListele
            // 
            this.dgvOgrListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrListele.Location = new System.Drawing.Point(12, 12);
            this.dgvOgrListele.Name = "dgvOgrListele";
            this.dgvOgrListele.Size = new System.Drawing.Size(660, 209);
            this.dgvOgrListele.TabIndex = 0;
            // 
            // frmOgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 363);
            this.Controls.Add(this.dgvOgrListele);
            this.Name = "frmOgrenciListele";
            this.Text = "frmOgrenciListele";
            this.Load += new System.EventHandler(this.frmOgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrListele;
    }
}