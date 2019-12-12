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
    public partial class frmOgrenciListele : Form
    {     DataTable dt;
        public frmOgrenciListele()
        {
            InitializeComponent();
            dgvOgrListele.AutoGenerateColumns = false;
        }

        private void frmOgrenciListele_Load(object sender, EventArgs e)
        {

            OgrenciBL obl = new OgrenciBL();
            dt = obl.OgrenciTable();
            dgvOgrListele.DataSource = dt;
            obl.Dispose();
            OkulBLL okl = new OkulBLL();
            clmOkul.DataSource = okl.OkulListesi();
            clmOkul.DisplayMember = "Okul_Ad";
            clmOkul.ValueMember = "Okul_Id";

            BolumBL bol = new BolumBL();
            clmBolum.DataSource = bol.BolumListesi();
            clmBolum.DisplayMember = "BolumAd";
            clmBolum.ValueMember = "BolumId";


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL ob = new OgrenciBL();

            foreach (DataRow item in dt.Rows)
            {

                Ogrenci ogr = new Ogrenci();
                if (item.RowState != DataRowState.Deleted)
                {
                   
                    ogr.ad = item[1].ToString();
                    ogr.soyad = item[2].ToString();
                   // ogr.okulId 4
                   //bölümü 5
                   //e posta 6
                    ogr.tc = item[3].ToString();
                    ogr.anneAd = item[7].ToString();
                    ogr.anneSoyad = item[8].ToString();
                    ogr.babaAd=item[9].ToString();
                    ogr.babaSoyad = item[10].ToString();
                    //telefon??
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ob.Kaydet(ogr);
                        break;
                    case DataRowState.Deleted:
                        ob.OgrenciSil(Convert.ToInt32(item[0, DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        ogr.ogrenciId = Convert.ToInt32(item[0]);
                        ob.Guncelle(ogr);
                        break;
                    default:
                        break;
                }
            }
        }
    }
    }

