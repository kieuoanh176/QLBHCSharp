using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLBHCSharp
{
    class clsMain
    {
        public static void DoSQL(string sql)
        {
            string strcn = "Data Source=SONTRINH-HP\\KTQDSERVER;Initial Catalog=QLBH;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
