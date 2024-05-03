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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void label5_Click(object sender, EventArgs e)
        {

        }
        string tcnm = hastagiris.tcno.ToString();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT hastaad, hastasoyad FROM TBLHASTALAR WHERE hastaTC = @p3", conn.baglanti());

            komut.Parameters.AddWithValue("@p3",tcnm); 
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
                lblTc.Text= tcnm;
            }

            conn.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblrandevu WHERE HastaTC=" +tcnm, conn.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut1 = new SqlCommand("select bransad from tblbrans",conn.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
            }
            conn.baglanti().Close();
            //SqlCommand komut2 = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktorbrans=@p1", conn.baglanti());
            //komut2.Parameters.AddWithValue("@p1", comboBox1.Text);
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    comboBox2.Items.Add(dr2[0] + dr2[1].ToString());
            //}
            //conn.baglanti().Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktorbrans=@p1", conn.baglanti());
            komut2.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0] + " "+ dr2[1].ToString());
            }
            conn.baglanti().Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblrandevu where randevubrans='" + comboBox1.SelectedItem + "'", conn.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle bilgiDuzenle = new FrmBilgiDuzenle();
            bilgiDuzenle.TC = lblTc.Text;
            bilgiDuzenle.Show();
  

        }
    }
}
