
namespace Kütüphane_Otomasyonu
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.lblKullanıcıAd = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblGirisBaslık = new System.Windows.Forms.Label();
            this.txtKullanıcıŞifre = new System.Windows.Forms.TextBox();
            this.btnKullanıcıGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanıcıAd
            // 
            this.lblKullanıcıAd.AutoSize = true;
            this.lblKullanıcıAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblKullanıcıAd.Location = new System.Drawing.Point(43, 122);
            this.lblKullanıcıAd.Name = "lblKullanıcıAd";
            this.lblKullanıcıAd.Size = new System.Drawing.Size(95, 17);
            this.lblKullanıcıAd.TabIndex = 0;
            this.lblKullanıcıAd.Text = "Kullanıcı Adı : ";
            this.lblKullanıcıAd.Click += new System.EventHandler(this.lblKullanıcıAd_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(184, 122);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(144, 22);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblSifre.Location = new System.Drawing.Point(88, 180);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(47, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre : ";
            // 
            // lblGirisBaslık
            // 
            this.lblGirisBaslık.AutoSize = true;
            this.lblGirisBaslık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(109)))), ((int)(((byte)(101)))));
            this.lblGirisBaslık.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisBaslık.ForeColor = System.Drawing.Color.Moccasin;
            this.lblGirisBaslık.Location = new System.Drawing.Point(84, 49);
            this.lblGirisBaslık.Name = "lblGirisBaslık";
            this.lblGirisBaslık.Size = new System.Drawing.Size(236, 37);
            this.lblGirisBaslık.TabIndex = 3;
            this.lblGirisBaslık.Text = "Admin Giriş Paneli";
            // 
            // txtKullanıcıŞifre
            // 
            this.txtKullanıcıŞifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtKullanıcıŞifre.Location = new System.Drawing.Point(184, 180);
            this.txtKullanıcıŞifre.Name = "txtKullanıcıŞifre";
            this.txtKullanıcıŞifre.Size = new System.Drawing.Size(144, 22);
            this.txtKullanıcıŞifre.TabIndex = 4;
            // 
            // btnKullanıcıGiris
            // 
            this.btnKullanıcıGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.btnKullanıcıGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanıcıGiris.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(109)))), ((int)(((byte)(101)))));
            this.btnKullanıcıGiris.Location = new System.Drawing.Point(164, 252);
            this.btnKullanıcıGiris.Name = "btnKullanıcıGiris";
            this.btnKullanıcıGiris.Size = new System.Drawing.Size(75, 29);
            this.btnKullanıcıGiris.TabIndex = 5;
            this.btnKullanıcıGiris.Text = "GİRİŞ";
            this.btnKullanıcıGiris.UseVisualStyleBackColor = false;
            this.btnKullanıcıGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(929, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKullanıcıGiris);
            this.Controls.Add(this.txtKullanıcıŞifre);
            this.Controls.Add(this.lblGirisBaslık);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.lblKullanıcıAd);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanıcıAd;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGirisBaslık;
        private System.Windows.Forms.TextBox txtKullanıcıŞifre;
        private System.Windows.Forms.Button btnKullanıcıGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

