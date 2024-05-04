using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hastaneyonetimsistemi
{
    public partial class FrmDuyurlar : Form
    {
        public FrmDuyurlar()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void FrmDuyurlar_Load(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            SqlDataAdapter read1 = new SqlDataAdapter("select * from tblduyuru", conn.baglanti());
            read1.Fill(db);
            dataGridView1.DataSource = db;
        }

    }
}
