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
    public partial class FrmSekreter : Form
    {
        public FrmSekreter()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        public static string sekretertc;
        private void FrmSekreter_Load(object sender, EventArgs e)
        {
            



        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblsekreterler where sekreterTC=@p1 and sekretersifre=@p2", conn.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sekretertc = maskedTextBox1.Text;
                FrmSekreterDetay sekreterDetay = new FrmSekreterDetay();
                sekreterDetay.Show();
            }
            else
            {
                MessageBox.Show("TC no veya Şifrenizi kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.baglanti().Close();
        }
    }
}
