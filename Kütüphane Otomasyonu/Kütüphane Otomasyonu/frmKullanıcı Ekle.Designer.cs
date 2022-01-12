
namespace Kütüphane_Otomasyonu.Kullanıcı
{
    partial class frmKullanıcıEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanıcıEkle));
            this.txtKullanıcıEkleGsm = new System.Windows.Forms.TextBox();
            this.lblEkleGsm = new System.Windows.Forms.Label();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.lblEkleMail = new System.Windows.Forms.Label();
            this.lblEkleSoyad = new System.Windows.Forms.Label();
            this.lblEkleAd = new System.Windows.Forms.Label();
            this.txtKullanıcıSoyadEkle = new System.Windows.Forms.TextBox();
            this.txtKullanıcıMailEkle = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdEkle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanıcıEkleGsm
            // 
            this.txtKullanıcıEkleGsm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtKullanıcıEkleGsm, "txtKullanıcıEkleGsm");
            this.txtKullanıcıEkleGsm.Name = "txtKullanıcıEkleGsm";
            // 
            // lblEkleGsm
            // 
            resources.ApplyResources(this.lblEkleGsm, "lblEkleGsm");
            this.lblEkleGsm.ForeColor = System.Drawing.Color.Black;
            this.lblEkleGsm.Name = "lblEkleGsm";
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(109)))), ((int)(((byte)(101)))));
            resources.ApplyResources(this.btnKullanıcıEkle, "btnKullanıcıEkle");
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = false;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // lblEkleMail
            // 
            resources.ApplyResources(this.lblEkleMail, "lblEkleMail");
            this.lblEkleMail.ForeColor = System.Drawing.Color.Black;
            this.lblEkleMail.Name = "lblEkleMail";
            // 
            // lblEkleSoyad
            // 
            resources.ApplyResources(this.lblEkleSoyad, "lblEkleSoyad");
            this.lblEkleSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblEkleSoyad.Name = "lblEkleSoyad";
            // 
            // lblEkleAd
            // 
            resources.ApplyResources(this.lblEkleAd, "lblEkleAd");
            this.lblEkleAd.ForeColor = System.Drawing.Color.Black;
            this.lblEkleAd.Name = "lblEkleAd";
            // 
            // txtKullanıcıSoyadEkle
            // 
            this.txtKullanıcıSoyadEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtKullanıcıSoyadEkle, "txtKullanıcıSoyadEkle");
            this.txtKullanıcıSoyadEkle.Name = "txtKullanıcıSoyadEkle";
            // 
            // txtKullanıcıMailEkle
            // 
            this.txtKullanıcıMailEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtKullanıcıMailEkle, "txtKullanıcıMailEkle");
            this.txtKullanıcıMailEkle.Name = "txtKullanıcıMailEkle";
            // 
            // txtKullanıcıAdEkle
            // 
            this.txtKullanıcıAdEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.txtKullanıcıAdEkle, "txtKullanıcıAdEkle");
            this.txtKullanıcıAdEkle.Name = "txtKullanıcıAdEkle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmKullanıcıEkle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKullanıcıEkleGsm);
            this.Controls.Add(this.lblEkleGsm);
            this.Controls.Add(this.btnKullanıcıEkle);
            this.Controls.Add(this.lblEkleMail);
            this.Controls.Add(this.lblEkleSoyad);
            this.Controls.Add(this.lblEkleAd);
            this.Controls.Add(this.txtKullanıcıSoyadEkle);
            this.Controls.Add(this.txtKullanıcıMailEkle);
            this.Controls.Add(this.txtKullanıcıAdEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanıcıEkle";
            this.Load += new System.EventHandler(this.frmKullanıcıEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanıcıEkleGsm;
        private System.Windows.Forms.Label lblEkleGsm;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Label lblEkleMail;
        private System.Windows.Forms.Label lblEkleSoyad;
        private System.Windows.Forms.Label lblEkleAd;
        private System.Windows.Forms.TextBox txtKullanıcıSoyadEkle;
        private System.Windows.Forms.TextBox txtKullanıcıMailEkle;
        private System.Windows.Forms.TextBox txtKullanıcıAdEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}