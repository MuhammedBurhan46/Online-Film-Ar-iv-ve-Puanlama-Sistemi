using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmArşivPuanlamaSistemi
{
    public interface IYorumlanabilir
    {
        void YorumEkle(Yorum yorum);
        List<Yorum> Yorumlar { get; }
    }
}