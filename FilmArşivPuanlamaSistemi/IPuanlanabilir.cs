using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmArşivPuanlamaSistemi
{
    public interface IPuanlanabilir
    {
        void PuanEkle(int puan);
        double OrtalamaPuan { get; }
    }
}
