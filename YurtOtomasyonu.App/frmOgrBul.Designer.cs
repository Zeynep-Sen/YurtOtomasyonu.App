namespace YurtOtomasyonu.App
{
    partial class frmOgrBul
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
            this.txt_Bul = new System.Windows.Forms.TextBox();
            this.btn_bul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulunucak öğrencinin Tc Kimlik Numarası";
            // 
            // txt_Bul
            // 
            this.txt_Bul.Location = new System.Drawing.Point(30, 82);
            this.txt_Bul.Name = "txt_Bul";
            this.txt_Bul.Size = new System.Drawing.Size(200, 20);
            this.txt_Bul.TabIndex = 1;
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(155, 117);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(75, 23);
            this.btn_bul.TabIndex = 2;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 204);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.txt_Bul);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Bul;
        private System.Windows.Forms.Button btn_bul;
    }
}