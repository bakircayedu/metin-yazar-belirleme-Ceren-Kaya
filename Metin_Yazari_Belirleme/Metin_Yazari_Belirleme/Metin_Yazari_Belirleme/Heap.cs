using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazari_Belirleme
{
    public class Heap
    {
        public HeapNode[] heapArray { get; set; }
        private int currentSize { get; set; }
        public int maxSize { get; set; }

        public Heap(int maxSize)
        {
            this.maxSize = maxSize;
            heapArray = new HeapNode[maxSize];
            currentSize = 0;
        }
        // Parametre olarak atanan kelime eğer dizi içerisinde varsa o indisdeki değerin kullanım sayısının sayısı bir arttırılır.
        public bool IsEmpty()
        {
            if (currentSize == 0)
                return true;
            else
                return false;
            
        }
        public bool Insert(string value)
        {
            if (currentSize == maxSize)
                return false;

            for (int i = 0; i < currentSize; i++)
            {
                if (heapArray[i].value.kelime == value)
                {
                    heapArray[i].value.kullanimSayisi++;
                    MoveToUp(i);
                    return true;
                }
            }
            Kelime k = new Kelime(value, 1);
            HeapNode newHeapDugumu = new HeapNode(k);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);        
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heapArray[index];
            while (index > 0 && heapArray[parent].value.kullanimSayisi < bottom.value.kullanimSayisi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapNode RemoveMax()
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].value.kullanimSayisi <
                heapArray[rightChild].value.kullanimSayisi)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.value.kullanimSayisi >= heapArray[largerChild].value.kullanimSayisi)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public Kelime[] Sort()
        {
            Kelime[] sorted = new Kelime[currentSize];
            int i = 0;
            while (!IsEmpty())
            sorted[i++] = RemoveMax().value;
            return sorted;   
        }
    }
}
