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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        public string secilen;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = FrmSekreter.sekretertc.ToString();
        
            SqlCommand komut = new SqlCommand("select* from tblsekreterler where sekreterTC=@p1", conn.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1].ToString();
            }
            DataTable dbtable = new DataTable();
            SqlDataAdapter komut2 = new SqlDataAdapter("select * from tblbrans", conn.baglanti());
            komut2.Fill(dbtable);
            dataGridView1.DataSource = dbtable;


            DataTable db2table = new DataTable();
            SqlDataAdapter komut3 = new SqlDataAdapter("select doktorad, doktorsoyad, doktorbrans from tbldoktorlar",conn.baglanti());
            komut3.Fill(db2table);
            dataGridView2.DataSource = db2table;

            SqlCommand komut1 = new SqlCommand("select bransad from tblbrans", conn.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
            }
            conn.baglanti().Close();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            
            SqlCommand duyr = new SqlCommand("insert into tblduyuru (duyuru)values(@p1)",conn.baglanti());
            duyr.Parameters.AddWithValue("@p1", richTextBox1.Text);
            duyr.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturulmuştur", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnKaydetrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into tblrandevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values(@r1,@r2,@r3,@r4,@r5)", conn.baglanti());
            komut4.Parameters.AddWithValue("@r1",maskedTextBox1.Text);
            komut4.Parameters.AddWithValue("@r2", maskedTextBox2.Text);
            komut4.Parameters.AddWithValue("@r3", comboBox1.SelectedItem);
            komut4.Parameters.AddWithValue("@r4", comboBox2.SelectedItem);
            komut4.Parameters.AddWithValue("r5", maskedTextBox3.Text);
            komut4.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Randevu Oluşturulmuştur","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbldoktorlar where doktorbrans='" + comboBox1.SelectedItem + "'", conn.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select doktorad,doktorsoyad from tbldoktorlar where doktorbrans=@p1", conn.baglanti());
            komut2.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0] + " " + dr2[1].ToString());
            }
            conn.baglanti().Close();
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans = new FrmBrans();
            frmBrans.Show();
        }

        private void btnrandevupaneli_Click(object sender, EventArgs e)
        {
            FrmRandevular randevular = new FrmRandevular();
            randevular.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmDuyurlar frmDuyurlar = new FrmDuyurlar();
            frmDuyurlar.Show();
        }
    }
}
