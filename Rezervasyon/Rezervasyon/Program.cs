using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AirlineRezervasyon();
            Console.ReadKey();

        }
        static string[] Koltuklar = new string[20];
        /// <summary>
        /// Rezervasyon Programı
        /// </summary>
        /// <returns></returns>
        static void AirlineRezervasyon()
        {
            int ClassTipi, Koltuknumarası;
            string YolcuAdi, YesNo;
            char Devam;
            
            Koltuklar[5] = "Oraya Koma";
            Koltuklar[13] = "Tsubasa Ozara";

            while (true)
            {
                Console.WriteLine("Business Class bölümü için 1'e basın");
                Console.WriteLine("Economy Class bölümü için 2'e basın");

                try
                {
                    ClassTipi = Convert.ToInt32(Console.ReadLine());
                    if (ClassTipi == 2)
                    {
                        if (Koltuklar[8] != null && Koltuklar[9] != null && Koltuklar[10] != null && Koltuklar[11] != null && Koltuklar[12] != null && Koltuklar[13] != null && Koltuklar[14] != null && Koltuklar[15] != null && Koltuklar[16] != null && Koltuklar[17] != null && Koltuklar[18] != null && Koltuklar[19] != null)
                        {
                            Console.WriteLine("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır.");
                            Console.WriteLine("Business Class bölümünde kalan boş koltukları görmek istermisiniz?E/H");
                            YesNo = Console.ReadLine();
                            if (YesNo == "E")
                            {
                                Console.WriteLine("Business Class bölümünde boş kalan koltuklar");
                                for (int i = 0; i < 8; i++)
                                {
                                    if (Koltuklar[i] == null)
                                    {
                                        Console.WriteLine("-" + (i + 1));
                                    }
                                }
                                Console.WriteLine("Koltuk numarası seçiniz.");
                                Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                                while (Koltuknumarası <1 || Koltuknumarası > 8)
                                {
                                    Console.WriteLine("1 ile 8 arasında sayı girin");
                                    Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Seçilen koltuk numarası: " + Koltuknumarası);
                                if (Koltuklar[Koltuknumarası - 1] != null)
                                {
                                    Console.WriteLine(Koltuknumarası + " numaralı koltuğa daha önce " + Koltuklar[Koltuknumarası - 1] + " isimli yolcuya rezerve ettiniz.");
                                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz.");

                                }
                                else
                                {
                                    Console.WriteLine("Lütfen yolcunun Adı ve Soyadını yazın");
                                    YolcuAdi = Console.ReadLine();
                                    Koltuklar[Koltuknumarası - 1] = YolcuAdi;
                                    Console.WriteLine("Business Class bölümündeki " + Koltuknumarası + " numaralı koltuğu " + YolcuAdi + " isimli yolcuya rezerve ettiniz");
                                    Console.WriteLine("Devam etmek için bir tuşa basınız.");
                                    Devam = Console.ReadKey().KeyChar;
                                }



                            }
                            else if (YesNo == "H")
                            {
                                Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");

                            }

                        }
                        else
                        {
                            Console.WriteLine("Economoy Class bölümündeki boş koltuklar");
                            for (int i = 8; i < 20; i++)
                            {
                                if (Koltuklar[i] == null)
                                {
                                    Console.WriteLine("-" + (i + 1));
                                }
                            }
                            Console.WriteLine("Koltuk numarası seçiniz");
                            Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                            while (Koltuknumarası < 9 || Koltuknumarası > 20)
                            {
                                Console.WriteLine("8 ile 20 arasında sayı girin");
                                Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Seçilen koltuk numarası: " + Koltuknumarası);
                            if (Koltuklar[Koltuknumarası - 1] != null)
                            {
                                Console.WriteLine(Koltuknumarası + " numaralı koltuğu daha önce " + Koltuklar[Koltuknumarası - 1] + " isimli yolcuya rezerve ettiniz!");
                                Console.WriteLine("Lütfen boş koltuklardan birini seçiniz");

                            }
                            else
                            {
                                Console.WriteLine("Lütfen yolcunun adını ve soyadını yazın");
                                YolcuAdi = Console.ReadLine();
                                Koltuklar[Koltuknumarası - 1] = YolcuAdi;
                                Console.WriteLine("Economy Class bölümündeki " + Koltuknumarası + " numaralı koltuğu " + YolcuAdi + " isimli yolcuya rezerve ettiniz.");
                                Console.WriteLine("Devam etmek için bir tuşa basın");
                                Devam = Console.ReadKey().KeyChar;


                            }
                        }

                    }
                    else if (ClassTipi == 1)
                    {
                        if (Koltuklar[0] != null && Koltuklar[1] != null && Koltuklar[2] != null && Koltuklar[3] != null && Koltuklar[4] != null && Koltuklar[5] != null && Koltuklar[6] != null && Koltuklar[7] != null)
                        {
                            Console.WriteLine("Seçtiğiniz Business Class bölümünde kalan boş koltuk kalmamıştır.");
                            Console.WriteLine("Economy Class bölümündeki boş koltukları görmek istermisiniz?E/H");
                            YesNo = Console.ReadLine();
                            if (YesNo == "E")
                            {
                                Console.WriteLine("Economy Class bölümünde kalan boş koltuklar");
                                for (int i = 8; i < 20; i++)
                                {
                                    if (Koltuklar[i] == null)
                                    {
                                        Console.WriteLine("-" + (i + 1));
                                    }
                                }
                                Console.WriteLine("Koltuk numarası seçiniz");
                                Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                                while (Koltuknumarası < 9 || Koltuknumarası > 20)
                                {
                                    Console.WriteLine("8 ile 20 arasında sayı girin");
                                    Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.WriteLine("Seçilen koltuk numarası: " + Koltuknumarası);
                                if (Koltuklar[Koltuknumarası - 1] != null)
                                {
                                    Console.WriteLine(Koltuknumarası + " numaralı koltuğu daha önce " + Koltuklar[Koltuknumarası - 1] + " isimli yolcuya rezerve ettiniz.");
                                    Console.WriteLine("Lütfen boş koltuklardan birini seçiniz.");

                                }
                                else
                                {
                                    Console.WriteLine("Lütfen yolcunun adını ve soyadını yazın");
                                    YolcuAdi = Console.ReadLine();
                                    Koltuklar[Koltuknumarası - 1] = YolcuAdi;
                                    Console.WriteLine("Economy Class bölümündeki " + Koltuknumarası + " numaralı koltuğu " + YolcuAdi + " isimli yolcuya rezerve ettiniz.");
                                    Console.WriteLine("Devam etmek için bir tuşa basın");
                                    Devam = Console.ReadKey().KeyChar;


                                }
                            }
                            else if (YesNo == "H")
                            {
                                Console.WriteLine("Bir sonraki uçus kayıtları 4 saat sonradır.");
                                AirlineRezervasyon();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Business Class bölümünde kalan boş koltuklar:");
                            for (int i = 0; i < 8; i++)
                            {
                                if (Koltuklar[i] == null)
                                {
                                    Console.WriteLine("-" + (i + 1));
                                }
                            }
                            Console.WriteLine("Koltuk numarası seçiniz");
                            Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                            while (Koltuknumarası < 1 || Koltuknumarası > 8)
                            {
                                Console.WriteLine("1 ile 8 arasında sayı girin");
                                Koltuknumarası = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("Seçilen koltuk numarası: " + Koltuknumarası);
                            if (Koltuklar[Koltuknumarası - 1] != null)
                            {
                                Console.WriteLine(Koltuknumarası + " numaralı koltuğu daha önce " + Koltuklar[Koltuknumarası - 1] + " isimli yolcuya rezerve ettiniz.");
                                Console.WriteLine("Lütfen boş koltuklardan birini seçiniz.");

                            }
                            else
                            {
                                Console.WriteLine("Lütfen yolcunun adını ve soyadını yazın");
                                YolcuAdi = Console.ReadLine();
                                Koltuklar[Koltuknumarası - 1] = YolcuAdi;
                                Console.WriteLine("Economy Class bölümündeki " + Koltuknumarası + " numaralı koltuğu " + YolcuAdi + " isimli yolcuya rezerve ettiniz.");
                                Console.WriteLine("Devam etmek için bir tuşa basın");
                                Devam = Console.ReadKey().KeyChar;


                            }

                        }

                    }
                    else
                    {
                        Console.Clear();
                        AirlineRezervasyon();
                    }


                }
                catch (Exception)
                {
                    Console.Clear();
                    AirlineRezervasyon();
                }
            }
            
        }


    }
}
