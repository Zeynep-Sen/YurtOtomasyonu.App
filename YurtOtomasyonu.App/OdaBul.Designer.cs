namespace YurtOtomasyonu.App
{
    partial class OdaBul
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaBul = new System.Windows.Forms.Button();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bulunacak Odanın Numarası";
            // 
            // btnOdaBul
            // 
            this.btnOdaBul.Location = new System.Drawing.Point(201, 105);
            this.btnOdaBul.Name = "btnOdaBul";
            this.btnOdaBul.Size = new System.Drawing.Size(75, 23);
            this.btnOdaBul.TabIndex = 2;
            this.btnOdaBul.Text = "Bul";
            this.btnOdaBul.UseVisualStyleBackColor = true;
            this.btnOdaBul.Click += new System.EventHandler(this.btnOdaBul_Click);
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(112, 54);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(121, 21);
            this.cmbOdalar.TabIndex = 3;
            // 
            // OdaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 159);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.btnOdaBul);
            this.Controls.Add(this.label1);
            this.Name = "OdaBul";
            this.Text = "OdaBul";
            this.Load += new System.EventHandler(this.OdaBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaBul;
        private System.Windows.Forms.ComboBox cmbOdalar;
    }
}