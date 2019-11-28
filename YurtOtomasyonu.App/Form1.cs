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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btn_OgrenciKayit_Click(object sender, EventArgs e)
        {
            frmOgrKayit frm = new frmOgrKayit();
            frm.Show();
            
        }

    }
}
