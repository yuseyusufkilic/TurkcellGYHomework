using System;
using System.Collections.Generic;
using System.Linq;

namespace split_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inputun boş bırakılamadığı ve 3 girişten fazla yapılamadığı senaryo üzerine bir uygulama.

            List<string> cumledekiKelimeler = new List<string>();

            a1:
            Console.WriteLine("Lütfen Ad (varsa 2.Ad) ve Soyadınızı giriniz:");
            string girilenCumle = Console.ReadLine();
            bool isEmpty = !cumledekiKelimeler.Any();

            girilenCumle = girilenCumle.Trim();
            cumledekiKelimeler = girilenCumle.Split(" ").ToList();
            

            if (cumledekiKelimeler.Count <= 3 && isEmpty!=true)
            {
                Console.WriteLine($"Hosgeldiniz {girilenCumle}");
            }

            else if (cumledekiKelimeler.Count > 3)
            {
                Console.WriteLine("3 alandan fazla giriş yapılamaz.");
                goto a1;
            }

            else if (isEmpty)
            {
                Console.WriteLine("Gerekli alanlar boş bırakılmamalıdır");
            }

            



            
          

            
        }
    }
}
