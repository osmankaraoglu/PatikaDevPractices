using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den girilen sayıya kadar ortalama hesaplama
            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("ort:" + toplam / sayi);

            //'a' dan 'z' ye kadar tüm harfleri yazdırma
            char karakter = 'a';
            while (karakter < 'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            Console.WriteLine();

            Console.WriteLine("***** Foreach *****");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
                Console.WriteLine(araba);
        }
    }
}
