using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FilmArşivPuanlamaSistemi
{
    public partial class Form1 : MetroForm
    {
        private List<Film> filmler = new List<Film>();
        private Kullanici girisYapan;

        public Form1(Kullanici kullanici)
        {
            InitializeComponent();
            girisYapan = kullanici;

            // Sadece admin ise film ekleme butonu görünür
            btnFilmekle.Visible = girisYapan is Admin;

            // Puan comboBox'ını 1'den 10'a doldur
            for (int i = 1; i <= 10; i++)
            {
                cmbPuan.Items.Add(i);
            }
            cmbPuan.SelectedIndex = 0;

            filmler = DosyaIslemleri.FilmleriOku();

            GuncelleFilmListesi();

            // Film seçimi değişince yorumları güncelle
            lstFilmler.SelectedIndexChanged += lstFilmler_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuncellePopulerFilmler();
        }

        private void GuncelleFilmListesi()
        {
            lstFilmler.Items.Clear();
            foreach (var film in filmler)
            {
                lstFilmler.Items.Add($"{film.Ad} ({film.Yil}) - {film.Tur}");
            }

            GuncellePopulerFilmler(); // Popüler filmleri de güncelle
        }

        private void GuncellePopulerFilmler()
        {
            lstPopulerFilmler.Items.Clear();

            var populerFilmler = filmler
                .Where(f => f.OrtalamaPuan > 0)
                .OrderByDescending(f => f.OrtalamaPuan)
                .Take(5);

            foreach (var film in populerFilmler)
            {
                lstPopulerFilmler.Items.Add($"{film.Ad} ({film.Yil}) - Puan: {film.OrtalamaPuan:F2}");
            }

            if (!populerFilmler.Any())
            {
                lstPopulerFilmler.Items.Add("Henüz puan verilmiş film yok.");
            }
        }

        private void btnFilmekle_Click_1(object sender, EventArgs e)
        {
            if (girisYapan is Admin admin)
            {
                FilmEkleForm form = new FilmEkleForm(admin, filmler);
                form.FormClosed += (s, args) =>
                {
                    GuncelleFilmListesi();
                    DosyaIslemleri.TumFilmleriKaydet(filmler);
                };
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sadece admin kullanıcı film ekleyebilir.");
            }
        }

        private void btnPuanver_Click_1(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce bir film seçin.");
                return;
            }

            var secilenFilm = filmler[lstFilmler.SelectedIndex];
            int puan = (int)cmbPuan.SelectedItem;
            secilenFilm.PuanEkle(puan);

            // Kalıcı olarak kaydet
            DosyaIslemleri.TumFilmleriKaydet(filmler);

            MessageBox.Show($"\"{secilenFilm.Ad}\" filmine {puan} puan verdiniz.");

            GuncellePopulerFilmler(); // Yeni puana göre güncelle
        }

        private void btnYorumyap_Click_1(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce bir film seçin.");
                return;
            }

            string yorumMetni = txtYorum.Text.Trim();
            if (string.IsNullOrEmpty(yorumMetni))
            {
                MessageBox.Show("Lütfen yorum metni girin.");
                return;
            }

            var secilenFilm = filmler[lstFilmler.SelectedIndex];
            Yorum yorum = new Yorum(girisYapan, yorumMetni);
            secilenFilm.YorumEkle(yorum);
            txtYorum.Clear();

            // Kalıcı olarak kaydet
            DosyaIslemleri.TumFilmleriKaydet(filmler);

            MessageBox.Show($"\"{secilenFilm.Ad}\" filmine yorumunuz eklendi.");

            GuncelleYorumListesi(secilenFilm);
        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
            {
                lstYorumlar.Items.Clear();
                return;
            }

            var secilenFilm = filmler[lstFilmler.SelectedIndex];
            GuncelleYorumListesi(secilenFilm);
        }
        private void lstYorumlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Boş bırakılabilir, istersen ileride kullanabilirsin.
        }

        private void GuncelleYorumListesi(Film film)
        {
            lstYorumlar.Items.Clear();

            if (film.Yorumlar.Count == 0)
            {
                lstYorumlar.Items.Add("Henüz yorum yok.");
                return;
            }

            foreach (var yorum in film.Yorumlar)
            {
                lstYorumlar.Items.Add($"{yorum.YorumYapan.KullaniciAdi}: {yorum.Metin}");
            }
        }

       
    }
}

