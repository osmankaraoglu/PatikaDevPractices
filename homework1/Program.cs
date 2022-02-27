using System;

namespace homework1
{
    class Program
    {
        //1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        //2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        //3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        //4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        static void Main(string[] args)
        {
            Console.WriteLine("Çalıştırmak İstediğiniz Soruyu Yazın.(1-2-3-4)");
            int q = Convert.ToInt32(Console.ReadLine());
            switch (q)
            {
                case 1:
                    question1();
                    break;
                case 2:
                    question2();
                    break;
                case 3:
                    question3();
                    break;
                case 4:
                    question4();
                    break;
                default:
                    Console.WriteLine("Yanlış değer!");
                    break;
            }
        }

        public static void question1()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Pozitif Pozitif Sayı Giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
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
                if (item % 2 == 0)
                    Console.Write(item + " ");
            }
        }
        public static void question2()
        {
            Console.WriteLine("Pozitif 2 Sayı Giriniz!");
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
        public static void question3()
        {
            int n;
            while (true)
            {
                Console.WriteLine("Pozitif Sayı Giriniz:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    break;
                else
                    Console.WriteLine("Sayılar Pozitif Değil!");
            }

            string[] strArray = new string[n];
            Console.WriteLine(n + " Adet Pozitif Sayı Giriniz:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1 + ". Kelimeyi Giriniz:");
                strArray[i] = Convert.ToString(Console.ReadLine());
            }
            Array.Reverse(strArray);
            foreach (var item in strArray)
            {
                Console.Write(item + " ");
            }

        }
        public static void question4()
        {
            Console.WriteLine("Cümle Yazınız:");
            string cumle = Convert.ToString(Console.ReadLine());

            string[] kelimeler = cumle.Split(" ");
            int harfSayisi = 0;

            for (int i = 0; i < kelimeler.Length; i++)
                harfSayisi += kelimeler[i].Length;

            Console.WriteLine("Kelime Sayısı:" + kelimeler.Length);
            Console.WriteLine("Harf Sayısı:" + harfSayisi);
        }
    }
}
