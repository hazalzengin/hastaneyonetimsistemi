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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dbtable = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from tblbrans",conn.baglanti());
            dt.Fill(dbtable);
            dataGridView1.DataSource = dbtable;
        }
        SqlConn conn = new SqlConn();
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblbrans(bransad)values(@p1)",conn.baglanti());
            komut.Parameters.AddWithValue("@p1",txtsoyad.Text);
            komut.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Yeni branş eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
          
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand deletekomut= new SqlCommand("delete from tblbrans where bransad=@p1",conn.baglanti());
            deletekomut.Parameters.AddWithValue("@p1", txtsoyad.Text);
            deletekomut.ExecuteNonQuery();
            conn.baglanti().Close();
            MessageBox.Show("Var olan branş silinmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
