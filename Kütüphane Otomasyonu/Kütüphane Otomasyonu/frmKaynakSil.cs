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
    public partial class frmKaynakSil : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);

        public frmKaynakSil()
        {
            InitializeComponent();
        }
        void listele()
        {

            baglanti.Open();
            String listele = "select * from Kaynaklar  ";
            SqlCommand komut = new SqlCommand(listele, baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
        private void frmKaynakSil_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            String sil = "SELECT * from Kaynaklar where kaynak_id = @kaynak_id";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            int secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@kaynak_id", secilenid);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            SqlDataReader read = komut.ExecuteReader();
                if (read.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
                {
                    string isim = read["kaynak_ad"].ToString() + " ";
                    read.Close();

                    DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz  ?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from Kaynaklar where kaynak_id=@kaynak_id";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silKomutu.Parameters.AddWithValue("@kaynak_id", secilenid);
                        SqlDataReader read1 = silKomutu.ExecuteReader();
                        MessageBox.Show("Kayıt Silindi.");

                    }
                    else
                    {
                        MessageBox.Show("Kaynak  Bulunamadı.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : "+ ex);
            }
            baglanti.Close();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
