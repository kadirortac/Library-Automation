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
    public partial class frmKullanıcıSil : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        public frmKullanıcıSil()
        {
            InitializeComponent();
        }


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
        private void frmKullanıcıSil_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String sil = "SELECT * from users_info where user_id = @user_id";
                SqlCommand komut = new SqlCommand(sil, baglanti);
                int secilenid = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                komut.Parameters.AddWithValue("@user_id", secilenid);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
                {
                    string isim = read["user_ad"].ToString() + " " + read["user_soyad"].ToString();
                    read.Close();

                    DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz  ?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from users_info where user_id=@user_id";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                        silKomutu.Parameters.AddWithValue("@user_id", secilenid);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi.");

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı  Bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata:"+ex);
            }
            baglanti.Close();
            listele();


            /*
             */




        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmislemEkranı ekran = new FrmislemEkranı();
            this.Hide();
            ekran.Show();

        }
    }
}
// user_ad user_soyad user_kullanıcAdı user_sifre user_mail user_gsm