using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Yazari_Belirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string metin;
        private void metinYukleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.ShowDialog();

            Stream file = ofd.OpenFile();
            StreamReader reader = new StreamReader(file);  
            metin = reader.ReadToEnd();
            dosyaYoluTxt.Text = ofd.FileName;
        }

        private void stackeOkuBtn_Click(object sender, EventArgs e)
        {
            Stack cumleStack = new Stack();
            string[] cumleler = Regex.Split(metin, @"(?<=[\.!\?])\s+");
            int cumleSayisi = cumleler.Length;


            for (int i = 0; i < cumleSayisi; i++)
            {
                int kelimeSayisi = Regex.Split(cumleler[i], " ").Length;
                Cumle cumle = new Cumle(cumleler[i], i + 1, kelimeSayisi);
                cumleStack.Push(cumle);
            }

            Stack temp = new Stack();
            while (!cumleStack.IsEmpty())
            {
                temp.Push(cumleStack.Peek());
                Cumle c = (Cumle)cumleStack.Pop();
                string item = c.kelimeSayisi + " - " + c.cumleMetni;
                cumleLb.Items.Add(item);
            }

            int toplamKelime = 0;
            int toplamCumle = 0;           
            while (!temp.IsEmpty())
            {
                Cumle c = (Cumle)temp.Peek();
                toplamKelime += c.kelimeSayisi;
                toplamCumle++;

                cumleStack.Push(temp.Pop());              
            }
            int ortalamaKelime = toplamKelime / toplamCumle;
            string item2 = "Toplam Kelime Sayısı: " + toplamKelime + " - " +
                "Toplam Cümle Sayısı: " + toplamCumle + " - " + 
                "Ortalama Kelime Sayısı: " + ortalamaKelime;
            cumleLb.Items.Add(item2);
        }

        Heap heap;
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {
            string onIslenmisMetin = Regex.Replace(metin, @"[\.!\?]", " ");
            string pattern = @"\W(?=\s)(?= )|(?<=[ ])\W+|'\w+(?= )";
            onIslenmisMetin = Regex.Replace(onIslenmisMetin, pattern, "").ToLower();
            string[] kelimeler = onIslenmisMetin.Split(" ");

            heap = new Heap(kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                heap.Insert(kelimeler[i]);
            }
        }

        Kelime[] kelimeler;
        private void KelimeleriGetirBtn_Click(object sender, EventArgs e)
        {
            kelimeler = heap.Sort();
            foreach (var item in kelimeler)
            {
                string lbItem = item.kullanimSayisi + " - " + item.kelime;
                kelimeLb.Items.Add(lbItem);
            }
        }

        private void hashBtn_Click(object sender, EventArgs e)
        {
            HashMap hash = new HashMap(kelimeler.Length);
            foreach (var item in kelimeler)
            {
                hash.Add(item.kelime, item);
            }
        }
    }
}
