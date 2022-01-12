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
    public partial class frmSifreSıfırlama : Form
    {
        String kullaniciAdi = frmKodGönder.kime;
        public frmSifreSıfırlama()
        {
            InitializeComponent();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            if (resetPass.Text == resetPassKontrol.Text)
            {
                
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "UPDATE users_info SET user_sifre ='" + resetPassKontrol.Text + "' WHERE user_mail = '" + kullaniciAdi + "'";
                komut.Connection = baglanti;
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz Başarıyla Sıfırlandı");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hata Oluştu"+ex);
                }

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
        }
    }
}
