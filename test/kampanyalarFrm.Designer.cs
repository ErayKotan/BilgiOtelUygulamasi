namespace test
{
    partial class kampanyalarFrm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.KampanyaAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indirimorani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaslangicTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BitisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtad2 = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaciklama2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpbitis2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpbaslangic2 = new System.Windows.Forms.DateTimePicker();
            this.txtindirim2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKampanyaKaydet = new System.Windows.Forms.Button();
            this.txtKampanyaAd = new System.Windows.Forms.TextBox();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.dtpilktarih = new System.Windows.Forms.DateTimePicker();
            this.dtpikincitarih = new System.Windows.Forms.DateTimePicker();
            this.txtKampanyaAciklama = new System.Windows.Forms.TextBox();
            this.btnyenikampanya = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KampanyaAd,
            this.Indirimorani,
            this.BaslangicTarihi,
            this.BitisTarihi,
            this.aciklama});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 554);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // KampanyaAd
            // 
            this.KampanyaAd.Text = "Kampanya Ad";
            this.KampanyaAd.Width = 104;
            // 
            // Indirimorani
            // 
            this.Indirimorani.Text = "İndirim Oranı";
            this.Indirimorani.Width = 115;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.Text = "Başlangıç Tarihi";
            this.BaslangicTarihi.Width = 122;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Text = "Bitiş Tarihi";
            this.BitisTarihi.Width = 132;
            // 
            // aciklama
            // 
            this.aciklama.Text = "Açıklama";
            this.aciklama.Width = 214;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtad2);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtaciklama2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpbitis2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpbaslangic2);
            this.groupBox2.Controls.Add(this.txtindirim2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(651, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 385);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAMPANYA GÜNCELLE";
            this.groupBox2.Visible = false;
            // 
            // txtad2
            // 
            this.txtad2.Enabled = false;
            this.txtad2.Location = new System.Drawing.Point(201, 48);
            this.txtad2.Multiline = true;
            this.txtad2.Name = "txtad2";
            this.txtad2.Size = new System.Drawing.Size(172, 20);
            this.txtad2.TabIndex = 39;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Location = new System.Drawing.Point(201, 296);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 48);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(102, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "KAMPANYA ADI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(103, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "İNDİRİM ORANI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(21, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "KAMPANYA BAŞLANGIÇ TARİHİ :";
            // 
            // txtaciklama2
            // 
            this.txtaciklama2.Location = new System.Drawing.Point(201, 218);
            this.txtaciklama2.Multiline = true;
            this.txtaciklama2.Name = "txtaciklama2";
            this.txtaciklama2.Size = new System.Drawing.Size(172, 54);
            this.txtaciklama2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(54, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "KAMPANYA BİTİŞ TARİHİ :";
            // 
            // dtpbitis2
            // 
            this.dtpbitis2.Location = new System.Drawing.Point(201, 173);
            this.dtpbitis2.Name = "dtpbitis2";
            this.dtpbitis2.Size = new System.Drawing.Size(172, 20);
            this.dtpbitis2.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(67, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "KAMPANYA AÇIKLAMA :";
            // 
            // dtpbaslangic2
            // 
            this.dtpbaslangic2.Location = new System.Drawing.Point(201, 133);
            this.dtpbaslangic2.Name = "dtpbaslangic2";
            this.dtpbaslangic2.Size = new System.Drawing.Size(172, 20);
            this.dtpbaslangic2.TabIndex = 41;
            // 
            // txtindirim2
            // 
            this.txtindirim2.Location = new System.Drawing.Point(201, 87);
            this.txtindirim2.Multiline = true;
            this.txtindirim2.Name = "txtindirim2";
            this.txtindirim2.Size = new System.Drawing.Size(172, 20);
            this.txtindirim2.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKampanyaKaydet);
            this.groupBox1.Controls.Add(this.txtKampanyaAd);
            this.groupBox1.Controls.Add(this.txtIndirimOrani);
            this.groupBox1.Controls.Add(this.dtpilktarih);
            this.groupBox1.Controls.Add(this.dtpikincitarih);
            this.groupBox1.Controls.Add(this.txtKampanyaAciklama);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(651, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 385);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ KAMPANYA KAYIT";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAMPANYA ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(98, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İNDİRİM ORANI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KAMPANYA BAŞLANGIÇ TARİHİ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(49, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "KAMPANYA BİTİŞ TARİHİ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(62, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KAMPANYA AÇIKLAMA :";
            // 
            // btnKampanyaKaydet
            // 
            this.btnKampanyaKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKampanyaKaydet.Location = new System.Drawing.Point(196, 299);
            this.btnKampanyaKaydet.Name = "btnKampanyaKaydet";
            this.btnKampanyaKaydet.Size = new System.Drawing.Size(172, 48);
            this.btnKampanyaKaydet.TabIndex = 25;
            this.btnKampanyaKaydet.Text = "KAMPANYA KAYDET";
            this.btnKampanyaKaydet.UseVisualStyleBackColor = true;
            this.btnKampanyaKaydet.Click += new System.EventHandler(this.btnKampanyaKaydet_Click);
            // 
            // txtKampanyaAd
            // 
            this.txtKampanyaAd.Location = new System.Drawing.Point(196, 48);
            this.txtKampanyaAd.Multiline = true;
            this.txtKampanyaAd.Name = "txtKampanyaAd";
            this.txtKampanyaAd.Size = new System.Drawing.Size(172, 20);
            this.txtKampanyaAd.TabIndex = 26;
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.Location = new System.Drawing.Point(196, 87);
            this.txtIndirimOrani.Multiline = true;
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(172, 20);
            this.txtIndirimOrani.TabIndex = 27;
            // 
            // dtpilktarih
            // 
            this.dtpilktarih.Location = new System.Drawing.Point(196, 133);
            this.dtpilktarih.Name = "dtpilktarih";
            this.dtpilktarih.Size = new System.Drawing.Size(172, 20);
            this.dtpilktarih.TabIndex = 28;
            this.dtpilktarih.ValueChanged += new System.EventHandler(this.dtpilktarih_ValueChanged);
            // 
            // dtpikincitarih
            // 
            this.dtpikincitarih.Location = new System.Drawing.Point(196, 173);
            this.dtpikincitarih.Name = "dtpikincitarih";
            this.dtpikincitarih.Size = new System.Drawing.Size(172, 20);
            this.dtpikincitarih.TabIndex = 29;
            // 
            // txtKampanyaAciklama
            // 
            this.txtKampanyaAciklama.Location = new System.Drawing.Point(196, 218);
            this.txtKampanyaAciklama.Multiline = true;
            this.txtKampanyaAciklama.Name = "txtKampanyaAciklama";
            this.txtKampanyaAciklama.Size = new System.Drawing.Size(172, 54);
            this.txtKampanyaAciklama.TabIndex = 30;
            // 
            // btnyenikampanya
            // 
            this.btnyenikampanya.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnyenikampanya.Location = new System.Drawing.Point(781, 50);
            this.btnyenikampanya.Name = "btnyenikampanya";
            this.btnyenikampanya.Size = new System.Drawing.Size(140, 44);
            this.btnyenikampanya.TabIndex = 51;
            this.btnyenikampanya.Text = "YENİ KAMPANYA ";
            this.btnyenikampanya.UseVisualStyleBackColor = false;
            this.btnyenikampanya.Click += new System.EventHandler(this.btnyenikampanya_Click);
            // 
            // kampanyalarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.stock_photo_black_background;
            this.ClientSize = new System.Drawing.Size(1082, 710);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnyenikampanya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kampanyalarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAMPANYALAR";
            this.Load += new System.EventHandler(this.kampanyalar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader KampanyaAd;
        private System.Windows.Forms.ColumnHeader Indirimorani;
        private System.Windows.Forms.ColumnHeader BaslangicTarihi;
        private System.Windows.Forms.ColumnHeader BitisTarihi;
        private System.Windows.Forms.ColumnHeader aciklama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtad2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaciklama2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpbitis2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpbaslangic2;
        private System.Windows.Forms.TextBox txtindirim2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKampanyaKaydet;
        private System.Windows.Forms.TextBox txtKampanyaAd;
        private System.Windows.Forms.TextBox txtIndirimOrani;
        private System.Windows.Forms.DateTimePicker dtpilktarih;
        private System.Windows.Forms.DateTimePicker dtpikincitarih;
        private System.Windows.Forms.TextBox txtKampanyaAciklama;
        private System.Windows.Forms.Button btnyenikampanya;
    }
}