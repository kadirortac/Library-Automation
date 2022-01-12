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

namespace Kütüphane_Otomasyonu
{
    public partial class frmKitapEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
       void kitapListele()
        {

        
            string listele = "select * from Kaynaklar ";
            SqlCommand komut = new SqlCommand(listele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            
          
        }
        public frmKitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ekle = "insert into Kaynaklar (kaynak_ad,kaynak_yazar,kaynak_yayınEvi,kaynak_sayfaSayısı,kaynak_basımTarihi)" +
                "values (@kaynak_ad,@kaynak_yazar,@kaynak_yayınEvi,@kaynak_sayfaSayısı,@kaynak_basımTarihi)";
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@kaynak_ad",txtKaynakAdı.Text);
            komut.Parameters.AddWithValue("@kaynak_yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@kaynak_yayınEvi", txtYayınEvi.Text);
            komut.Parameters.AddWithValue("@kaynak_sayfaSayısı", Convert.ToInt32(txtSayfaSayısı.Text));
            komut.Parameters.AddWithValue("@kaynak_basımTarihi", dateTimePicker.Value);
            baglanti.Open();
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap kaynaklara eklendi.");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :"+ex);
            }
            kitapListele();
            baglanti.Close();

        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            kitapListele();
            
        }
    }
}
