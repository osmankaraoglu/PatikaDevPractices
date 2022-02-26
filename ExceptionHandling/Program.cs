using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayı:" + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            //finally
            //{
            //    Console.WriteLine("İşlem Tamamlandı.");
            //}

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş Değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
            }

        }
    }
}
