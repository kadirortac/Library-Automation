
namespace Kütüphane_Otomasyonu
{
    partial class frmOdunc
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.btnKullanıcıBul = new System.Windows.Forms.Button();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaynakBul = new System.Windows.Forms.Button();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 99);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(739, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(263, 99);
            this.dataGridView2.TabIndex = 1;
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(484, -16);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(0, 13);
            this.lblKullanıcı.TabIndex = 8;
            // 
            // btnKullanıcıBul
            // 
            this.btnKullanıcıBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKullanıcıBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanıcıBul.Location = new System.Drawing.Point(494, 58);
            this.btnKullanıcıBul.Name = "btnKullanıcıBul";
            this.btnKullanıcıBul.Size = new System.Drawing.Size(61, 23);
            this.btnKullanıcıBul.TabIndex = 7;
            this.btnKullanıcıBul.Text = "Bul";
            this.btnKullanıcıBul.UseVisualStyleBackColor = false;
            this.btnKullanıcıBul.Click += new System.EventHandler(this.btnKullanıcıBul_Click);
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(472, 23);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(164, 20);
            this.txtGsm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(370, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Gsm :";
            // 
            // btnKaynakBul
            // 
            this.btnKaynakBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKaynakBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaynakBul.Location = new System.Drawing.Point(855, 52);
            this.btnKaynakBul.Name = "btnKaynakBul";
            this.btnKaynakBul.Size = new System.Drawing.Size(61, 23);
            this.btnKaynakBul.TabIndex = 12;
            this.btnKaynakBul.Text = "Bul";
            this.btnKaynakBul.UseVisualStyleBackColor = false;
            this.btnKaynakBul.Click += new System.EventHandler(this.btnKaynakBul_Click);
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(811, 20);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(164, 20);
            this.txtKaynak.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(709, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kaynak Adı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(636, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ödünç Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(320, 269);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(746, 197);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // frmOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1123, 494);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaynakBul);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.btnKullanıcıBul);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdunc";
            this.Load += new System.EventHandler(this.frmOdunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Button btnKullanıcıBul;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaynakBul;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}