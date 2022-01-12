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
   
    public partial class frmGüncellemeEkranı : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        public frmGüncellemeEkranı()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
            baglanti.Open();
            String uyeListele = "select * from users_info";
            SqlCommand komut = new SqlCommand(uyeListele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          

            try
            {
                baglanti.Open();

                string guncelle = "update  users_info set user_ad=@user_ad,user_soyad=@user_soyad,user_gsm=@user_gsm,user_kullanıcıAdı=@user_kullanıcıAdı,user_mail=@user_mail where user_id=@user_id";
                SqlCommand komut = new SqlCommand(guncelle,baglanti);
                komut.Parameters.AddWithValue("@user_ad", txtUpdateAd.Text);
                komut.Parameters.AddWithValue("@user_soyad", txtSoyadUpdate.Text);
                komut.Parameters.AddWithValue("@user_kullanıcıAdı", txtUpdateKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@user_gsm", txtUpdateGsm.Text);
                komut.Parameters.AddWithValue("@user_mail", txtMailUpdate.Text);
                komut.Parameters.AddWithValue("@user_id", Convert.ToInt32(txtuserid.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();







            }
            catch (Exception ex)
            {
                MessageBox.Show("hata"+ex);
            }










        }

        private void frmGüncellemeEkranı_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           txtUpdateAd.Text=  dataGridView1.CurrentRow.Cells[1].Value.ToString();
           txtSoyadUpdate.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
           txtUpdateKullanıcıAdı.Text=  dataGridView1.CurrentRow.Cells[3].Value.ToString();
           txtMailUpdate.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
           txtUpdateGsm.Text=  dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
