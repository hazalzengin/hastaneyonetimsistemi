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
    public partial class hastagiris : Form
    {
        public hastagiris()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayit uyeKayit = new FrmUyeKayit();
            uyeKayit.Show();
            this.Hide();
        }
        public static string tcno;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLHASTALAR Where hastaTC=@p1 and hastasifre=@p2", conn.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                tcno = maskedTextBox1.Text;
                FrmHastaDetay hastaDetay = new FrmHastaDetay();
                hastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre ","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void hastagiris_Load(object sender, EventArgs e)
        {

        }
    }
}
