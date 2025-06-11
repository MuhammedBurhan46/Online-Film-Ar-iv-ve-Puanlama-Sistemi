using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmArşivPuanlamaSistemi
{
    public class Admin : Kullanici
    {
        public Admin(string kullaniciAdi, string sifre) : base(kullaniciAdi, sifre)
        {
        }

        public void FilmEkle(List<Film> filmler, Film yeniFilm)
        {
            filmler.Add(yeniFilm);
        }
    }
}
