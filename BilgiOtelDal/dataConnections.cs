using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDal
{
    public class dataConnections
    {
        //mssql bağlantisi
        public static string get_MsSqlConnectionString
        {
            get{ return "Server=.;Database=DB_Bilgi_Hotel;Trusted_Connection=True;"; }
        }

    }
}
