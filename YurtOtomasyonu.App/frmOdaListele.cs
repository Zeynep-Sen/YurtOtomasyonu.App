using Newtonsoft.Json;
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
    public partial class frmOdaListele : Form
    { YurtContex ctx = new YurtContex();
        public frmOdaListele()
        {
            InitializeComponent();
        }
       
        private void frmOdaListele_Load(object sender, EventArgs e)
        {
            
            List<Oda> lst = ctx.Odas.ToList();
            var json = JsonConvert.SerializeObject(lst);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            dgOda.DataSource = dt;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
