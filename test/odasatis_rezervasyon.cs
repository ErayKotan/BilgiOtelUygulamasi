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
    public partial class odasatis_rezervasyon : Form
    {
        odaSatisDal deneme = new odaSatisDal();
         satis satis1 = new satis();
        public odasatis_rezervasyon()
        {
            InitializeComponent();
        }
        void OdaSorgugetirme()
        {
            satis1.SatisOdaGirisTarihi = dtp1.Value;
            satis1.SatisOdaCikisTarihi = dtp2.Value;
          List<string> odakontrol =  deneme.odasorgula(satis1);
            foreach (Button x in groupBox1.Controls) //GROUPBOX1
            {
                if (odakontrol.Contains(x.Text))
                {
                    x.BackColor = Color.Red;
                }
                else
                {
                    x.BackColor = Color.Green;
                }
            }

            foreach (Button x in groupBox2.Controls) //GROUPBOX2
            {
                if (odakontrol.Contains(x.Text))
                {
                    x.BackColor = Color.Red;
                }
                else
                {
                    x.BackColor = Color.Green;
                }
            }

            foreach (Button x in groupBox3.Controls) //GROUPBOX3
            {
                if (odakontrol.Contains(x.Text))
                {
                    x.BackColor = Color.Red;
                }
                else
                {
                    x.BackColor = Color.Green;
                }
            }
            foreach (Button x in groupBox4.Controls) //GROUPBOX4
            {
                if (odakontrol.Contains(x.Text))
                {
                    x.BackColor = Color.Red;
                }
                else
                {
                    x.BackColor = Color.Green;
                }
            }
            
        }
        private void odasatis_rezervasyon_Load(object sender, EventArgs e)
        {

            OdaSorgugetirme();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            OdaSorgugetirme();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
