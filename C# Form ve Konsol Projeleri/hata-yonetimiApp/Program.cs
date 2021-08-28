using System;
using System.Collections.Generic;

namespace hata_yonetimiApp
{
    class Program
    {
        static void CheckPassword(string password)
        {
            string turkcekarakterler = "ğ,ö,ü,ı,Ğ,Ö,Ü,İ,ç,Ç,ş,Ş";
            foreach (var karakter in password)
            {
                if (turkcekarakterler.IndexOf(karakter) > -1);
                throw new Exception("PAROLA TÜRKÇE KARAKTER İÇEREMEZ.");
            }
            Console.WriteLine("GEÇERLİ PAROLA.");
        }

        static void Main(string[] args)
        {
            //var liste = new List<string>()
            //{
            //    "1","2","5a","10b","abc","10","50"
            //};

            //foreach (var item in liste)
            //{
            //    try
            //    {
            //        int a = int.Parse(item);
            //        Console.WriteLine(a);
            //    }
            //    catch (Exception)
            //    {
            //        continue;
            //    }
            //}

            //while (true)
            //{
            //    Console.Write("Sayı: ");
            //    string input = Console.ReadLine();

            //    if (input == "q")
            //        break;
            //    try
            //    {
            //        int sayi = int.Parse(input);
            //        Console.WriteLine("Girdiğiniz Sayı: {0}", sayi);

            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Geçersiz Sayı.");
            //        continue;
            //    }


            // TÜRKÇE KARAKTER ARAMASI YAPINIZ.

            Console.Write("Parola: ");
            string password = Console.ReadLine();

            try
            {
                CheckPassword(password);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

           }

        }
    }

