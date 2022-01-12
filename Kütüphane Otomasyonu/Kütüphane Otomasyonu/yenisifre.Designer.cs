
namespace Kütüphane_Otomasyonu
{
    partial class frmSifreSıfırlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreSıfırlama));
            this.resetPassKontrol = new System.Windows.Forms.TextBox();
            this.resetPass = new System.Windows.Forms.TextBox();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetPassKontrol
            // 
            this.resetPassKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.resetPassKontrol.Location = new System.Drawing.Point(224, 221);
            this.resetPassKontrol.Name = "resetPassKontrol";
            this.resetPassKontrol.Size = new System.Drawing.Size(147, 20);
            this.resetPassKontrol.TabIndex = 0;
            // 
            // resetPass
            // 
            this.resetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.resetPass.Location = new System.Drawing.Point(224, 145);
            this.resetPass.Name = "resetPass";
            this.resetPass.Size = new System.Drawing.Size(147, 20);
            this.resetPass.TabIndex = 1;
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(59)))));
            this.btnSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıfırla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSıfırla.Location = new System.Drawing.Point(202, 282);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(93, 30);
            this.btnSıfırla.TabIndex = 2;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(121, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yeni Şİfre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(90, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tekrar Yeni şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifre Belirleme";
            // 
            // frmSifreSıfırlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(510, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.resetPass);
            this.Controls.Add(this.resetPassKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSifreSıfırlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırlama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resetPassKontrol;
        private System.Windows.Forms.TextBox resetPass;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}