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
    public partial class frmKaynakGuncelle : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        void Listele()
        {
            baglanti.Open();
            String KaynakListele = "select * from Kaynaklar";
            SqlCommand komut = new SqlCommand(KaynakListele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
           
         
        }
        public frmKaynakGuncelle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmKaynakGuncelle_Load(object sender, EventArgs e)
        {

            Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                baglanti.Open();
                string guncelle = "update Kaynaklar set kaynak_ad=@kaynak_ad,kaynak_yazar=@kaynak_yazar,kaynak_yayınEvi=@kaynak_yayınEvi,kaynak_sayfaSayısı=@kaynak_sayfaSayısı,kaynak_basımTarihi=@kaynak_basımTarihi  where kaynak_id=@kaynak_id";


                SqlCommand komut = new SqlCommand(guncelle, baglanti);
                komut.Parameters.AddWithValue("@kaynak_ad", txtKaynakAdı.Text);
                komut.Parameters.AddWithValue("@kaynak_yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@kaynak_yayınEvi", txtYayınEvi.Text);
                komut.Parameters.AddWithValue("@kaynak_sayfaSayısı", Convert.ToInt32(txtSayfaSayısı.Text));
                komut.Parameters.AddWithValue("@kaynak_basımTarihi", dateTimePicker.Value);
                komut.Parameters.AddWithValue("@kaynak_id", Convert.ToInt32(txtKaynakId.Text));



                komut.ExecuteNonQuery();
                MessageBox.Show("Kaynak Güncellendi ^^");
                baglanti.Close();
                Listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :"+ex);
            }
            




        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKaynakAdı.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYayınEvi.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSayfaSayısı.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker.Value= (DateTime)dataGridView1.CurrentRow.Cells[5].Value;

        }
    }
}
