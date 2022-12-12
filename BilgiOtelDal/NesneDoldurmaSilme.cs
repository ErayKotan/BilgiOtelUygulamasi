using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BilgiOtelDal
{
    public class NesneDoldurmaSilme
    {/// <summary>
    /// comboyu ver sp yi söyle o doldursun
    /// </summary>
    /// <param name="cmb">comboadını yaz</param>
    /// <param name="spname"></param>
    /// <param name="sqlType"></param>
        public void herhangibircombo(ComboBox cmb, string spname, string sqlType)
        {
            List<KeyValuePair<int, string>> a = new List<KeyValuePair<int, string>>();
            SqlDataReader deneme = BilgiOtelHelperSql.myExecuteReader(spname, null, sqlType);
            while (deneme.Read())
            {
                a.Add(new KeyValuePair<int, string>((int)deneme[0], (string)deneme[1]));
            }
            cmb.DataSource = a.ToList();
            cmb.ValueMember = "Key";
            cmb.DisplayMember = "Value";
            deneme.Close();
        }
        
        /// <summary>
        /// Verilen listview'i belirtilen stored proc doğrultusunda doldurma
        /// </summary>
        /// <param name="list">Doldurmak istediğiniz listview adı</param>
        /// <param name="spname">sql de yazılan proc adı </param>
        /// <param name="spparametreleri">stored proc de parametre varsa doldurulabilir</param>
        public void listviewdoldur(ListView list, string spname, SqlParameter[] spparametreleri,string sptype)
        {
            list.Items.Clear();
            list.Columns.Clear();
            list.GridLines = true;
            list.FullRowSelect = true;
            list.View = View.Details;
            SqlDataReader okuyucu = BilgiOtelHelperSql.myExecuteReader(spname, spparametreleri, sptype);

            for (int i = 0; i < okuyucu.FieldCount; i++)
            {
                list.Columns.Add(okuyucu.GetName(i), 100);
            }
            while (okuyucu.Read())
            {
                ListViewItem ekleme = new ListViewItem(okuyucu[0].ToString());
                for (int i = 1; i < okuyucu.FieldCount; i++)
                {
                    ekleme.SubItems.Add(okuyucu[i].ToString());
                }
                list.Items.Add(ekleme);
            }
            okuyucu.Close();

        }
        
        public void formdoldur(string text,string type,GroupBox grp, SqlParameter[] parametreler)
        {
            SqlDataReader dr = BilgiOtelHelperSql.myExecuteReader(text,parametreler, type);

            dr.Read();

            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = dr[(item as TextBox).TabIndex].ToString();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = Convert.ToInt32(dr[(item as ComboBox).TabIndex]) - 1;
                }

                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = Convert.ToBoolean(dr[(item as CheckBox).TabIndex]);
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = Convert.ToBoolean(dr[(item as RadioButton).TabIndex]);
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = Convert.ToDateTime(dr[(item as DateTimePicker).TabIndex]);
                }
            }
        }

        public void FromTemizleme(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);

                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }
            }



        }

        public void grtemizleme(GroupBox gr)
        {
            foreach (Control item in gr.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);

                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }
            }


        }


        public void paneltemiz(Panel pn)
        {
            foreach (Control item in pn.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }

                else if (item is ListView)
                {

                    (item as ListView).Items.Clear();
                    (item as ListView).Columns.Clear();
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
                else if (item is RadioButton)
                {
                    (item as RadioButton).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Today;
                }
                else if (item is GroupBox)
                {
                    grtemizleme((GroupBox)item);

                }
                else if (item is Panel)
                {
                    paneltemiz((Panel)item);

                }



            }


        }
    }
}
