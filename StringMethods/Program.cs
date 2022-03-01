using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "C# Dersimize Hoşgeldiniz!";
            string degisken2 = "Dersimiz C#";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //-1, 0, 1
            Console.WriteLine(string.Compare(degisken, degisken2, true)); //3. parametre true ise büyük kücük har duyarlı

            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); // içinde varsa true
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz!"));

            //indexOf
            Console.WriteLine(degisken.IndexOf("De")); //d'nin indexini verir
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //Padleft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); // 10. indexden sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); // 5. den sonra 3 karakter siler
            Console.WriteLine(degisken.Remove(0,1)); // ilk eleman silme

            //Replace
            Console.WriteLine(degisken.Replace("C#", "CSharp"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4)); //4. den sona yazdır
            Console.WriteLine(degisken.Substring(4,6));//4. den başla 6 karakter getir
        }
    }
}
