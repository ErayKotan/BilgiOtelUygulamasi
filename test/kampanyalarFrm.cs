using BilgiOtelDal;
using BilgiOtelEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace test
{
    public partial class kampanyalarFrm : Form
    {
        public kampanyalarFrm()
        {
            InitializeComponent();
        }
        NesneDoldurmaSilme listeyazdirma = new NesneDoldurmaSilme();
        private void kampanyalar_Load(object sender, EventArgs e)
        {         
            listeyazdirma.listviewdoldur(listView1, "select * from tbl_Kampanyalar", null, "txt");
            
        }

        private void btnyenikampanya_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }


        private void listView1_Click(object sender, EventArgs e) //SEÇİLEN KAPMANYAYI EKRANA YAZDIRMA
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            txtad2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtindirim2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            dtpbaslangic2.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[3].Text);
            dtpbitis2.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[4].Text);
            txtaciklama2.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }
       
        private void btnGuncelle_Click(object sender, EventArgs e) //GETİRİLEN KAPMANYAYI GÜNCELLEME
        {
            try
            {
                kampanyalar kmpnya = new kampanyalar();
                kmpnya.KampanyaBilgileri = txtad2.Text;
                kmpnya.KampanyaIndirimOran = Convert.ToInt32(txtindirim2.Text);
                kmpnya.KampanyaBaslangicZaman = Convert.ToDateTime(dtpbaslangic2.Value);
                kmpnya.KampanyaBitisTarihi = Convert.ToDateTime(dtpbitis2.Value);
                kmpnya.KampanyaTanim = txtaciklama2.Text;

                kampanyalarDal kampanyalardalson = new kampanyalarDal();
                kampanyalardalson.kampanyaguncelleme(kmpnya);
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            NesneDoldurmaSilme nds = new NesneDoldurmaSilme();
            nds.FromTemizleme(this);
            listeyazdirma.listviewdoldur(listView1, "select * from tbl_Kampanyalar", null, "txt");

           
        }

        private void btnKampanyaKaydet_Click(object sender, EventArgs e) //YENİ KAMPANYA EKLEME
        {
            try
            {
                kampanyalar kmpnya = new kampanyalar();
                kmpnya.KampanyaBilgileri = txtKampanyaAd.Text;
                kmpnya.KampanyaIndirimOran = Convert.ToInt32(txtIndirimOrani.Text);
                kmpnya.KampanyaBaslangicZaman = Convert.ToDateTime(dtpilktarih.Value);
                kmpnya.KampanyaBitisTarihi = Convert.ToDateTime(dtpikincitarih.Value);
                kmpnya.KampanyaTanim = txtKampanyaAciklama.Text;

                kampanyalarDal kampanyalardalson = new kampanyalarDal();
                kampanyalardalson.kampanyaekleme(kmpnya);
                MessageBox.Show("Yeni Kayıt Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Yeni Kayıt  Başarısız");
            }
            listeyazdirma.listviewdoldur(listView1, "select * from tbl_Kampanyalar", null, "txt");

            NesneDoldurmaSilme nds = new NesneDoldurmaSilme();
            nds.FromTemizleme(this);
        }

        private void dtpilktarih_ValueChanged(object sender, EventArgs e)
        {
            dtpikincitarih.MinDate=dtpilktarih.Value;
        }
    }
}
