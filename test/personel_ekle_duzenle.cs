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
            //listeyazdirma.listviewdoldur(listView1, "select * from tbl_Kampanyalar", null, "txt");
        }
    }
}
