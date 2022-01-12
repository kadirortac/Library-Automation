using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Kütüphane_Otomasyonu
{
    public partial class frmOdunc : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        void Listele()
        {
            baglanti.Open();
            String KayıtListele = "select * from Kayıtlar";
            SqlCommand komut = new SqlCommand(KayıtListele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
            baglanti.Close();


        }
        public frmOdunc()
        {
            InitializeComponent();
        }

        private void btnKullanıcıBul_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string arananKullanıcı = "%"+txtGsm.Text+"%";
            string sec = "select * from users_info WHERE user_gsm like @user_gsm";
            SqlCommand komut = new SqlCommand(sec, baglanti);
            komut.Parameters.AddWithValue("@user_gsm", arananKullanıcı);
            SqlDataReader read = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnKaynakBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string arananKaynak = "%"+txtKaynak.Text+"%";
            string sec = "select * from Kaynaklar where kaynak_ad like @kaynak_ad";
            SqlCommand komut = new SqlCommand(sec, baglanti);
            komut.Parameters.AddWithValue("@kaynak_ad", arananKaynak);
            SqlDataReader read = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView2.DataSource = dt;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int kullanıcıId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int kaynakId= Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            string ödünc = "insert into Kayıtlar(kullanıcı_id,kaynak_id,alıs_tarihi,son_tarih,durum)" +
                "values(@kullanıcı_id,@kaynak_id,@alıs_tarihi,@son_tarih,@durum)";
            SqlCommand komut = new SqlCommand(ödünc, baglanti);
            komut.Parameters.AddWithValue("@kullanıcı_id", kullanıcıId);
            komut.Parameters.AddWithValue("@kaynak_id", kaynakId);
            komut.Parameters.AddWithValue("@alıs_tarihi", DateTime.Today);
            komut.Parameters.AddWithValue("@son_tarih", DateTime.Today.AddDays(15));
            komut.Parameters.AddWithValue("@durum", false);

            komut.ExecuteNonQuery();
            MessageBox.Show("istenen kaynak kullanıcıya verildi");
            baglanti.Close();
            Listele();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOdunc_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
