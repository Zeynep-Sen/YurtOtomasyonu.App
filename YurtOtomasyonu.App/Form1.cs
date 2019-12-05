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
        frmOgrKayit frm;
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        public frmAnasayfa(frmOgrKayit frm)
        {
            this.frm = frm;
        }

        private void btn_OgrenciKayit_Click(object sender, EventArgs e)
        {
            frmOgrKayit frm = new frmOgrKayit();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void ogrenciKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrKayit frm = new frmOgrKayit();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ogrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Form1 açık olmayacak hocaya sor!!
            
            frmOgrBul frm = new frmOgrBul();
            
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ogrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciListele frm = new frmOgrenciListele();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
