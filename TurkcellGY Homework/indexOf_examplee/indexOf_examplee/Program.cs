using System;
using System.Collections.Generic;

namespace indexOf_examplee
{
    class Program
    {
        static void Main(string[] args)
        {

            // Basit bir kayıt defteri uygulaması.

            List<string> kisiNumaralari = new List<string> { "500", "501", "502", "503" };
            List<string> isimler = new List<string> { "Yuşe", "Yusuf", "Ege", "Kılıç" };
            List<string> telefonNo = new List<string> { "000", "001", "002","003" };

            Console.WriteLine("Bulunacak kişinin kişi numarasını giriniz.");
            string arananKisi = Console.ReadLine();
            int aramaSonuc = kisiNumaralari.IndexOf(arananKisi);

            try
            {
                Console.WriteLine("Kisi No : {0} , Ad : {1} , telefonNo: {2}", kisiNumaralari[aramaSonuc], isimler[aramaSonuc], telefonNo[aramaSonuc]);
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Girişi doğru yapmadınız. Lütfen geçerli bir kisi numarasi giriniz");
            }

            

            

            

            

        }
    }
}
