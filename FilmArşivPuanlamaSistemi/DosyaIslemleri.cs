using System;
using System.Collections.Generic;
using System.IO;

namespace FilmArşivPuanlamaSistemi
{
    internal class DosyaIslemleri
    {
        private static string dosyaYolu = "filmler.txt";

        public static List<Film> FilmleriOku()
        {
            var filmler = new List<Film>();
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string line;
                    Film aktifFilm = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "###")
                        {
                            if (aktifFilm != null)
                            {
                                filmler.Add(aktifFilm);
                                aktifFilm = null;
                            }
                        }
                        else if (line.StartsWith("YORUM|"))
                        {
                            var parts = line.Split('|');
                            if (parts.Length >= 3)
                            {
                                var kullaniciAdi = parts[1];
                                var metin = parts[2];

                                var yorumcu = new Uye(kullaniciAdi, "");
                                var yorum = new Yorum(yorumcu, metin);
                                aktifFilm?.YorumEkle(yorum);
                            }
                        }
                        else
                        {
                            aktifFilm = Film.Parse(line);
                        }
                    }
                }
            }
            return filmler;
        }

        // Artık kullanılmıyor, dilersen silebilirsin.
        // public static void FilmeEkle(Film film) { ... }

        public static void TumFilmleriKaydet(List<Film> filmler)
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                foreach (var film in filmler)
                {
                    sw.WriteLine(film.ToString());
                    foreach (var yorum in film.Yorumlar)
                    {
                        sw.WriteLine($"YORUM|{yorum.YorumYapan.KullaniciAdi}|{yorum.Metin}");
                    }
                    sw.WriteLine("###");
                }
            }
        }
    }
}
