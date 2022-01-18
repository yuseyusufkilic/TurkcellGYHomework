using System;
using System.Collections.Generic;

namespace contains_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> chars = new List<string> { "ç", "ğ", "ı", "ö", "ş", "ü" };
                List<string> charsUseFree = new List<string> { "c", "g", "i", "o", "s", "u" };

                Console.WriteLine("Kelime giriniz");
                string girilenKelime = Console.ReadLine();

                if (girilenKelime == "")
                {
                    throw new Exception("Kelime bilgisi boş girilemez");
                }



                for (int i = 0; i < chars.Count; i++)
                {
                    if (girilenKelime.Contains(chars[i]))
                    {
                        girilenKelime = girilenKelime.Replace(chars[i], charsUseFree[i]);

                    }
                }
                Console.WriteLine(girilenKelime);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
