using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Yurt.DAL;
using Yurt.MODELS;
using System.Data;

namespace Yurt.BLL
{
   public class OdaBL:IDisposable
    {
        Helper hlp = new Helper();


        public bool Kaydet(Oda oda)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Oda_ID", oda.Oda_ID), new SqlParameter("@Oda_No", oda.Oda_No), new SqlParameter("@Kat", oda.Kat), new SqlParameter("@Kontenjan", oda.Kontenjan) };
                return hlp.ExecuteNonQuery("insert into Oda (Kat, Oda_No, Kontenjan) values(@Kat,@Oda_No, @Kontenjan)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Guncelle(Oda oda)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Oda_ID", oda.Oda_ID), new SqlParameter("@Oda_No", oda.Oda_No), new SqlParameter("@Kat", oda.Kat), new SqlParameter("@Kontenjan", oda.Kontenjan) };
                return hlp.ExecuteNonQuery("Update Ogrenciler set Oda_ID = @Oda_ID,soyad=@soyad,Oda_No=@Oda_No,Kat=@Kat,Kontenjan=@Kontenjan Where @Oda_ID=Oda_ID", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Oda> OdaListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Oda_ID, Kat, Oda_No, Kontenjan from Oda", null);
            List<Oda> lst = new List<Oda>();
            while (dr.Read())
            {
                lst.Add(new Oda { Oda_No = Convert.ToInt32(dr["Oda_No"]), Kat = Convert.ToInt32(dr["Kat"]), Oda_ID = Convert.ToInt32(dr["Oda_ID"]), Kontenjan = Convert.ToInt32(dr["Kontenjan"]) });
            }
            dr.Close();
            return lst;
        }
        public Oda OdaBul(string no)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Oda_No", no) };
                SqlDataReader dr = hlp.ExecuteReader("Select Oda_ID, Kat, Oda_No, Kontenjan from Oda Where Oda_No=@Oda_No", p);
                Oda oda = null;


                if (dr.Read())
                {
                    oda = new Oda();
                    oda.Oda_ID = Convert.ToInt32(dr["Oda_ID"]);
                    oda.Oda_No = Convert.ToInt32(dr["Oda_No"]);
                    oda.Kontenjan = Convert.ToInt32(dr["Kontenjan"]);
                    oda.Kat = Convert.ToInt32(dr["Kat"]);
                }
                dr.Close();
                return oda;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool OdaSil(int odaid)
        {
            SqlParameter[] p = { new SqlParameter("@Oda_Id", odaid) };
            return hlp.ExecuteNonQuery("Delete from Oda where Oda_Id=@Oda_Id", p) > 0;
        }
        public DataTable OdaTable() => hlp.GetDataTable("Select Oda_ID, Kat, Oda_No, Kontenjan from  Oda");
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
