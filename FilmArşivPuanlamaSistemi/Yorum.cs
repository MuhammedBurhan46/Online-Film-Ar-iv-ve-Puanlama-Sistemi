using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmArşivPuanlamaSistemi
{
    public class Yorum
    {
        public Kullanici YorumYapan { get; set; }
        public string Metin { get; set; }
        public DateTime Tarih { get; set; }

        public Yorum(Kullanici yorumYapan, string metin)
        {
            YorumYapan = yorumYapan;
            Metin = metin;
            Tarih = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{YorumYapan.KullaniciAdi} ({Tarih.ToShortDateString()}): {Metin}";
        }
    }
}
