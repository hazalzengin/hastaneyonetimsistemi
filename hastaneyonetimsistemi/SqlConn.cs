using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace hastaneyonetimsistemi
{
    class SqlConn
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data source=HAZAL;Initial Catalog=hastaneproje;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
