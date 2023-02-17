using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main (string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı = " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata =" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }

            try
            {
                int a =int.Parse(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Boş karakter girdiniz");
            }

        }
    }

}