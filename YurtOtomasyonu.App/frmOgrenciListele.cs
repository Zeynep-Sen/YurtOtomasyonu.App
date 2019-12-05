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

namespace YurtOtomasyonu.App
{
    public partial class frmOgrenciListele : Form
    {
        public frmOgrenciListele()
        {
            InitializeComponent();
        }

        private void frmOgrenciListele_Load(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            dgvOgrListele.DataSource = obl.OgrenciTable();
            obl.Dispose();
        }
    }
}
