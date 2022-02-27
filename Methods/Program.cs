using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_dönüş_tipi methodAdi parametre
            //{
            // komutlar
            // return
            //}

            int a = 2;
            int b = 3;

            int sonuc = Topla(a, b);

            Console.WriteLine(sonuc);


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(a, b);
            //ref a, ref b
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }

        static int Topla(int s1,int s2)
        {
            return s1 + s2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int s1,int s2)
            //(ref int s1, ref int s2)
        {
            s1++;
            s2++;
            return s1+s2;
        }
    }
}
