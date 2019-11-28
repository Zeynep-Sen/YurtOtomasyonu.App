using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Yurt.DAL;
using Yurt.MODELS;

namespace Yurt.BLL
{
   public class OdaBL:IDisposable
    {
        Helper hlp = new Helper();

        

        public List<Oda> OdaListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Oda_ID, Kat, Oda_No, Kontenjan from Oda", null);
            List<Oda> lst = new List<Oda>();
            while (dr.Read())
            {
                lst.Add(new Oda { Oda_No=Convert.ToInt32(dr["Oda_No"]), Kat = Convert.ToInt32(dr["Kat"]),Oda_ID = Convert.ToInt32(dr["Oda_ID"]),Kontenjan = Convert.ToInt32(dr["Kontenjan"])});
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
