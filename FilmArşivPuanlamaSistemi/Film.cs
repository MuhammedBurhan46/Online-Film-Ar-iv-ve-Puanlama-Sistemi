using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmArşivPuanlamaSistemi
{
    public class Film : IPuanlanabilir, IYorumlanabilir
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yil { get; set; }

        private List<int> puanlar = new List<int>();
        private List<Yorum> yorumlar = new List<Yorum>();

        public void PuanEkle(int puan)
        {
            puanlar.Add(puan);
        }

        public double OrtalamaPuan => puanlar.Count == 0 ? 0 : (double)puanlar.Sum() / puanlar.Count;

        public void YorumEkle(Yorum yorum)
        {
            yorumlar.Add(yorum);
        }

        public List<Yorum> Yorumlar => yorumlar;

        public List<Yorum> YorumlariGetir()
        {
            return yorumlar;
        }

        // Yalnızca film bilgileri + puanlar (yorumlar hariç)
        public override string ToString()
        {
            string puanStr = string.Join(",", puanlar);
            return $"{Ad};{Tur};{Yil};{puanStr}";
        }

        // Yorumlar ayrı satırda geldiği için burada yorum ayrıştırılmaz
        public static Film Parse(string satir)
        {
            var parcalar = satir.Split(';');
            var film = new Film
            {
                Ad = parcalar[0],
                Tur = parcalar[1],
                Yil = int.Parse(parcalar[2])
            };

            if (parcalar.Length > 3 && !string.IsNullOrWhiteSpace(parcalar[3]))
            {
                var puanListesi = parcalar[3].Split(',');
                foreach (var puanStr in puanListesi)
                {
                    if (int.TryParse(puanStr, out int puan))
                        film.PuanEkle(puan);
                }
            }

            return film;
        }
    }
}
