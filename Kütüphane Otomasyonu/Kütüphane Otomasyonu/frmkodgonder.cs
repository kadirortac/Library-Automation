using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class frmKodGönder : Form
    {
        String randomKod;
        public static String kime;
        public frmKodGönder()
        {
            InitializeComponent();
        }
        

        private void btnKodiste_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Trim() != "")
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");
                baglanti.Open();
                String cmd_txt = "SELECT * FROM users_info WHERE user_mail ='" + txtMail.Text+ "'";
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = cmd_txt;
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    String kimden, sifre, mesajİcerik;
                    Random random = new Random();
                    randomKod = (random.Next(999999)).ToString();
                    MailMessage mesaj = new MailMessage();
                    kime = (txtMail.Text).ToString();
                    kimden = "gondericikod@gmail.com";
                    sifre = "999Ab6135";
                    mesajİcerik = "Şifre Sıfırlama Kodunuz : " + randomKod;
                    mesaj.To.Add(kime);
                    mesaj.From = new MailAddress(kimden);
                    mesaj.Body = mesajİcerik;
                    mesaj.Subject = "Şifre Sıfırlama";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(kimden, sifre);

                    try
                    {
                        smtp.Send(mesaj);
                        MessageBox.Show("Kod Başarıyla Gönderildi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("gönderilemedi " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli kullanıcı bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("E-Posta alanı boş bırakılamaz!");
            }
        }

        private void btnkodGonder_Click(object sender, EventArgs e)
        {
            if (randomKod == (txtKod.Text).ToString())
            {
                kime = txtMail.Text;
                frmSifreSıfırlama sıfırla = new frmSifreSıfırlama();
                this.Hide();
                sıfırla.Show();

            }
            else
            {
                MessageBox.Show("Kodlar eşleşmedi");
            }
        }
    }
}
