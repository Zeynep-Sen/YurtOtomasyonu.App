using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yurt.BLL;
using Yurt.MODELS;

namespace YurtOtomasyonu.App
{
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm;
        public frmOgrBul()
        {
            InitializeComponent();
        }
        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void btn_bul_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(frm.txt_Tc.Text.Trim());
            if (ogr == null)
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }
            else
            {   
                frm.txt_Ad.Text = ogr.ad;
                frm.txt_Soyad.Text = ogr.soyad;
                frm.txt_AnneAdi.Text = ogr.anneAd;
                frm.txt_AnneSoy.Text = ogr.anneSoyad;
                frm.txt_BabaAdi.Text = ogr.babaAd;
                frm.txt_BabaSoy.Text = ogr.babaSoyad;
                frm.txt_Tc.Text= ogr.tc;
                frm.ogrenciId = ogr.ogrenciId;
               // frm.cmb_Oda.SelectedValue = ;
                //frm.btnVazgec.Visible = true;
               // frm.btnKaydet.Text = "Güncelle";
                //frm.btnSil.Visible = true;
            }
        }
    }
}
