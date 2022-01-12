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
    public partial class frmKullanıcıListele : Form
    {
        public frmKullanıcıListele()
        {
            InitializeComponent();
        }

        public void listele()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");
            baglanti.Open();
            String uyeListele = "select * from users_info";
            SqlCommand komut = new SqlCommand(uyeListele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
        private void frmüyeListele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
