using BilgiOtelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace BilgiOtelDal
{
    public class musterilerDal
    {
        // YENİ MUSTERİ EKLEME
        public int musteriekleme(musteriler eklenenmusteri)
        {
            SqlParameter[] eklenen =
                {
                new SqlParameter
                    {
                    ParameterName="MusteriAd",
                    Value=eklenenmusteri.MusteriAd
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriSoyad",
                    Value=eklenenmusteri.MusteriSoyad
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriTCKimlik",
                    Value=eklenenmusteri.MusteriTCKimlik
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriPasaportNo",
                    Value=eklenenmusteri.MusteriPasaportNo
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriUnvan",
                    Value=eklenenmusteri.MusteriUnvan
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value=eklenenmusteri.MusteriYetkiliAdSoyad
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriVergiNo",
                    Value=eklenenmusteri.MusteriVergiNo
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriVergiDairesi",
                    Value=eklenenmusteri.MusteriVergiDairesi
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriTelefon",
                    Value=eklenenmusteri.MusteriTelefon
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriPosta",
                    Value=eklenenmusteri.MusteriPosta
                    },
                 new SqlParameter
                    {
                    ParameterName="MusteriAdres",
                    Value=eklenenmusteri.MusteriAdres
                    },
                  new SqlParameter
                    {
                    ParameterName="IlID",
                    Value=eklenenmusteri.IlID
                    },
                   new SqlParameter
                    {
                    ParameterName="IlceID",
                    Value=eklenenmusteri.IlceID
                    },
                    new SqlParameter
                    {
                    ParameterName="UlkeID",
                    Value=eklenenmusteri.UlkeID
                    },
                     new SqlParameter
                    {
                    ParameterName="MusteriAciklama",
                    Value=eklenenmusteri.MusteriAciklama
                    },
                      new SqlParameter
                    {
                    ParameterName="MusteriKurumsalOK",
                    Value=eklenenmusteri.MusteriKurumsalOK
                    },
                       new SqlParameter
                    {
                    ParameterName="DilID",
                    Value=eklenenmusteri.DilID
                    },


                };

            int eklenensatir =  BilgiOtelHelperSql.myExecuteNonquery("sp_musteri_Ekle", eklenen ,"sp");
            return eklenensatir;
        }

        // TÜM MUSTERİLERİ GETİRME
        public List<musteriler> musterigetir()
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("select * from tbl_Musteriler", null,"txt");
            List<musteriler> tummusteriler = new List<musteriler>();
            while (dr.Read())
            {
                musteriler sonmusteri = new musteriler();
                sonmusteri.MusteriID = Convert.ToInt32(dr["MusteriID"]);
                sonmusteri.MusteriAd = dr["MusteriAd"].ToString();
                sonmusteri.MusteriSoyad = dr["MusteriSoyad"].ToString();
                sonmusteri.MusteriTCKimlik = dr["MusteriTCKimlik"].ToString();
                sonmusteri.MusteriPasaportNo =dr["MusteriPasaportNo"].ToString();
                sonmusteri.MusteriUnvan = dr["MusteriUnvan"].ToString();
                sonmusteri.MusteriYetkiliAdSoyad =dr["MusteriYetkiliAdSoyad"].ToString();
                sonmusteri.MusteriVergiNo = dr["MusteriVergiNo"].ToString();
                sonmusteri.MusteriVergiDairesi = dr["MusteriVergiDairesi"].ToString();
                sonmusteri.MusteriTelefon = dr["MusteriTelefon"].ToString();
                sonmusteri.MusteriPosta = dr["MusteriPosta"].ToString();
                sonmusteri.MusteriAdres = dr["MusteriAdres"].ToString();
                sonmusteri.IlID = Convert.ToInt32(dr["IlID"]);
                sonmusteri.IlceID = Convert.ToInt32(dr["IlceID"]);
                sonmusteri.UlkeID = Convert.ToInt32(dr["UlkeID"]);
                sonmusteri.MusteriAciklama = dr["MusteriAciklama"].ToString();
                sonmusteri.MusteriKurumsalOK = Convert.ToBoolean(dr["MusteriKurumsalOK"]);
                sonmusteri.DilID = Convert.ToInt32(dr["DilID"]);

                tummusteriler.Add(sonmusteri);

            }
            dr.Close();
            return tummusteriler;
        }

        // TCYE GÖRE MUSTERİ GETİRME 
        public musteriler tcytegoregetir(string tc)
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("select * from tbl_Musteriler where MusteriTCKimlik='"+tc+"'", null, "txt");
            musteriler sonmusteri = new musteriler();
            while (dr.Read())
            {
                
                sonmusteri.MusteriID = Convert.ToInt32(dr["MusteriID"]);
                sonmusteri.MusteriAd = dr["MusteriAd"].ToString();
                sonmusteri.MusteriSoyad = dr["MusteriSoyad"].ToString();
                sonmusteri.MusteriTCKimlik = dr["MusteriTCKimlik"].ToString();
                sonmusteri.MusteriPasaportNo = dr["MusteriPasaportNo"].ToString();
                sonmusteri.MusteriUnvan = dr["MusteriUnvan"].ToString();
                sonmusteri.MusteriYetkiliAdSoyad = dr["MusteriYetkiliAdSoyad"].ToString();
                sonmusteri.MusteriVergiNo = dr["MusteriVergiNo"].ToString();
                sonmusteri.MusteriVergiDairesi = dr["MusteriVergiDairesi"].ToString();
                sonmusteri.MusteriTelefon = dr["MusteriTelefon"].ToString();
                sonmusteri.MusteriPosta = dr["MusteriPosta"].ToString();
                sonmusteri.MusteriAdres = dr["MusteriAdres"].ToString();
                sonmusteri.IlID = Convert.ToInt32(dr["IlID"]);
                sonmusteri.IlceID = Convert.ToInt32(dr["IlceID"]);
                sonmusteri.UlkeID = Convert.ToInt32(dr["UlkeID"]);
                sonmusteri.MusteriAciklama = dr["MusteriAciklama"].ToString();
                sonmusteri.MusteriKurumsalOK = Convert.ToBoolean(dr["MusteriKurumsalOK"]);
                sonmusteri.DilID = Convert.ToInt32(dr["DilID"]);

                
            }
            return sonmusteri;
        }

        // MÜSTERİ GÜNCELLEME
        public int musteriguncelleme(musteriler eklenenmusteri)
        {
            SqlParameter[] eklenen =
                {
                new SqlParameter
                    {
                    ParameterName="MusteriAd",
                    Value=eklenenmusteri.MusteriAd
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriSoyad",
                    Value=eklenenmusteri.MusteriSoyad
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriTCKimlik",
                    Value=eklenenmusteri.MusteriTCKimlik
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriPasaportNo",
                    Value=eklenenmusteri.MusteriPasaportNo
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriUnvan",
                    Value=eklenenmusteri.MusteriUnvan
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value=eklenenmusteri.MusteriYetkiliAdSoyad
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriVergiNo",
                    Value=eklenenmusteri.MusteriVergiNo
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriVergiDairesi",
                    Value=eklenenmusteri.MusteriVergiDairesi
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriTelefon",
                    Value=eklenenmusteri.MusteriTelefon
                    },
                new SqlParameter
                    {
                    ParameterName="MusteriPosta",
                    Value=eklenenmusteri.MusteriPosta
                    },
                 new SqlParameter
                    {
                    ParameterName="MusteriAdres",
                    Value=eklenenmusteri.MusteriAdres
                    },
                  new SqlParameter
                    {
                    ParameterName="IlID",
                    Value=eklenenmusteri.IlID
                    },
                   new SqlParameter
                    {
                    ParameterName="IlceID",
                    Value=eklenenmusteri.IlceID
                    },
                    new SqlParameter
                    {
                    ParameterName="UlkeID",
                    Value=eklenenmusteri.UlkeID
                    },
                     new SqlParameter
                    {
                    ParameterName="MusteriAciklama",
                    Value=eklenenmusteri.MusteriAciklama
                    },
                      new SqlParameter
                    {
                    ParameterName="MusteriKurumsalOK",
                    Value=eklenenmusteri.MusteriKurumsalOK
                    },
                       new SqlParameter
                    {
                    ParameterName="DilID",
                    Value=eklenenmusteri.DilID
                    },



                };

            int eklenensatir = BilgiOtelHelperSql.myExecuteNonquery("sp_musteri_Guncelle", eklenen, "sp");
            return eklenensatir;
        }
    }
}
