using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class Kelime
    {
        public string kelime { get; set; }
        public int kullanimSayisi { get; set; }
        public Kelime(string kelime, int kullanimSayisi)
        {
            this.kelime = kelime;
            this.kullanimSayisi = kullanimSayisi;
        }
    }
}
