using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Otopark();
            
            Console.ReadKey();
        }
        /// <summary>
        /// Otopark araç seçim metotu
        /// </summary>
        static void Otopark()
        {
            Console.WriteLine("Otomobil için 1'e basın");
            Console.WriteLine("Motosiklet için 2'e basın");
            Console.WriteLine("Minibüs için 3'e basın");
            Console.WriteLine("Kamyon(ve diğer ticari araçlar) için 4'e basın");
            char secim = Console.ReadKey().KeyChar;
            if (secim == '1')
            {
                Console.Clear();
                OtoparkSure1();
            }
            else if (secim =='2')
            {
                Console.Clear();
                OtoparkSure2();

            }
            else if (secim =='3')
            {
                Console.Clear();
                OtoparkSure3();

            }
            else if (secim =='4')
            {
                Console.Clear();
                OtoparkSure4();
            }
            else
            {
                Console.Clear();
                Otopark();
            }

        }
        /// <summary>
        /// Otomobil için tarife tutarları
        /// </summary>
        static void OtoparkSure1()
        {
            try
            {
                Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
                decimal saat = Convert.ToDecimal(Console.ReadLine());
                int ilavegun = 0;
                if(saat >24)
                {
                    ilavegun += Convert.ToInt32(saat) / 24;
                }
                int hesap = 35 + 20 * ilavegun;
                if (saat >= 0 && saat <= 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 5 TL");
                }
                else if (saat > 2 && saat <= 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 10 TL");
                }
                else if (saat > 6 && saat <= 12)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 20 TL");
                }
                else if (saat > 12 && saat <= 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 35 TL");
                }
                else if (saat > 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar " + hesap +" TL");
                }
            }
            catch 
            {
                Console.Write("Lütfen geçerli bir sayı giriniz");
                OtoparkSure1();
            }
        }
        /// <summary>
        /// Motoksiklet için tarife tutarları
        /// </summary>
        static void OtoparkSure2()
        {
            try
            {
                Console.Write("Araç kaç saat boyunca park alanında kaldı?");
                decimal saat = Convert.ToDecimal(Console.ReadLine());
                int ilavegun = 0;
                if (saat > 24)
                {
                    ilavegun += Convert.ToInt32(saat) / 24;
                }
                int hesap = 12 + 10 * ilavegun;
                if (saat >= 0 && saat <= 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ücretsiz");
                }
                else if (saat > 2 && saat <= 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 3 TL");
                }
                else if (saat > 6 && saat <= 12)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 6 TL");
                }
                else if (saat > 12 && saat <= 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 12 TL");
                }
                else if (saat > 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar " + hesap + " TL");
                }
            }
            catch
            {
                Console.Write("Lütfen geçerli bir sayı giriniz");
                OtoparkSure2();
            }

        }
        /// <summary>
        /// Minibüs için tarife tutarları
        /// </summary>
        static void OtoparkSure3()
        {
            try
            {
                Console.Write("Araç kaç saat boyunca park alanında kaldı?");
                decimal saat = Convert.ToDecimal(Console.ReadLine());
                int ilavegun = 0;
                if (saat > 24)
                {
                    ilavegun += Convert.ToInt32(saat) / 24;
                }
                int hesap = 45 + 25 * ilavegun;
                if (saat >= 0 && saat <= 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 8 TL");
                }
                else if (saat > 2 && saat <= 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 16 TL");
                }
                else if (saat > 6 && saat <= 12)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 32 TL");
                }
                else if (saat > 12 && saat <= 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar 45 TL");
                }
                else if (saat > 24)
                {
                    Console.Clear();
                    Console.WriteLine("Ödenmesi gereken tutar " + hesap + " TL");
                }
            }
            catch
            {
                Console.Write("Lütfen geçerli bir sayı giriniz");
                OtoparkSure3();
            }
        }
        /// <summary>
        /// Kamyon ve diğer araçlar için tarife tutarları
        /// </summary>
        static void OtoparkSure4()
        {
            try
            {
                Console.Write("Araç kaç saat boyunca park alanında kaldı?");
                decimal saat = Convert.ToDecimal(Console.ReadLine());
                int ilavegun = 0;
                if (saat > 24)
                {
                    ilavegun += Convert.ToInt32(saat) / 24;
                }
                int hesap = 100 + 55 * ilavegun;
                if (saat >= 0 && saat <= 2)
                {
                    Console.WriteLine("Ödenmesi gereken tutar 15 TL");
                }
                else if (saat > 2 && saat <= 6)
                {
                    Console.WriteLine("Ödenmesi gereken tutar 30 TL");
                }
                else if (saat > 6 && saat <= 12)
                {
                    Console.WriteLine("Ödenmesi gereken tutar 60 TL");
                }
                else if (saat > 12 && saat <= 24)
                {
                    Console.WriteLine("Ödenmesi gereken tutar 100 TL");
                }
                else if (saat > 24)
                {
                    Console.WriteLine("Ödenmesi gereken tutar " + hesap + " TL");
                }
            }
            catch
            {
                Console.Write("Lütfen geçerli bir sayı giriniz");
                OtoparkSure4();
            }
        }

    }
}
