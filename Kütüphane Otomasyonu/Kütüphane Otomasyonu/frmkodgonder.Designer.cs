
namespace Kütüphane_Otomasyonu
{
    partial class frmKodGönder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKodGönder));
            this.lblkodGonderMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btnkodGonder = new System.Windows.Forms.Button();
            this.btnKodiste = new System.Windows.Forms.Button();
            this.lblKoduDogrula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkodGonderMail
            // 
            this.lblkodGonderMail.AutoSize = true;
            this.lblkodGonderMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkodGonderMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblkodGonderMail.Location = new System.Drawing.Point(49, 111);
            this.lblkodGonderMail.Name = "lblkodGonderMail";
            this.lblkodGonderMail.Size = new System.Drawing.Size(81, 16);
            this.lblkodGonderMail.TabIndex = 0;
            this.lblkodGonderMail.Text = "Mail Adresi :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtMail.Location = new System.Drawing.Point(156, 111);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(254, 20);
            this.txtMail.TabIndex = 2;
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.txtKod.Location = new System.Drawing.Point(156, 224);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(254, 20);
            this.txtKod.TabIndex = 3;
            // 
            // btnkodGonder
            // 
            this.btnkodGonder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkodGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkodGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkodGonder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkodGonder.Location = new System.Drawing.Point(243, 274);
            this.btnkodGonder.Name = "btnkodGonder";
            this.btnkodGonder.Size = new System.Drawing.Size(81, 28);
            this.btnkodGonder.TabIndex = 4;
            this.btnkodGonder.Text = " ";
            this.btnkodGonder.UseVisualStyleBackColor = false;
            this.btnkodGonder.Click += new System.EventHandler(this.btnkodGonder_Click);
            // 
            // btnKodiste
            // 
            this.btnKodiste.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKodiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKodiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKodiste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKodiste.Location = new System.Drawing.Point(212, 149);
            this.btnKodiste.Name = "btnKodiste";
            this.btnKodiste.Size = new System.Drawing.Size(144, 26);
            this.btnKodiste.TabIndex = 5;
            this.btnKodiste.Text = "Doğrulama Kodu İste";
            this.btnKodiste.UseVisualStyleBackColor = false;
            this.btnKodiste.Click += new System.EventHandler(this.btnKodiste_Click);
            // 
            // lblKoduDogrula
            // 
            this.lblKoduDogrula.AutoSize = true;
            this.lblKoduDogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoduDogrula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(224)))));
            this.lblKoduDogrula.Location = new System.Drawing.Point(12, 224);
            this.lblKoduDogrula.Name = "lblKoduDogrula";
            this.lblKoduDogrula.Size = new System.Drawing.Size(118, 16);
            this.lblKoduDogrula.TabIndex = 6;
            this.lblKoduDogrula.Text = "Doğrulama Kodu  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(85)))), ((int)(((byte)(59)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kod Gönder";
            // 
            // frmKodGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(510, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKoduDogrula);
            this.Controls.Add(this.btnKodiste);
            this.Controls.Add(this.btnkodGonder);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblkodGonderMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKodGönder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kod Gönder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkodGonderMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btnkodGonder;
        private System.Windows.Forms.Button btnKodiste;
        private System.Windows.Forms.Label lblKoduDogrula;
        private System.Windows.Forms.Label label1;
    }
}