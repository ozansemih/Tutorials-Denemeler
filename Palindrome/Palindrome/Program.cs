using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome();
        }
        /// <summary>
        /// Girilen sayının palindrom bir sayı olup olmadığını kontrol eder.
        /// </summary>
        static void Palindrome()
        {
            Console.WriteLine("Bir tam sayı giriniz: ");
            string kelime = Console.ReadLine();
            if (kelime == "exit")
            {

            }
            else
            {
                try
                {
                    int sayi = Convert.ToInt32(kelime);
                    int terssayi = 0;
                    int sayidegeri;
                    for (int i = sayi; i != 0; i = i / 10)
                    {
                        sayidegeri = i % 10;
                        terssayi = terssayi * 10 + sayidegeri;
                    }

                    if (terssayi == sayi)
                    {
                        Console.WriteLine("Girdiğiniz sayı bir palindromdur.");
                        Palindrome();
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz sayı bir palindrom değildir.");
                        Palindrome();
                    }
                }
                catch
                {
                    Console.WriteLine("Lütfen doğru formatta sayı giriniz");
                    Palindrome();
                }

            }

        }
    }
}
