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
using Kütüphane_Otomasyonu.Kullanıcı;

namespace Kütüphane_Otomasyonu
{
    public partial class FrmislemEkranı : Form
    {
        SqlConnection baglanti = new SqlConnection(Sql_Connection_string.sqlConnection);
        public FrmislemEkranı()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmislemEkranı_Load(object sender, EventArgs e)
        {
            KullanıcıEkleIslemi.Visible = false;
            KullanıcıSilIslemi.Visible = false;
            kullanıcıGüncellemeIslemi.Visible = false;

            kitapEkleİslemi.Visible = false;
            kitapGuncellemeIslmei.Visible = false;
            kitapSilmeIslemi.Visible = false;
           
         
        }
        
        private void btnUserİslemleri_Click(object sender, EventArgs e)
        {
            
           
            if (KullanıcıEkleIslemi.Visible == false)
            {
                KullanıcıEkleIslemi.Visible = true;
                KullanıcıSilIslemi.Visible = true;
                kullanıcıGüncellemeIslemi.Visible = true;
                
            }
            else
            {
                KullanıcıEkleIslemi.Visible = false;
                KullanıcıSilIslemi.Visible = false;
                kullanıcıGüncellemeIslemi.Visible = false;
                
            }

          
        }
        private bool ekleKullanıcıDurum = false;
        private frmKullanıcıEkle ekle;
        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {

            if (ekleKullanıcıDurum==false)
            {
                ekle = new frmKullanıcıEkle();
                ekle.MdiParent = this;
                ekle.Show();
                ekleKullanıcıDurum = true;
            }
            else
            {
                ekle.Close();
                ekleKullanıcıDurum = false;
            }
         
            


        }
        frmGüncellemeEkranı güncellemeEkranı;
        private bool güncelleKullanıcıDurum = false;
        private void kullanıcıGüncellemeIslemi_Click(object sender, EventArgs e)
        {
            if (güncelleKullanıcıDurum == false)
            {
                güncellemeEkranı = new frmGüncellemeEkranı();
                güncellemeEkranı.MdiParent = this;
                güncellemeEkranı.Show();
                güncelleKullanıcıDurum = true;
            }
            else
            {
                güncellemeEkranı.Close();
                güncelleKullanıcıDurum = false;
            }
        
            
           
        }
        private bool silKullanıcıDurum = false;
        frmKullanıcıSil kullanıcıSil;
        private void KullanıcıSilIslemi_Click(object sender, EventArgs e)
        {
            if (silKullanıcıDurum == false)
            {
                kullanıcıSil = new frmKullanıcıSil();
                kullanıcıSil.MdiParent = this;
                kullanıcıSil.Show();
                silKullanıcıDurum = true;
            }
            else
            {
                kullanıcıSil.Close();
                silKullanıcıDurum = false;
            }
             

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (kitapEkleİslemi.Visible == false)
            {
                kitapEkleİslemi.Visible = true;
                kitapSilmeIslemi.Visible = true;
                kitapGuncellemeIslmei.Visible= true;
            }
            else
            {
                kitapEkleİslemi.Visible = false;
                kitapSilmeIslemi.Visible = false;
                kitapGuncellemeIslmei.Visible = false;
            }

            
        }
        private frmKitapEkle ekleKitap;
        private bool ekleKitapDurum = false;
        private void kitapEkleİslemi_Click(object sender, EventArgs e)
        {
            if (ekleKitapDurum == false)
            {
                ekleKitap = new frmKitapEkle();
                ekleKitap.MdiParent = this;
                ekleKitap.Show();
                ekleKitapDurum = true;
            }
            else
            {
                ekleKitap.Close();
                ekleKitapDurum = false;
            }
           
        }
        frmKaynakSil silKitap;
        private bool silKitapDurum = false;
        private void kitapSilmeIslemi_Click(object sender, EventArgs e)
        {
            if (silKitapDurum == false)
            {
                silKitap = new frmKaynakSil();
                silKitap.MdiParent = this;
                silKitap.Show();
                silKitapDurum = true;
            }
            else
            {
                silKitap.Close();
                silKitapDurum = false;
            }
         
           

        }
        frmKaynakGuncelle Kitapguncelle;
        private bool guncelleKitapDurum = false;
        private void kitapGuncellemeIslmei_Click(object sender, EventArgs e)
        {
            if (guncelleKitapDurum == false)
            {

                Kitapguncelle = new frmKaynakGuncelle();
                Kitapguncelle.MdiParent = this;
                Kitapguncelle.Show();
                guncelleKitapDurum = true;
            }
            else
            {
                Kitapguncelle.Close();
                guncelleKitapDurum = false;
            }

            
        }
        frmOdunc odunc;
        private bool oduncDurum = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (oduncDurum == false)
            {
                odunc = new frmOdunc();
                odunc.MdiParent = this;
                odunc.Show();
                oduncDurum = true;
            }
            else
            {
                odunc.Close();
                oduncDurum = false;
            }
     
          

        }
        frmGeriAl geriAl;
        private bool geriAlDurum = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (geriAlDurum == false)
            {
                geriAl = new frmGeriAl();
                geriAl.MdiParent = this;
                geriAl.Show();
                geriAlDurum = true;
            }
            else
            {
                geriAl.Close();
                geriAlDurum = false;
            }
      
         
        }
    }
}
