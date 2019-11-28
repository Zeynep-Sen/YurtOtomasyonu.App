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
    public class OgrenciBL
    {
        Helper hlp = new Helper();
        public bool Kaydet(Ogrenci ogr)


        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ad", ogr.ad), new SqlParameter("@soyad", ogr.soyad), new SqlParameter("@tc", ogr.tc), new SqlParameter("@AnneAd", ogr.anneAd), new SqlParameter("@anneSoyad", ogr.anneSoyad), new SqlParameter("@babaAd", ogr.babaAd), new SqlParameter("@babaSoyad", ogr.babaSoyad), new SqlParameter("@okulId", ogr.okulId), new SqlParameter("@iletisimId", ogr.iletisimId) };
                return hlp.ExecuteNonQuery("insert into Ogrenciler(ad,soyad,tc,anneAd,anneSoyad,babaAd,babaSoyad)  values(@ad,@soyad,@tc,@anneAd,@anneSoyad,@babaAd,@babaSoyad)", p) > 0;
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
        public bool Guncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ad", ogr.ad), new SqlParameter("@soyad", ogr.soyad), new SqlParameter("@tc", ogr.tc), new SqlParameter("@AnneAd", ogr.anneAd), new SqlParameter("@anneSoyad", ogr.anneSoyad), new SqlParameter("@babaAd", ogr.babaAd), new SqlParameter("@ogrenciId", ogr.ogrenciId), new SqlParameter("@babaSoyad", ogr.babaSoyad) };
                return hlp.ExecuteNonQuery("Update Ogrenciler set ad=@ad,soyad=@soyad,tc=@tc,=anneAd=@anneAd,anneSoyad=@anneSoyad,babaAd=@babaAd,babaSoyad=@,babaSoyad Where @ogrenciId=ogrenciId", p) > 0;
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
        public Ogrenci OgrenciBul(string Tc)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@tc", Tc) };
                SqlDataReader dr = hlp.ExecuteReader("Select ogrenciId, ad, soyad, tc, anneAd, anneSoyad, babaAd, babaSoyad from Ogrenciler Where tc=@tc", p);
                Ogrenci ogr = null;


                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.ad = dr["ad"].ToString();
                    ogr.soyad = dr["soyad"].ToString();
                    ogr.tc = dr["tc"].ToString(); ;
                    ogr.ogrenciId = Convert.ToInt32(dr["ogrenciId"]);
                    ogr.anneAd = dr["anneAd"].ToString();
                    ogr.babaAd = dr["babaAd"].ToString();
                    ogr.anneSoyad = dr["anneSoyad"].ToString();
                    ogr.babaSoyad = dr["babaSoyad"].ToString();

                }
                dr.Close();
                return ogr;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
