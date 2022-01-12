
namespace Kütüphane_Otomasyonu
{
    partial class frmadminGiris
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
            this.beniHatırla = new System.Windows.Forms.CheckBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtAdminKullanıcıŞifre = new System.Windows.Forms.TextBox();
            this.lblAdminSifre = new System.Windows.Forms.Label();
            this.txtAdminKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.lblAdminKullanıcıAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beniHatırla
            // 
            this.beniHatırla.AutoSize = true;
            this.beniHatırla.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beniHatırla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.beniHatırla.Location = new System.Drawing.Point(42, 245);
            this.beniHatırla.Name = "beniHatırla";
            this.beniHatırla.Size = new System.Drawing.Size(107, 22);
            this.beniHatırla.TabIndex = 15;
            this.beniHatırla.Text = "Beni Hatırla";
            this.beniHatırla.UseVisualStyleBackColor = true;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGiris.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(59)))));
            this.btnAdminGiris.Location = new System.Drawing.Point(164, 305);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(75, 29);
            this.btnAdminGiris.TabIndex = 13;
            this.btnAdminGiris.Text = "GİRİŞ";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtAdminKullanıcıŞifre
            // 
            this.txtAdminKullanıcıŞifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtAdminKullanıcıŞifre.Location = new System.Drawing.Point(180, 188);
            this.txtAdminKullanıcıŞifre.Name = "txtAdminKullanıcıŞifre";
            this.txtAdminKullanıcıŞifre.Size = new System.Drawing.Size(144, 20);
            this.txtAdminKullanıcıŞifre.TabIndex = 12;
            // 
            // lblAdminSifre
            // 
            this.lblAdminSifre.AutoSize = true;
            this.lblAdminSifre.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblAdminSifre.Location = new System.Drawing.Point(84, 188);
            this.lblAdminSifre.Name = "lblAdminSifre";
            this.lblAdminSifre.Size = new System.Drawing.Size(47, 17);
            this.lblAdminSifre.TabIndex = 11;
            this.lblAdminSifre.Text = "Şifre : ";
            // 
            // txtAdminKullanıcıAdı
            // 
            this.txtAdminKullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtAdminKullanıcıAdı.Location = new System.Drawing.Point(180, 130);
            this.txtAdminKullanıcıAdı.Name = "txtAdminKullanıcıAdı";
            this.txtAdminKullanıcıAdı.Size = new System.Drawing.Size(144, 20);
            this.txtAdminKullanıcıAdı.TabIndex = 10;
            // 
            // lblAdminKullanıcıAd
            // 
            this.lblAdminKullanıcıAd.AutoSize = true;
            this.lblAdminKullanıcıAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminKullanıcıAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblAdminKullanıcıAd.Location = new System.Drawing.Point(39, 130);
            this.lblAdminKullanıcıAd.Name = "lblAdminKullanıcıAd";
            this.lblAdminKullanıcıAd.Size = new System.Drawing.Size(95, 17);
            this.lblAdminKullanıcıAd.TabIndex = 9;
            this.lblAdminKullanıcıAd.Text = "Kullanıcı Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Admin Giriş Ekranı";
            // 
            // frmadminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(388, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beniHatırla);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminKullanıcıŞifre);
            this.Controls.Add(this.lblAdminSifre);
            this.Controls.Add(this.txtAdminKullanıcıAdı);
            this.Controls.Add(this.lblAdminKullanıcıAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmadminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmadminGiris";
            this.Load += new System.EventHandler(this.frmadminGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox beniHatırla;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtAdminKullanıcıŞifre;
        private System.Windows.Forms.Label lblAdminSifre;
        private System.Windows.Forms.TextBox txtAdminKullanıcıAdı;
        private System.Windows.Forms.Label lblAdminKullanıcıAd;
        private System.Windows.Forms.Label label1;
    }
}