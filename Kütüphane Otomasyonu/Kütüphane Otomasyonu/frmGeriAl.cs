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
    public partial class frmGeriAl : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        void Listele()
        {

            baglanti.Open();
            bool iadeDurum = false;
            string getir = "select * from Kayıtlar where durum=@durum";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@durum", iadeDurum);
            SqlDataReader read = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public frmGeriAl()
        {
            InitializeComponent();
        }

        private void frmGeriAl_Load(object sender, EventArgs e)
        {

            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string geriAl = "update Kayıtlar set durum=@durum where  kayıt_id=@kayıt_id ";
            SqlCommand komut = new SqlCommand(geriAl,baglanti);
            komut.Parameters.AddWithValue("@durum",true);
            komut.Parameters.AddWithValue("@kayıt_id", secilenId);

            SqlDataReader read = komut.ExecuteReader();
            MessageBox.Show("İade Yapıldı  ^^");
            baglanti.Close();
            Listele();
        }
    }
}
