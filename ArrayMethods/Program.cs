using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 14, 51, 6, 2, 44, 6, 7, 1, 5 };
            foreach (var num in sayiDizisi)
                Console.Write(num + " ");
            Console.WriteLine();

            // sort
            Console.WriteLine("***** Sort method *****");

            Array.Sort(sayiDizisi);
            foreach (var num in sayiDizisi)
                Console.Write(num + " ");
            Console.WriteLine();


            //Clear
            Console.WriteLine("***** Clear Method *****");

            Array.Clear(sayiDizisi, 2, 2);
            foreach (var num in sayiDizisi)
                Console.Write(num + " ");
            Console.WriteLine();

            //Reverse
            Console.WriteLine("***** Reverse Method *****");

            Array.Reverse(sayiDizisi);
            foreach (var num in sayiDizisi)
                Console.Write(num + " ");
            Console.WriteLine();

            //indexOf
            Console.WriteLine("***** IndexOf Method *****");

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            Console.WriteLine("***** Resize Method *****");

            Array.Resize<int>(ref sayiDizisi, 11);
            sayiDizisi[10] = 99;
            foreach (var num in sayiDizisi)
                Console.Write(num + " ");
            Console.WriteLine();

        }
    }
}
