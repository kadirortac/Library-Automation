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
    public partial class frmOduncVer : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9SA0BTD;Initial Catalog=Kütüphane_otomasyon;Integrated Security=True");
        void listele()
        {

            baglanti.Open();
            string sec = "select * from Kayıtlar";
            SqlCommand komut = new SqlCommand(sec, baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            adapter.Fill(table);
         //   dataGridView1.DataSource = table;
            baglanti.Close();
        }
        public frmOduncVer()
        {
            InitializeComponent();
        }

        private void frmOduncVer_Load(object sender, EventArgs e)
        {
            listele();

            // istediğimiz kolonların adlarını düzenledik.
          
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int arananKullanıcı = Convert.ToInt32(txtGsm.Text);
            string sec = "select * from users_info where user_gsm=@user_gsm";
            SqlCommand komut = new SqlCommand(sec,baglanti);
            komut.Parameters.AddWithValue("@user_gsm", arananKullanıcı);
           
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read[5]);
                listBox1.Items.Add("Kullanıcı Id : "+read[0] );
                listBox1.Items.Add("Kullanıcı Ad : " + read[1]);
                listBox1.Items.Add("Kullanıcı Soyad : " + read[2]);
                listBox1.Items.Add("Kullanıcı Mail : " + read[4]);





            }




            baglanti.Close();

          

        }

        private void btnKaynakBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            listBox2.Items.Clear();
            string  arananKaynak =txtKaynak.Text;
            string sec = "select * from Kaynaklar where kaynak_ad=@kaynak_ad";
            SqlCommand komut = new SqlCommand(sec, baglanti);
            komut.Parameters.AddWithValue("@kaynak_ad", arananKaynak);

            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                listBox2.Items.Add(read[0] +  "   ");
            }
         



            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // kullanıcı seçme
            int istenenBilgi = Convert.ToInt32(listBox1.SelectedItem);
            
           // string istenenKullanıcı = "select * from users_info where user_gsm=@user_gsm";
           // SqlCommand komut = new SqlCommand(istenenKullanıcı,baglanti);
          //  komut.Parameters.AddWithValue("@user_gsm", istenenBilgi);
           // komut.ExecuteNonQuery();

            // kaynak seçme
            int secilenKaynakId = Convert.ToInt32(listBox2.SelectedItem);
       
          //  string istenenKaynak = "select * from Kaynaklar where kaynak_id=@kaynak_id";
          //  SqlCommand komut2 = new SqlCommand(istenenKaynak,baglanti);
          //  komut2.Parameters.AddWithValue("@kaynak_id", secilenKaynakId);
         //   komut2.ExecuteNonQuery();
            // kullanıcıya kitabı verme, kayıt yapma
            string ödünc = "insert into Kayıtlar(kullanıcı_id,kaynak_id)values(@kullanıcı_id,@kaynak_id)";
            SqlCommand komut3 = new SqlCommand(ödünc,baglanti);
            komut3.Parameters.AddWithValue("@kullanıcı_id", istenenBilgi);
            komut3.Parameters.AddWithValue("@kaynak_id", secilenKaynakId);
            komut3.ExecuteNonQuery();
            MessageBox.Show("istenen kaynak kullanıcıya verildi");
            baglanti.Close();
          


        }
    }
}
