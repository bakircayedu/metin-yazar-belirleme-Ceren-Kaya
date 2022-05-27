using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class HeapNode
    {
        public Kelime value { get; set; }
        public HeapNode(Kelime value)
        {
            this.value = value;
        }
    }
}
