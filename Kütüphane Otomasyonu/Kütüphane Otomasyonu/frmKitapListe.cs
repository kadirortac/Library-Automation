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
    public partial class frmKitapListe : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");

        public frmKitapListe()
        {
            InitializeComponent();
        }

        private void frmKitapListe_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string listele = "select * from Kaynaklar ";
            SqlCommand komut = new SqlCommand(listele,baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
    }
}
