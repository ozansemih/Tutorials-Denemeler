using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiCozumleme
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SayiCozumleme();

                       
        }

        /// <summary>
        /// Girilen sayının, her basamağının basamak değerlerini verir.
        /// </summary>
        static void SayiCozumleme()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen bir sayı giriniz:");
            string kelime = Console.ReadLine();
            if (kelime == "exit")
            {

            }
            else
            {
                try
                {
                    int sayi = Convert.ToInt32(kelime);
                    Console.WriteLine("*************************");
                    int r;
                    int kuvvet = 0;
                    for (int i = sayi; i != 0; i = i / 10)
                    {

                        r = i % 10;
                        Console.WriteLine(r + " x " + Math.Pow(10, kuvvet) + " = " + r * Math.Pow(10, kuvvet));
                        kuvvet++;
                    }
                    SayiCozumleme();
                }
                catch
                {
                    Console.Write("Doğru formatta sayı girmediniz!");
                    Console.WriteLine("*************************");
                    SayiCozumleme();
                }

            }
            
        }
    }
}
