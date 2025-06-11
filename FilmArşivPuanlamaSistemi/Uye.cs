using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmArşivPuanlamaSistemi
{
    public class Uye : Kullanici
    {
        public Uye(string kullaniciAdi, string sifre) : base(kullaniciAdi, sifre)
        {
        }
        public Uye() : base("", "")
        {
        }
        public void PuanVer(Film film, int puan)
        {
            film.PuanEkle(puan);
        }

        public void YorumYap(Film film, string metin)
        {
            Yorum yorum = new Yorum(this, metin);
            film.YorumEkle(yorum);
        }
    }
}
