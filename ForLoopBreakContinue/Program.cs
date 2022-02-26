using System;

namespace ForLoopBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayıya kadar ekrana  tek sayıları yazdıdır.
            Console.WriteLine("Lütfen Bir Sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 0; i < sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların ayrı ayrı toplamı
            int tekToplam = 0, ciftToplam = 0;
            for(int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Çift Toplam:" + ciftToplam);

            //Break, Continue

            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                if (i == 7)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 5)
                        break;
                    Console.WriteLine("i:" + i + " j:" + j);
                }
            }

        }
    }
}
