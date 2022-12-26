using BilgiOtelDal;
using BilgiOtelEntity;
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
    public partial class personel_ekle_duzenle : Form
    {
        public personel_ekle_duzenle()
        {
            InitializeComponent();
        }
        NesneDoldurmaSilme listeyazdirma = new NesneDoldurmaSilme();
        private void bptnyenipersonel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            


        }

        private void personel_ekle_duzenle_Load(object sender, EventArgs e)
        {
            listeyazdirma.listviewdoldur(listView1, "sp_personel_ekle", null, "sp");
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            txtid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtad2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txttc2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txttelefon2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtsaatlikucret2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtmaas2.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtadres2.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                personel personelguncelle= new personel();
                personelguncelle.PersonelId = Convert.ToInt32(txtid.Text);
                personelguncelle.PersonelAd = txtad2.Text;
                personelguncelle.PersonelSoyad = txtsoyad2.Text;
                personelguncelle.PersonelTcKimlik = txttc2.Text;
                personelguncelle.PersonelTelefon = txttelefon2.Text;
                personelguncelle.PersonelMaas = Convert.ToDecimal(txtmaas2.Text);
                personelguncelle.PersonelSaatlikUcret = Convert.ToDecimal(txtsaatlikucret2.Text);
                personelguncelle.PersonelAdres = txtadres2.Text;

                PersonellerDal personelguncellemedal= new PersonellerDal();
                personelguncellemedal.personelguncelleme(personelguncelle);
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
            NesneDoldurmaSilme nds = new NesneDoldurmaSilme();
            nds.FromTemizleme(this);
            listeyazdirma.listviewdoldur(listView1, "sp_personel_ekle", null, "txt");
        }
    }
}
