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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlConn conn = new SqlConn();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

            SqlCommand read1 = new SqlCommand("select * from tblbrans", conn.baglanti());
            read1.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr2 = read1.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[1].ToString());
            }

            DataTable dbtable = new DataTable();
            SqlDataAdapter read2 = new SqlDataAdapter("select * from tbldoktorlar",conn.baglanti());
            read2.Fill(dbtable);
            dataGridView1.DataSource = dbtable;

            conn.baglanti().Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if ((txtad.Text != "")&& (txtsoyad.Text != "")&& (txttc.Text != "")&& (cmbbrans.Text!=""))
            {
                SqlCommand komut = new SqlCommand("insert into tbldoktorlar(doktorad,doktorsoyad,doktorTC,doktorbrans,doktorsifre) values(@p1,@p2,@p3,@p4,@p5)", conn.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", txttc.Text);
                komut.Parameters.AddWithValue("@p4", cmbbrans.SelectedItem);
                komut.Parameters.AddWithValue("@p5", txtsifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni doktor kaydı oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgilerde eksilik var kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from tbldoktorlar where doktorTC=@p1",conn.baglanti());
            delete.Parameters.AddWithValue("@p1",txttc.Text);
            delete.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Kayıt silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txttc.Text=dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut2 = new SqlCommand("update tbldoktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3, doktorsifre=@p4, doktorTC=@p5", conn.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtad.Text);
                komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut2.Parameters.AddWithValue("@p3", cmbbrans.Text);
                komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
                komut2.Parameters.AddWithValue("@p5", txttc.Text);
                komut2.ExecuteNonQuery();
                conn.baglanti().Close();
                MessageBox.Show("Doktor bilgileri güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           


        }
    }
}
