using BilgiOtelDal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        odasatis_rezervasyon odasatis = new odasatis_rezervasyon();
        musteriekle musteri = new musteriekle();
        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(kullanicigiris.GirisYapanYetki) == 1)
            {
                groupBox1.Visible = true;
            }
            else if (Convert.ToInt32(kullanicigiris.GirisYapanYetki) == 9)
            {
                groupBox2.Visible = true;

            }
            else if (Convert.ToInt32(kullanicigiris.GirisYapanYetki) == 2)
            {
                groupBox3.Visible = true;

            }
            else if (Convert.ToInt32(kullanicigiris.GirisYapanYetki) == 10)
            {
                groupBox4.Visible = true;

            }
            else if (Convert.ToInt32(kullanicigiris.GirisYapanYetki) == 7)
            {
                groupBox5.Visible = true;

            }
            label1.Text = kullanicigiris.GirisYapanAd + " " + kullanicigiris.GirisYapanSoyad;
        }

        private void button1_Click(object sender, EventArgs e) //ÇIKIŞ BUTONU
        {
            login grs = new login();
            grs.Show();
            this.Hide();
        }
        //
        private void btn_musteri_ekle_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            
            musteri.TopLevel = false;
            panel2.Controls.Add(musteri);
            musteri.Show();
        }

        private void btn_oda_satis_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            
            odasatis.TopLevel = false;
            panel2.Controls.Add(odasatis);
            odasatis.Show();
            
        }

        private void btn_musteri_listesi_Click(object sender, EventArgs e)
        {

        }

        private void btn_oda_durum_Click(object sender, EventArgs e)
        {

        }

        private void btn_kampanyalar_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            kampanyalarFrm kampanya = new kampanyalarFrm();
            kampanya.TopLevel = false;
            panel2.Controls.Add(kampanya);
            kampanya.Show();
        }

        private void btn_personel_listesi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            personel_ekle_duzenle personel = new personel_ekle_duzenle();
            personel.TopLevel = false;
            panel2.Controls.Add(personel);
            personel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
