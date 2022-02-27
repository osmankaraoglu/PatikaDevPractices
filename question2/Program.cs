using System;

namespace question2
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif 2 Sayı Giriniz");
            int n, m;
            while (true)
            {
                Console.WriteLine("1. Sayıyı Giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Giriniz:");
                m = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && m > 0)
                    break;
                else
                    Console.WriteLine("Sayılar Pozitif Değil!");
            }

            int num, i = 1;
            int[] nums = new int[n];
            Console.WriteLine(n + " Adet Pozitif Sayı Giriniz:");
            while (i <= n)
            {
                Console.WriteLine(i + ". Sayıyı Giriniz:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    nums[i - 1] = num;
                else
                    continue;
                i++;
            }


            foreach (var item in nums)
            {
                if (item % m == 0)
                    Console.Write(item + " ");
            }
        }
    }
}
