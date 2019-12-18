using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu.App
{
    public partial class OdaBul : Form
    {

        public OdaBul()
        {
            InitializeComponent();
        }
        YurtContex ctx = new YurtContex();
        
        private void btnOdaBul_Click(object sender, EventArgs e)
        {



            try
            {   
                using (YurtContex ctx = new YurtContex())
                {
                    Oda o = ctx.Odas.Find(Convert.ToInt32(cmbOdalar.SelectedValue));
                    frmOdaKayit odk = new frmOdaKayit();
                    odk.Show();
                    odk.txtKat.Text = o.Kat.ToString();
                    odk.txtOdaNo.Text = o.Oda_No.ToString();
                    odk.txtKontenjan.Text = o.Kontenjan.ToString();
                    odk.btnSil.Enabled = true;
                    odk.odaid = o.Oda_ID;
                    odk.btnOdaKaydet.Text = "Guncelle";
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void OdaBul_Load(object sender, EventArgs e)
        {

            List<Oda> lst = ctx.Odas.ToList();
            cmbOdalar.DataSource = lst;
            cmbOdalar.DisplayMember = "Oda_No";
            cmbOdalar.ValueMember = "Oda_Id";
        }
    }
}
