using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FilmArşivPuanlamaSistemi
{
    public partial class FilmEkleForm : MetroForm
    {
        private Admin admin;
        private List<Film> filmler;

        public FilmEkleForm(Admin admin, List<Film> filmler)
        {
            InitializeComponent();
            this.admin = admin;
            this.filmler = filmler;
            btnEkle.Click += btnEkle_Click_1;
        }

        private void FilmEkleForm_Load(object sender, EventArgs e)
        {
            nudYil.Minimum = 1900;
            nudYil.Maximum = DateTime.Now.Year + 1;
            nudYil.Value = DateTime.Now.Year;
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string tur = txtTur.Text.Trim();
            int yil = (int)nudYil.Value;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(tur))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            Film yeniFilm = new Film { Ad = ad, Tur = tur, Yil = yil };

            // Aynı isimde film zaten var mı kontrol et
            bool filmVarMi = filmler.Exists(f => f.Ad.Equals(ad, StringComparison.OrdinalIgnoreCase) && f.Yil == yil);
            if (filmVarMi)
            {
                MessageBox.Show("Bu film zaten listede mevcut.");
                return;
            }

            admin.FilmEkle(filmler, yeniFilm); // Sadece listeye ekle, dosyaya yazma!

            MessageBox.Show("Film başarıyla eklendi.");
            this.Close(); // Formu kapatınca Form1 içinde kaydedilecek
        }
    }
}
