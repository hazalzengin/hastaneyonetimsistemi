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
            komut.Parameters.AddWithValue("@p1", maskedtc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                maskedtlf.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
            }

            conn.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE TBLHASTALAR set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastasifre=@p4",conn.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedtlf.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
