using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> myDict;
            myDict = new MyDict<string,string>();

            myDict.Add("Ad", "Osman");
            myDict.Add("Soyad", "Karaoğlu");
            myDict.Add("DogumYili", "1998");
            myDict.Add("Sehir", "Rize");
            Console.WriteLine(myDict.Count);
            myDict.Delete();
            myDict.Delete("Soyad");
            Console.WriteLine(myDict.Count);
            myDict.Print();
        }
    }
}
