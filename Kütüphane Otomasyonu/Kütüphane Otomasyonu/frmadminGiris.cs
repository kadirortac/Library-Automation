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
    public partial class frmadminGiris : Form
    {
        public frmadminGiris()       {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            String gelenAdmnKullanıcıAdı = "admin";
            String gelenAdmnSifre = "999";
            if (txtAdminKullanıcıAdı.Text == gelenAdmnKullanıcıAdı && txtAdminKullanıcıŞifre.Text == gelenAdmnSifre)
            {
                MessageBox.Show("Giriş Başarılı ^^ ");
                FrmislemEkranı frmislemEkranı = new FrmislemEkranı();
                this.Hide();
                frmislemEkranı.Show();


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void frmadminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
