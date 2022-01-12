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
    public partial class frmkayıtOl : Form
    {
        public frmkayıtOl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                baglanti.Open();

                if (txtKayıtAd.Text != "" || txtKayıtSoyad.Text != "" || txtKayıtKullanıcıAdı.Text != "" || txtKayıtKullanıcıSifre.Text != "" || txtKayıtMail.Text != "" || txtKayıtGsm.Text != "") 
                {
                    String ekle = "insert into users_info (user_ad, user_soyad, user_kullanıcıAdı, user_mail, user_gsm, user_sifre) values (@user_ad, @user_soyad, @user_kullanıcıAdı, @user_mail, @user_gsm, @user_sifre)";
                    komut = new SqlCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@user_ad", txtKayıtKullanıcıAdı.Text);
                    komut.Parameters.AddWithValue("@user_soyad", txtKayıtSoyad.Text);
                    komut.Parameters.AddWithValue("@user_kullanıcıAdı", txtKayıtKullanıcıAdı.Text);
                    komut.Parameters.AddWithValue("@user_mail", txtKayıtMail.Text);
                    komut.Parameters.AddWithValue("@user_sifre", txtKayıtKullanıcıSifre.Text);
                    komut.Parameters.AddWithValue("@user_gsm",txtKayıtGsm.Text );
                    
                    try
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı ^^");
                        baglanti.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                
                 

                }
                else
                {
                    MessageBox.Show("Lütfen Bilgileri Boş Bırakmayınız!");
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Hata Meydana Geldi " + Ex);
            }
            
        }

        private void frmkayıtOl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            this.Hide();
            giris.Show();
        }
    }
}

