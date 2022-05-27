using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class Cumle
    {
        public string cumleMetni { get; set; }
        public int cumleSirasi { get; set; }
        public int kelimeSayisi { get; set; }

        public Cumle(string cumleMetni, int cumleSirasi, int kelimeSayisi)
        {
            this.cumleMetni = cumleMetni;
            this.cumleSirasi = cumleSirasi;
            this.kelimeSayisi = kelimeSayisi;
        }
    }
}
