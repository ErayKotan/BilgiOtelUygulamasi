using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtelEntity;

namespace BilgiOtelDal
{
    public class odaSatisDal
    {
        public List<string> odasorgula(satis saatis) //ODA SORGULAMA METHODU
        {
            SqlParameter[] denme =
            {
                new SqlParameter
                {
                    ParameterName="@ilktarih",
                    Value=saatis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName="@ikincitarih",
                    Value=saatis.SatisOdaCikisTarihi
                }

            };
            List<string> odalistesi = new List<string>();
            SqlDataReader oku = BilgiOtelHelperSql.myExecuteReader("sp_TarihlerArasiDurum", denme, "sp");
            while (oku.Read())
            {
                odalistesi.Add(oku[0].ToString());   
                
            }
            oku.Close();
            return odalistesi;

        }






    }


}
