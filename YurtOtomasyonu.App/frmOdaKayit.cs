using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu.App
{
    public partial class frmOdaKayit : Form
    {
        public frmOdaKayit()
        {
            InitializeComponent();
        }
        public int odaid = 0;
        void Temizle()
        {
            foreach (Control item in this.Controls["pnlTxt"].Controls)
            {
                item.Text = string.Empty;
            }
            odaid = 0;
            btnSil.Enabled = false;
            btnOdaKaydet.Text = "Kaydet";
        }
        
        private void btnOdaKaydet_Click(object sender, EventArgs e)
        {
            using (YurtContex ctx = new YurtContex())
            {
                try
                {
                    switch (odaid)
                    {
                        case 0:
                            ctx.Odas.Add(new Oda { Kat = Convert.ToInt32(txtKat.Text.Trim()), Kontenjan = Convert.ToInt32(txtKontenjan.Text.Trim()), Oda_No = Convert.ToInt32(txtOdaNo.Text.Trim()) });
                            
                            ctx.SaveChanges();
                            break;
                        default:
                            Oda oda = ctx.Odas.Find(odaid);
                            oda.Oda_No = Convert.ToInt32(txtOdaNo.Text.Trim());
                            oda.Kontenjan = Convert.ToInt32(txtKontenjan.Text.Trim());
                            oda.Kat = Convert.ToInt32(txtKat.Text.Trim());
                            ctx.Entry<Oda>(oda).State = EntityState.Modified;
                            ctx.SaveChanges();
                            Temizle();
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                {
                    using (YurtContex ctx = new YurtContex())
                    {

                        Oda oda = ctx.Odas.Find(odaid);
                        ctx.Odas.Remove(oda);
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("Silme Başarılı");
                    Temizle();
                }

            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
                Temizle();
            }
        }
    }
}