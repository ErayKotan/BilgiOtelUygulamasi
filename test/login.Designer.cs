namespace test
{
    partial class login
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
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Lavender;
            this.btngiris.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngiris.Location = new System.Drawing.Point(180, 385);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(268, 81);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "GİRİŞ YAP";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtsifre.Location = new System.Drawing.Point(218, 342);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(213, 17);
            this.txtsifre.TabIndex = 4;
            // 
            // txtkullanici
            // 
            this.txtkullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullanici.CausesValidation = false;
            this.txtkullanici.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtkullanici.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtkullanici.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtkullanici.Location = new System.Drawing.Point(218, 287);
            this.txtkullanici.Margin = new System.Windows.Forms.Padding(4);
            this.txtkullanici.Multiline = true;
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(213, 24);
            this.txtkullanici.TabIndex = 3;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.login2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(614, 620);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanici);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullanici;
    }
}

