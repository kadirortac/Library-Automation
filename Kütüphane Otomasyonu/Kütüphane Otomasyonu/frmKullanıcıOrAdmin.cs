using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class frmKullanıcıOrAdmin : Form
    {
        public frmKullanıcıOrAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmadminGiris frmadminGiris = new frmadminGiris();
            this.Hide();
            frmadminGiris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Hide();
            frmGiris.Show();
        }
    }
}
