using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiOtelDal;
using BilgiOtelEntity;

namespace BilgiOtelDal
{
    public class kampanyalarDal
    { 
        // YENİ KAMPANYA EKLEME
        public int kampanyaekleme(kampanyalar eklenenkampanya)
        {
            SqlParameter[] eklenen =
               {
                new SqlParameter
                    {
                    ParameterName="kampanyaAd",
                    Value=eklenenkampanya.KampanyaBilgileri
                    },
                new SqlParameter
                    {
                    ParameterName="indirimorani",
                    Value=eklenenkampanya.KampanyaIndirimOran
                    },
                new SqlParameter
                    {
                    ParameterName="ilktarih",
                    Value=eklenenkampanya.KampanyaBaslangicZaman
                    },
                new SqlParameter
                    {
                    ParameterName="ikincitarih",
                    Value=eklenenkampanya.KampanyaBitisTarihi
                    },
                new SqlParameter
                    {
                    ParameterName="aciklama",
                    Value=eklenenkampanya.KampanyaTanim
                    },
                };

            int eklenenkampanyasatir = BilgiOtelHelperSql.myExecuteNonquery("sp_KampanyaEkle", eklenen, "sp");
            return eklenenkampanyasatir;
        }

        // TÜM KAMPANYALARI GETİRME
        public List<kampanyalar> kampanyagetir()
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("select * from tbl_Kampanyalar", null, "txt");
            List<kampanyalar> tumkampanyalar = new List<kampanyalar>();
            while (dr.Read())
            {
                kampanyalar sonkampanya = new kampanyalar();
                sonkampanya.KampanyaId = Convert.ToInt32(dr["KampanyaId"]);
                sonkampanya.KampanyaBilgileri = dr["KampanyaBilgileri"].ToString();
                sonkampanya.KampanyaIndirimOran =Convert.ToInt32(dr["KampanyaIndirimOran"]);
                sonkampanya.KampanyaBaslangicZaman = Convert.ToDateTime(dr["KampanyaBaslangicZaman"]);
                sonkampanya.KampanyaBitisTarihi = Convert.ToDateTime(dr["KampanyaBitisTarihi"]);
                sonkampanya.KampanyaTanim = dr["KampanyaTanim"].ToString();

                tumkampanyalar.Add(sonkampanya);

            }
            dr.Close();
            return tumkampanyalar;
        } 

        // İSME GÖRE KAMPANYA GETİRME
        public kampanyalar ismegorekampanyagetir(string isim)
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("sp_KampanyaGetir" + isim, null, "sp");
            kampanyalar gelenkampanya = new kampanyalar();

            while (dr.Read())
            {
                gelenkampanya.KampanyaId = Convert.ToInt32(dr["KampanyaId"]);
                gelenkampanya.KampanyaBilgileri = dr["KampanyaBilgileri"].ToString();
                gelenkampanya.KampanyaIndirimOran = Convert.ToInt32(dr["KampanyaIndirimOran"]);
                gelenkampanya.KampanyaBaslangicZaman = Convert.ToDateTime(dr["KampanyaBaslangicZaman"]);
                gelenkampanya.KampanyaBitisTarihi = Convert.ToDateTime(dr["KampanyaBitisTarihi"]);
                gelenkampanya.KampanyaTanim = dr["KampanyaTanim"].ToString();

               
            }
            dr.Close();
            return gelenkampanya;
        }

        //KAMPANYA GÜNCELLEME
        public int kampanyaguncelleme(kampanyalar guncellenenkampanya)
        {
            SqlParameter[] eklenen =
               {
                new SqlParameter
                    {
                    ParameterName="kampanyaAd",
                    Value=guncellenenkampanya.KampanyaBilgileri
                    },
                new SqlParameter
                    {
                    ParameterName="indirimorani",
                    Value=guncellenenkampanya.KampanyaIndirimOran
                    },
                new SqlParameter
                    {
                    ParameterName="ilktarih",
                    Value=guncellenenkampanya.KampanyaBaslangicZaman
                    },
                new SqlParameter
                    {
                    ParameterName="ikincitarih",
                    Value=guncellenenkampanya.KampanyaBitisTarihi
                    },
                new SqlParameter
                    {
                    ParameterName="aciklama",
                    Value=guncellenenkampanya.KampanyaTanim
                    },
                };

            int guncellenenkampanyasatir = BilgiOtelHelperSql.myExecuteNonquery("sp_KampanyaGuncelle", eklenen, "sp");
            return guncellenenkampanyasatir;
        }
    }
}