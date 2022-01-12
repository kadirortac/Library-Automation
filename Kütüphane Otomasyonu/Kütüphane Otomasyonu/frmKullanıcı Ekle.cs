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
using System.Net;
using System.Net.Mail;
namespace Kütüphane_Otomasyonu.Kullanıcı
{
    public partial class frmKullanıcıEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);

        void listele()
        {

            baglanti.Open();
            String listele = "select * from users_info  ";
            SqlCommand komut = new SqlCommand(listele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
        String kime;

        public frmKullanıcıEkle()
        {
            InitializeComponent();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            String randomSifre;

            if (txtKullanıcıAdEkle.Text.Trim() != "" && txtKullanıcıSoyadEkle.Text.Trim() != "" && txtKullanıcıMailEkle.Text.Trim() != "" && txtKullanıcıEkleGsm.Text.Trim() != "")
            {
                Random random = new Random();
                randomSifre = (random.Next(9999)).ToString();
                String ekle = "insert into users_info (user_ad,user_kullanıcıAdı, user_soyad,user_mail,user_gsm) values (@user_ad,@user_ad,@user_soyad,@user_mail,@user_gsm)";
                SqlCommand komut = new SqlCommand();
                komut = new SqlCommand(ekle, baglanti);
                komut.Parameters.AddWithValue("@user_ad", txtKullanıcıAdEkle.Text);
                komut.Parameters.AddWithValue("@user_soyad", txtKullanıcıSoyadEkle.Text);
                komut.Parameters.AddWithValue("@user_mail", txtKullanıcıMailEkle.Text);
                komut.Parameters.AddWithValue("@user_gsm", txtKullanıcıEkleGsm.Text);
                
                try
                {
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Eklendi ^^");
                    listele();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKullanıcıEkle_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
