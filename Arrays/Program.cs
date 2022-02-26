using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

            int[] dizi;
            dizi = new int[5];

            //değer atama
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerde dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz:");
            int diziBoyut = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziBoyut];

            for (int i = 0; i < diziBoyut; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama:" + toplam / diziBoyut);    
        }
    }
}
