using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class StackNode
    {
        public object data { get; set; }
        public StackNode next { get; set; }
        public StackNode(object d, StackNode n)
        {
            data = d;
            next = n;
        }
    }
}
