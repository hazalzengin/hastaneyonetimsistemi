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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TC;
        SqlConn conn = new SqlConn();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedtc.Text = TC;
            SqlCommand komut = new SqlCommand("select * from TBLHASTALAR Where hastaTC=@p1", conn.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedtc);
        }
    }
}
