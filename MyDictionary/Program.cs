using System;
using System.Collections.Generic;
using System.Linq;

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
            myDict.Print();
        }
    }

    class MyDict<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDict()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }


        public void Add(TKey key, TValue value)
        {
            if (!keys.Contains(key))
            {
                TKey[] TempKey = keys;
                TValue[] TempValues = values;

                keys = new TKey[keys.Length + 1];
                values = new TValue[values.Length + 1];

                for (int i = 0; i < TempKey.Length; i++)
                {
                    keys[i] = TempKey[i];
                    values[i] = TempValues[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
            else
                Console.WriteLine(key + " Anahtar Kelimesine ait zaten bir eleman var.");
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + ": " + values[i]);
            }
        }
    }
}
