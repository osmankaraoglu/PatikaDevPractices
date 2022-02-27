using System;

namespace question1
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    break;
            }

            int num, i=1;
            int[] nums = new int[n];
            Console.WriteLine(n + " Adet Pozitif Sayı Giriniz:");
            while(i <= n)
            {
                Console.WriteLine(i + ". Sayıyı Giriniz:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    nums[i-1] = num;
                else
                    continue;
                i++;
            }

            foreach(var item in nums){
                if (item % 2 == 0)
                    Console.Write(item + " ");
            }
        }
    }
}
