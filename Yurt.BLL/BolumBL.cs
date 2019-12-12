using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yurt.DAL;
using Yurt.MODELS;

namespace Yurt.BLL
{
   public class BolumBL:IDisposable
    {
        Helper hlp = new Helper();

       

        public List<Bolum> BolumListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select BolumId, BolumAd from Bolum", null);
            List<Bolum> lst = new List<Bolum>();
            while (dr.Read())
            {
                lst.Add(new Bolum { BolumId = Convert.ToInt32(dr["BolumId"]), BolumAd = (string)dr["BolumAd"] });
            }
            dr.Close();
            return lst;
        }
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
