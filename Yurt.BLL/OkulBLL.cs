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
    public class OkulBLL : IDisposable
    {
        Helper hlp = new Helper();

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

        public List<Okul> OkulListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Okul_ID, Okul_Ad from Okul", null);
            List<Okul> lst = new List<Okul>();
            while (dr.Read())
            {   
                lst.Add(new Okul { Okul_ID = Convert.ToInt32(dr["Okul_ID"]),  Okul_Ad= (string)dr["Okul_Ad"] });
            }
            dr.Close();
            return lst;
        }
    }
}
