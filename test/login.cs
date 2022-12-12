using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtelDal;
using BilgiOtelEntity;

namespace test
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            kullanicigiris.kullanicigirissorgulama(txtkullanici.Text, txtsifre.Text);
            

            if (kullanicigiris.GirisYapanYetki > 0)
            {
                MessageBox.Show("Giriş Başarılı...");
                anasayfa anasyf = new anasayfa();
                anasyf.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
                txtsifre.Clear();
            }
        }
    }
}
