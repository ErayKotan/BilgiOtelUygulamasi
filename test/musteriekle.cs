using BilgiOtelDal;
using BilgiOtelEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class musteriekle : Form
    {
        public musteriekle()
        {
            InitializeComponent();
        }
        NesneDoldurmaSilme nds = new NesneDoldurmaSilme();
        private void btnKaydet_Click(object sender, EventArgs e) //YENİ MÜŞTERİ EKLEME
        {
            try
            {
                musteriler musteriekleme = new musteriler();
                musteriekleme.MusteriAd = txtAd.Text;
                musteriekleme.MusteriSoyad = txtSoyad.Text;
                musteriekleme.MusteriTCKimlik = txtTc.Text;
                musteriekleme.MusteriPasaportNo = txtPasaport.Text;
                musteriekleme.MusteriUnvan = txtunvan.Text;
                musteriekleme.MusteriYetkiliAdSoyad = txtYetkili.Text;
                musteriekleme.MusteriVergiNo = txtVergiNo.Text;
                musteriekleme.MusteriVergiDairesi = txtVergiDairesi.Text;
                musteriekleme.MusteriTelefon = txtTelefon.Text;
                musteriekleme.MusteriPosta = txtEposta.Text;
                musteriekleme.UlkeID = Convert.ToInt32(cmbulke.SelectedValue);
                musteriekleme.IlID = Convert.ToInt32(cmbil.SelectedValue);
                musteriekleme.IlceID = Convert.ToInt32(cmbilce.SelectedValue);
                musteriekleme.MusteriAdres = txtAdres.Text;
                musteriekleme.MusteriKurumsalOK = chcevet.Checked;
                musteriekleme.DilID = Convert.ToInt32(cmbDil.SelectedValue);
                musteriekleme.MusteriAciklama = txtAciklama.Text;

                musterilerDal yenimusteri = new musterilerDal();
                yenimusteri.musteriekleme(musteriekleme);
                MessageBox.Show("Yeni Kayıt Başarılı ...");
            }
            catch (Exception)
            {

                MessageBox.Show("Yeni Kayıt Başarısız !!!");
            }
            finally
            {
                NesneDoldurmaSilme nds = new NesneDoldurmaSilme();
                nds.FromTemizleme(this);
            }

        }
        NesneDoldurmaSilme nesneDoldurma = new NesneDoldurmaSilme();
        musterilerDal musterilerdalson = new musterilerDal();
        private void musteriekle_Load(object sender, EventArgs e)  //  EKRAN İLK AÇILDIĞINDA COMBOBOX DOLDURMA
        {
           
            nesneDoldurma.herhangibircombo(cmbulke, "select * from tbl_Ulke", "txt");
            nesneDoldurma.herhangibircombo(cmbDil, "select * from tbl_Diller", "txt");
        }

        private void cmbulke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            nesneDoldurma.herhangibircombo(cmbil, "select * from tbl_Il where UlkeId=" + cmbulke.SelectedValue, "txt");//  ŞARTLI COMBOBOX DOLDURMA İL
        }

        private void cmbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesneDoldurma.herhangibircombo(cmbilce, "select * from tbl_Ilce where IlId="+cmbil.SelectedValue,"txt");//  ŞARTLI COMBOBOX DOLDURMA İLÇE
        }

        private void btnara_Click(object sender, EventArgs e) //TC YE GÖRE GELEN MÜŞTERİLERİ EKRANA YAZDIRMA
        {
            
            musteriler gelenmusteri = musterilerdalson.tcytegoregetir(txtsorgu.Text);
            
            if (gelenmusteri.MusteriID>0)
            {
                //musteriler gelenmusteri = musterilerdalson.tcytegoregetir(txtsorgu.Text);
                txtAd.Text = gelenmusteri.MusteriAd;
                txtSoyad.Text = gelenmusteri.MusteriSoyad;
                txtTc.Text = gelenmusteri.MusteriTCKimlik;
                txtPasaport.Text = gelenmusteri.MusteriPasaportNo;
                txtunvan.Text = gelenmusteri.MusteriUnvan;
                txtYetkili.Text = gelenmusteri.MusteriYetkiliAdSoyad;
                txtVergiNo.Text = gelenmusteri.MusteriVergiNo;
                txtVergiDairesi.Text = gelenmusteri.MusteriVergiDairesi;
                txtTelefon.Text = gelenmusteri.MusteriTelefon;
                txtEposta.Text = gelenmusteri.MusteriPosta;
                cmbulke.SelectedValue = gelenmusteri.UlkeID;
                nesneDoldurma.herhangibircombo(cmbil, "select * from tbl_Il where UlkeId=" + cmbulke.SelectedValue, "txt");
                cmbil.SelectedValue = gelenmusteri.IlID;
                nesneDoldurma.herhangibircombo(cmbilce, "select * from tbl_Ilce where IlId=" + cmbil.SelectedValue, "txt");
                cmbilce.SelectedValue = gelenmusteri.IlceID;
                txtAdres.Text = gelenmusteri.MusteriAdres;
                chcevet.Checked = gelenmusteri.MusteriKurumsalOK;
                cmbDil.SelectedValue = gelenmusteri.DilID;
                txtAciklama.Text = gelenmusteri.MusteriAciklama;

                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
            else if (txtsorgu.Text == "")
            {
                MessageBox.Show("TC Kısmı Boş Bırakılamaz !!!");
                nds.FromTemizleme(this);
            }
            else
            {
                MessageBox.Show("Kullanıcı Kayıtlarda Mevcut Değildir");
                nds.FromTemizleme(this);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                musteriler musteriguncelleme = new musteriler();
                musteriguncelleme.MusteriAd = txtAd.Text;
                musteriguncelleme.MusteriSoyad = txtSoyad.Text;
                musteriguncelleme.MusteriTCKimlik = txtTc.Text;
                musteriguncelleme.MusteriPasaportNo = txtPasaport.Text;
                musteriguncelleme.MusteriUnvan = txtunvan.Text;
                musteriguncelleme.MusteriYetkiliAdSoyad = txtYetkili.Text;
                musteriguncelleme.MusteriVergiNo = txtVergiNo.Text;
                musteriguncelleme.MusteriVergiDairesi = txtVergiDairesi.Text;
                musteriguncelleme.MusteriTelefon = txtTelefon.Text;
                musteriguncelleme.MusteriPosta = txtEposta.Text;
                musteriguncelleme.UlkeID = Convert.ToInt32(cmbulke.SelectedValue);
                musteriguncelleme.IlID = Convert.ToInt32(cmbil.SelectedValue);
                musteriguncelleme.IlceID = Convert.ToInt32(cmbilce.SelectedValue);
                musteriguncelleme.MusteriAdres = txtAdres.Text;
                musteriguncelleme.MusteriKurumsalOK = chcevet.Checked;
                musteriguncelleme.DilID = Convert.ToInt32(cmbDil.SelectedValue);
                musteriguncelleme.MusteriAciklama = txtAciklama.Text;

                musterilerDal musteriguncel = new musterilerDal();
                musteriguncel.musteriguncelleme(musteriguncelleme);
                MessageBox.Show("Güncelleme Başarılı ...");
               
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme Başarısız !!!");
            }
            finally
            {
                nds.FromTemizleme(this);
            }
        }
    }
}
