using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.BLL;
using Yurt.MODELS;

namespace YurtOtomasyonu.App
{
    public partial class frmOgrKayit : Form
    {
        public int ogrenciId = 0;
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = new Ogrenci();
            ogr.ad = txt_Ad.Text.Trim();
            ogr.soyad = txt_Soyad.Text.Trim();
            ogr.ogrenciId = ogrenciId;
            ogr.tc = txt_Tc.Text.Trim();
            ogr.anneAd = txt_AnneAdi.Text.Trim();
            ogr.anneSoyad = txt_AnneSoy.Text.Trim();
            ogr.babaAd = txt_BabaAdi.Text.Trim();
            ogr.babaSoyad = txt_BabaSoy.Text.Trim();
            obl.Kaydet(ogr);
            switch (ogrenciId)
            {
                case 0:
                    if (obl.Kaydet(ogr))
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        
                    }
                    else
                    {
                        MessageBox.Show("Yeniden Deneyiniz!!");
                    }

                    break;
                default:
                    if (obl.Guncelle(ogr))
                    {
                        
                        MessageBox.Show("Güncelleme Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız!");
                    }
                    break;
            }
            obl.Kaydet(ogr);


        }

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {
            OdaBL ob = new OdaBL();
            cmb_Oda.DisplayMember = "Oda_No";
            cmb_Oda.ValueMember = "Oda_Id";
            cmb_Oda.DataSource = ob.OdaListesi();
            
        }

        private void btn_ogrBul_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul(this);
            frm.Show();


        }
    }
}
