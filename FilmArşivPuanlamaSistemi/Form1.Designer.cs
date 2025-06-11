namespace FilmArşivPuanlamaSistemi
{
    partial class Form1
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
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.cmbPuan = new System.Windows.Forms.ComboBox();
            this.btnPuanver = new System.Windows.Forms.Button();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnYorumyap = new System.Windows.Forms.Button();
            this.btnFilmekle = new System.Windows.Forms.Button();
            this.lstPopulerFilmler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstYorumlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFilmler
            // 
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 16;
            this.lstFilmler.Location = new System.Drawing.Point(20, 60);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(250, 196);
            this.lstFilmler.TabIndex = 0;
            // 
            // cmbPuan
            // 
            this.cmbPuan.FormattingEnabled = true;
            this.cmbPuan.Location = new System.Drawing.Point(290, 60);
            this.cmbPuan.Name = "cmbPuan";
            this.cmbPuan.Size = new System.Drawing.Size(100, 24);
            this.cmbPuan.TabIndex = 1;
            // 
            // btnPuanver
            // 
            this.btnPuanver.Location = new System.Drawing.Point(290, 100);
            this.btnPuanver.Name = "btnPuanver";
            this.btnPuanver.Size = new System.Drawing.Size(100, 30);
            this.btnPuanver.TabIndex = 2;
            this.btnPuanver.Text = "puanver";
            this.btnPuanver.UseVisualStyleBackColor = true;
            this.btnPuanver.Click += new System.EventHandler(this.btnPuanver_Click_1);
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(290, 150);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(200, 70);
            this.txtYorum.TabIndex = 3;
            // 
            // btnYorumyap
            // 
            this.btnYorumyap.Location = new System.Drawing.Point(290, 230);
            this.btnYorumyap.Name = "btnYorumyap";
            this.btnYorumyap.Size = new System.Drawing.Size(100, 30);
            this.btnYorumyap.TabIndex = 4;
            this.btnYorumyap.Text = "yorum yap";
            this.btnYorumyap.UseVisualStyleBackColor = true;
            this.btnYorumyap.Click += new System.EventHandler(this.btnYorumyap_Click_1);
            // 
            // btnFilmekle
            // 
            this.btnFilmekle.Location = new System.Drawing.Point(20, 270);
            this.btnFilmekle.Name = "btnFilmekle";
            this.btnFilmekle.Size = new System.Drawing.Size(100, 30);
            this.btnFilmekle.TabIndex = 5;
            this.btnFilmekle.Text = "Film ekle";
            this.btnFilmekle.UseVisualStyleBackColor = true;
            this.btnFilmekle.Click += new System.EventHandler(this.btnFilmekle_Click_1);
            // 
            // lstPopulerFilmler
            // 
            this.lstPopulerFilmler.FormattingEnabled = true;
            this.lstPopulerFilmler.ItemHeight = 16;
            this.lstPopulerFilmler.Location = new System.Drawing.Point(17, 404);
            this.lstPopulerFilmler.Name = "lstPopulerFilmler";
            this.lstPopulerFilmler.Size = new System.Drawing.Size(253, 180);
            this.lstPopulerFilmler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Popüler Filmler";
            // 
            // lstYorumlar
            // 
            this.lstYorumlar.FormattingEnabled = true;
            this.lstYorumlar.ItemHeight = 16;
            this.lstYorumlar.Location = new System.Drawing.Point(370, 404);
            this.lstYorumlar.Name = "lstYorumlar";
            this.lstYorumlar.Size = new System.Drawing.Size(226, 180);
            this.lstYorumlar.TabIndex = 8;
            this.lstYorumlar.SelectedIndexChanged += new System.EventHandler(this.lstYorumlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yorumlar";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1059, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstYorumlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPopulerFilmler);
            this.Controls.Add(this.btnFilmekle);
            this.Controls.Add(this.btnYorumyap);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.btnPuanver);
            this.Controls.Add(this.cmbPuan);
            this.Controls.Add(this.lstFilmler);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.ComboBox cmbPuan;
        private System.Windows.Forms.Button btnPuanver;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Button btnYorumyap;
        private System.Windows.Forms.Button btnFilmekle;
        private System.Windows.Forms.ListBox lstPopulerFilmler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstYorumlar;
        private System.Windows.Forms.Label label2;
    }
}

