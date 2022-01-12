
namespace Kütüphane_Otomasyonu
{
    partial class frmGüncellemeEkranı
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateGsm = new System.Windows.Forms.TextBox();
            this.lblUpdateGsm = new System.Windows.Forms.Label();
            this.lblUpdateMail = new System.Windows.Forms.Label();
            this.lblUpdateSoyad = new System.Windows.Forms.Label();
            this.lblUpdateAd = new System.Windows.Forms.Label();
            this.txtSoyadUpdate = new System.Windows.Forms.TextBox();
            this.txtMailUpdate = new System.Windows.Forms.TextBox();
            this.txtUpdateAd = new System.Windows.Forms.TextBox();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtUpdateKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(657, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUpdateGsm
            // 
            this.txtUpdateGsm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtUpdateGsm.Location = new System.Drawing.Point(466, 164);
            this.txtUpdateGsm.Name = "txtUpdateGsm";
            this.txtUpdateGsm.Size = new System.Drawing.Size(129, 20);
            this.txtUpdateGsm.TabIndex = 38;
            // 
            // lblUpdateGsm
            // 
            this.lblUpdateGsm.AutoSize = true;
            this.lblUpdateGsm.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateGsm.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateGsm.Location = new System.Drawing.Point(415, 164);
            this.lblUpdateGsm.Name = "lblUpdateGsm";
            this.lblUpdateGsm.Size = new System.Drawing.Size(45, 17);
            this.lblUpdateGsm.TabIndex = 37;
            this.lblUpdateGsm.Text = "Gsm : ";
            // 
            // lblUpdateMail
            // 
            this.lblUpdateMail.AutoSize = true;
            this.lblUpdateMail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateMail.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateMail.Location = new System.Drawing.Point(375, 125);
            this.lblUpdateMail.Name = "lblUpdateMail";
            this.lblUpdateMail.Size = new System.Drawing.Size(85, 17);
            this.lblUpdateMail.TabIndex = 35;
            this.lblUpdateMail.Text = "Mail Adresi : ";
            // 
            // lblUpdateSoyad
            // 
            this.lblUpdateSoyad.AutoSize = true;
            this.lblUpdateSoyad.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateSoyad.Location = new System.Drawing.Point(405, 87);
            this.lblUpdateSoyad.Name = "lblUpdateSoyad";
            this.lblUpdateSoyad.Size = new System.Drawing.Size(55, 17);
            this.lblUpdateSoyad.TabIndex = 34;
            this.lblUpdateSoyad.Text = "Soyad : ";
            // 
            // lblUpdateAd
            // 
            this.lblUpdateAd.AutoSize = true;
            this.lblUpdateAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateAd.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateAd.Location = new System.Drawing.Point(428, 50);
            this.lblUpdateAd.Name = "lblUpdateAd";
            this.lblUpdateAd.Size = new System.Drawing.Size(35, 17);
            this.lblUpdateAd.TabIndex = 33;
            this.lblUpdateAd.Text = "Ad : ";
            // 
            // txtSoyadUpdate
            // 
            this.txtSoyadUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtSoyadUpdate.Location = new System.Drawing.Point(466, 87);
            this.txtSoyadUpdate.Name = "txtSoyadUpdate";
            this.txtSoyadUpdate.Size = new System.Drawing.Size(129, 20);
            this.txtSoyadUpdate.TabIndex = 32;
            // 
            // txtMailUpdate
            // 
            this.txtMailUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtMailUpdate.Location = new System.Drawing.Point(466, 125);
            this.txtMailUpdate.Name = "txtMailUpdate";
            this.txtMailUpdate.Size = new System.Drawing.Size(129, 20);
            this.txtMailUpdate.TabIndex = 31;
            // 
            // txtUpdateAd
            // 
            this.txtUpdateAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtUpdateAd.Location = new System.Drawing.Point(466, 51);
            this.txtUpdateAd.Name = "txtUpdateAd";
            this.txtUpdateAd.Size = new System.Drawing.Size(129, 20);
            this.txtUpdateAd.TabIndex = 30;
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.ForeColor = System.Drawing.Color.Black;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(371, 196);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(89, 17);
            this.lblKullanıcıAdı.TabIndex = 39;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı : ";
            // 
            // txtUpdateKullanıcıAdı
            // 
            this.txtUpdateKullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtUpdateKullanıcıAdı.Location = new System.Drawing.Point(466, 196);
            this.txtUpdateKullanıcıAdı.Name = "txtUpdateKullanıcıAdı";
            this.txtUpdateKullanıcıAdı.Size = new System.Drawing.Size(129, 20);
            this.txtUpdateKullanıcıAdı.TabIndex = 40;
            // 
            // txtuserid
            // 
            this.txtuserid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtuserid.Location = new System.Drawing.Point(715, 51);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(52, 20);
            this.txtuserid.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(648, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "User Id : ";
            // 
            // frmGüncellemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1123, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtUpdateKullanıcıAdı);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.txtUpdateGsm);
            this.Controls.Add(this.lblUpdateGsm);
            this.Controls.Add(this.lblUpdateMail);
            this.Controls.Add(this.lblUpdateSoyad);
            this.Controls.Add(this.lblUpdateAd);
            this.Controls.Add(this.txtSoyadUpdate);
            this.Controls.Add(this.txtMailUpdate);
            this.Controls.Add(this.txtUpdateAd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGüncellemeEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGüncellemeEkranı";
            this.Load += new System.EventHandler(this.frmGüncellemeEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateGsm;
        private System.Windows.Forms.Label lblUpdateGsm;
        private System.Windows.Forms.Label lblUpdateMail;
        private System.Windows.Forms.Label lblUpdateSoyad;
        private System.Windows.Forms.Label lblUpdateAd;
        private System.Windows.Forms.TextBox txtSoyadUpdate;
        private System.Windows.Forms.TextBox txtMailUpdate;
        private System.Windows.Forms.TextBox txtUpdateAd;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.TextBox txtUpdateKullanıcıAdı;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label2;
    }
}