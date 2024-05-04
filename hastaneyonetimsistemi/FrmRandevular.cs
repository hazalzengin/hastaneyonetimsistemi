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
    public partial class FrmRandevular : Form
    {
        public FrmRandevular()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void FrmRandevular_Load(object sender, EventArgs e)
        {
            DataTable dbtable = new DataTable();
            SqlDataAdapter komut = new SqlDataAdapter("select* from tblrandevu",conn.baglanti());
            komut.Fill(dbtable);
            dataGridView1.DataSource = dbtable;
            conn.baglanti().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
