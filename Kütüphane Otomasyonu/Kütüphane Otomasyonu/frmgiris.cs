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

namespace Kütüphane_Otomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void lblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        DataTable dataTable = new DataTable();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            String k_adı = "admin";
            String sifre = "999";
            if (txtKullanıcıAdı.Text==k_adı && txtKullanıcıŞifre.Text==sifre)
            {
                FrmislemEkranı islemEkranı = new FrmislemEkranı();
                this.Hide();
                islemEkranı.Show();
            }
            else
            {
                MessageBox.Show("Giriş hatası ");
            }
            
         
        }

        private void lblKullanıcıAd_Click(object sender, EventArgs e)
        {

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
           

        }

        private void frmGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
