
namespace Kütüphane_Otomasyonu
{
    partial class frmOduncVer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.btnKullanıcıBul = new System.Windows.Forms.Button();
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnKaynakBul = new System.Windows.Forms.Button();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Gsm :";
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(317, 48);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(164, 20);
            this.txtGsm.TabIndex = 2;
            this.txtGsm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKullanıcıBul
            // 
            this.btnKullanıcıBul.Location = new System.Drawing.Point(500, 46);
            this.btnKullanıcıBul.Name = "btnKullanıcıBul";
            this.btnKullanıcıBul.Size = new System.Drawing.Size(61, 23);
            this.btnKullanıcıBul.TabIndex = 3;
            this.btnKullanıcıBul.Text = "Bul";
            this.btnKullanıcıBul.UseVisualStyleBackColor = true;
            this.btnKullanıcıBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Location = new System.Drawing.Point(441, 20);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(0, 13);
            this.lblKullanıcı.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(218, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 186);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(667, 87);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(342, 186);
            this.listBox2.TabIndex = 6;
            // 
            // btnKaynakBul
            // 
            this.btnKaynakBul.Location = new System.Drawing.Point(948, 49);
            this.btnKaynakBul.Name = "btnKaynakBul";
            this.btnKaynakBul.Size = new System.Drawing.Size(61, 23);
            this.btnKaynakBul.TabIndex = 9;
            this.btnKaynakBul.Text = "Bul";
            this.btnKaynakBul.UseVisualStyleBackColor = true;
            this.btnKaynakBul.Click += new System.EventHandler(this.btnKaynakBul_Click);
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(765, 51);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(164, 20);
            this.txtKaynak.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kaynak Adı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ödünç Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaynakBul);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblKullanıcı);
            this.Controls.Add(this.btnKullanıcıBul);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.label1);
            this.Name = "frmOduncVer";
            this.Text = "frmOduncVer";
            this.Load += new System.EventHandler(this.frmOduncVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.Button btnKullanıcıBul;
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnKaynakBul;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}