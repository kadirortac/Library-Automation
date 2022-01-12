using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Kütüphane_Otomasyonu
{
    class Sql_Connection_string
    {
        public static string sqlConnection = ConfigurationManager.ConnectionStrings["Kütüphane_Otomasyonu.Properties.Settings.Kütüphane_otomasyonConnectionString"].ConnectionString;
    }
}
