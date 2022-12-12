using BilgiOtelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDal
{
    public class PersonellerDal
    {   // YENİ PERSONEL EKLEME
        public int personelekleme(personel eklenenpersonel, vardiya vardiyaPersonel, kullanici personelkullanici, yetkiler personelyetki)
        {
            SqlParameter[] eklenen =
                {
                new SqlParameter
                    {
                    ParameterName="PersonelAd",
                    Value=eklenenpersonel.PersonelAd
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelSoyad",
                    Value=eklenenpersonel.PersonelSoyad
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelTcKimlik",
                    Value=eklenenpersonel.PersonelTcKimlik
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelDogumTarihi",
                    Value=eklenenpersonel.PersonelDogumTarihi
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelEposta",
                    Value=eklenenpersonel.PersonelEposta
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelTelefon",
                    Value=eklenenpersonel.PersonelTelefon
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelIseGirisTarihi",
                    Value=eklenenpersonel.PersonelIseGirisTarihi
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelSaatlikUcret",
                    Value=eklenenpersonel.PersonelSaatlikUcret
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelMaas",
                    Value=eklenenpersonel.PersonelMaas
                    },
                new SqlParameter
                    {
                    ParameterName="PersonelSicilNo",
                    Value=eklenenpersonel.PersonelSicilNo
                    },
                 new SqlParameter
                    {
                    ParameterName="GorevId",
                    Value=eklenenpersonel.GorevId
                    },
                  new SqlParameter
                    {
                    ParameterName="PersonelKategoriID",
                    Value=eklenenpersonel.PersonelKategoriID
                    },
                   new SqlParameter
                    {
                    ParameterName="PersonelAdres",
                    Value=eklenenpersonel.PersonelAdres
                    },
                    new SqlParameter
                    {
                    ParameterName="VardiyaId",
                    Value=vardiyaPersonel.VardiyaId
                    },
                     new SqlParameter
                    {
                    ParameterName="KullaniciAd",
                    Value=personelkullanici.KullaniciAd
                    },
                      new SqlParameter
                    {
                    ParameterName="KullaniciParola",
                    Value=personelkullanici.KullaniciParola
                    },
                       new SqlParameter
                    {
                    ParameterName="YetkiId",
                    Value=personelyetki.YetkiId
                    },

                };

            int eklenenperonelsatir = BilgiOtelHelperSql.myExecuteNonquery("sp_Personelkayit", eklenen, "sp");
            return eklenenperonelsatir;

        }

        // TÜM PERSONELLERİ GETİRME
        /*
        public List<personel> personelgetir(personel eklenenpersonel, vardiya vardiyaPersonel, kullanici personelkullanici, yetkiler personelyetki)
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("sp_PesonelTumunuGetir", null, "txt");
            List<personel> tumpersoneller = new List<personel>();
            while (dr.Read())
            {



                personel sonpersonel = new personel();
                sonpersonel.PersonelId = Convert.ToInt32(dr["PersonelId"]);
                sonpersonel.PersonelAd = dr["PersonelAd"].ToString();
                sonpersonel.PersonelSoyad = dr["PersonelSoyad"].ToString();
                sonpersonel.PersonelTcKimlik = dr["PersonelTcKimlik"].ToString();
                sonpersonel.PersonelDogumTarihi = Convert.ToDateTime(dr["PersonelDogumTarihi"]);
                sonpersonel.PersonelEposta = dr["PersonelEposta"].ToString();
                sonpersonel.PersonelTelefon = dr["PersonelTelefon"].ToString();
                sonpersonel.PersonelIseGirisTarihi = Convert.ToDateTime(dr["PersonelIseGirisTarihi"]);
                sonpersonel.PersonelSaatlikUcret = Convert.ToDecimal(dr["PersonelSaatlikUcret"]);
                sonpersonel.PersonelMaas = Convert.ToDecimal(dr["MusteriTelefon"]);
                sonpersonel.PersonelSicilNo = dr["MusteriPosta"].ToString();
                sonpersonel.GorevId = Convert.ToInt32(dr["MusteriAdres"]);
                sonpersonel.PersonelKategoriID = Convert.ToInt32(dr["IlID"]);
                sonpersonel.PersonelAdres = dr["IlceID"].ToString();
                vardiyaPersonel.VardiyaTipi = dr["VardiyaId"].ToString();
                // BURAYI DEVAM ETTİR

                tumpersoneller.Add(sonpersonel);

                dr.Close();
                return tumpersoneller;
            } // BİTMEDİ DEVAM ETTİR
        }*/


    }
}
