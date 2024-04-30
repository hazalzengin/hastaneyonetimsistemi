using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneyonetimsistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktorGiris = new FrmDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastagiris hastagiris = new hastagiris();
            hastagiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSekreter sekreter = new FrmSekreter();
            sekreter.Show();
            this.Hide();
        }
    }
}
