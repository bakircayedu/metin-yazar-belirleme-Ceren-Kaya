using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class LinkedListHashEntry
    {
        public string key { get; set; }
        public object value { get; set; }
        public LinkedListHashEntry next { get; set; }
        public LinkedListHashEntry(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
}
