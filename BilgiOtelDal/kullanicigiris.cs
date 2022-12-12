using BilgiOtelEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtelDal
{
    public static class kullanicigiris
    {
        public static string GirisYapanAd { get; set; }
        public static string GirisYapanSoyad { get; set; }
        public static int GirisYapanYetki { get; set; }
        public static int kullanicigirissorgulama(string kullaniciadi,string parola)
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader("select k.KullaniciAd,k.KullaniciParola,kp.YetkiId,p.PersonelAd,p.PersonelSoyad from tbl_Kullanici as k join tbl_KullaniciPersonel AS kp on  k.KullaniciId =kp.KullaniciId join tbl_Personel as p on kp.PersonelId=p.PersonelId where k.KullaniciAd = '" + kullaniciadi+"'and k.KullaniciParola ='"+ parola + "'", null, "txt");
            kullanici kullaniciyeni = new kullanici();
            yetkiler yetki= new yetkiler();
            personel personelisim = new personel();
            

            while (dr.Read())
            {
                
                kullaniciyeni.KullaniciAd = dr[0].ToString();
                kullaniciyeni.KullaniciParola = dr[1].ToString();
                GirisYapanYetki = Convert.ToInt32(dr[2]);
                GirisYapanAd = dr[3].ToString();
                GirisYapanSoyad = dr[4].ToString();
                
            }
            dr.Close();
            int sonuc =0;
            if (kullaniciyeni.KullaniciAd==kullaniciadi && kullaniciyeni.KullaniciParola == parola)
            {
                sonuc = yetki.YetkiId;
            }
            else
            {
                GirisYapanYetki = 0;
            }

            return sonuc;    
        }

        
    }
    
}
