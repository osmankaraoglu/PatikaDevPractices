using System;
using System.Linq;

namespace MyDictionary
{
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

        public void Delete(TKey key)
        {
            if (keys.Length != 0)
            {
                TKey[] tempKey = keys;
                TValue[] tempValues = values;

                keys = new TKey[keys.Length - 1];
                values = new TValue[values.Length - 1];
                int i = 0;
                int index = 0;

                for (i = 0; i < tempKey.Length; i++)
                {
                    if (tempKey[i].ToString() == key.ToString())
                    {
                        index = i;
                        break;
                    }

                }
                for (i = 0; i < tempKey.Length; i++)
                {
                    if (i < index)
                    {
                        keys[i] = tempKey[i];
                        values[i] = tempValues[i];
                    }
                    if (i > index)
                    {
                        keys[i - 1] = tempKey[i];
                        values[i - 1] = tempValues[i];
                    }
                }
                //i = 0;
                //int j = 0;
                //while(i<keys.Length)
                //{
                //    if (j != index)
                //    {
                //        keys[i] = tempKey[j];
                //        values[i] = tempValues[j];
                //        i++;
                //    }
                //    j++;
                //}

            }
        }

        public void Delete()
        {
            if (keys.Length != 0)
            {
                TKey[] tempKey = keys;
                TValue[] tempValues = values;

                keys = new TKey[tempKey.Length - 1];
                values = new TValue[tempValues.Length - 1];

                for (int i = 0; i < keys.Length; i++)
                {
                    keys[i] = tempKey[i];
                    values[i] = tempValues[i];
                }
            }
            else
                Console.WriteLine("Cannot delete an empty Dictionary.");
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
