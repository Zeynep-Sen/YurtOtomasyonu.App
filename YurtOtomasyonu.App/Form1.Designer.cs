namespace YurtOtomasyonu.App
{
    partial class frmAnasayfa
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
            this.btn_OgrenciKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OgrenciKayit
            // 
            this.btn_OgrenciKayit.Location = new System.Drawing.Point(12, 82);
            this.btn_OgrenciKayit.Name = "btn_OgrenciKayit";
            this.btn_OgrenciKayit.Size = new System.Drawing.Size(206, 57);
            this.btn_OgrenciKayit.TabIndex = 0;
            this.btn_OgrenciKayit.Text = "Öğrenci Kayıt";
            this.btn_OgrenciKayit.UseVisualStyleBackColor = true;
            this.btn_OgrenciKayit.Click += new System.EventHandler(this.btn_OgrenciKayit_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 546);
            this.Controls.Add(this.btn_OgrenciKayit);
            this.Name = "frmAnasayfa";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OgrenciKayit;
    }
}

