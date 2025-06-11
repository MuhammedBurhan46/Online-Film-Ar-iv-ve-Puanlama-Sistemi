namespace FilmArşivPuanlamaSistemi
{
    partial class FilmEkleForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Tür = new MetroFramework.Controls.MetroLabel();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.txtTur = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Film adı";
            // 
            // Tür
            // 
            this.Tür.AutoSize = true;
            this.Tür.Location = new System.Drawing.Point(616, 60);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(28, 20);
            this.Tür.TabIndex = 1;
            this.Tür.Text = "Tür";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(23, 126);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(142, 23);
            this.txtAd.TabIndex = 2;
            this.txtAd.Text = "metroTextBox1";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(555, 126);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(203, 23);
            this.txtTur.TabIndex = 3;
            this.txtTur.Text = "metroTextBox2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(349, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "yıl";
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(296, 127);
            this.nudYil.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(120, 22);
            this.nudYil.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(341, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // FilmEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudYil);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Tür);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FilmEkleForm";
            this.Text = "FilmEkleForm";
            this.Load += new System.EventHandler(this.FilmEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Tür;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroTextBox txtTur;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown nudYil;
        private MetroFramework.Controls.MetroButton btnEkle;
    }
}