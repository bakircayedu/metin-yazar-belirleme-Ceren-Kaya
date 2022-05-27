using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class HashMap
    {
        public LinkedListHashEntry[] table;
        public int size { get; set; }
        public HashMap(int tableSize)
        {
            size = tableSize;
            table = new LinkedListHashEntry[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                table[i] = null;
            }
        }
        public object Search(string key)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                LinkedListHashEntry node = table[hash];
                while (node.next != null)
                {
                    if (node.key == key)
                    {
                        break;
                    }
                    node = node.next;
                }
                return node.value;
            }
            else
                return null;
        }
        public void Add(string key, object value)
        {
            int hash = HashValue(key) % size;
            if (table[hash] != null)
            {
                LinkedListHashEntry node = table[hash];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new LinkedListHashEntry(key, value);
            }
            else
                table[hash] = new LinkedListHashEntry(key, value);
        }
        public int HashValue(string key)
        {
            int hashVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashVal += key[i];
            }
            return hashVal;
        }
    }
}
