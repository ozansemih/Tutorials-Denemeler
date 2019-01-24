using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaHediyeEşleştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sınıf = { "Semih", "Oğuzhan", "Bekir", "Onur", "Ceyhun", "Demet", "Elif", "Zeynep", "Müslüm", "Ahmet", "Mert", "Aysel", "Mehmet" };
            string[] sınıfVer = { "Semih", "Oğuzhan", "Bekir", "Onur", "Ceyhun", "Demet", "Elif", "Zeynep", "Müslüm", "Ahmet", "Mert", "Aysel", "Mehmet" };
            var random = new Random();
            while (sınıf[0] != null || sınıf[1] != null || sınıf[2] != null || sınıf[3] != null || sınıf[4] != null || sınıf[5] != null || sınıf[6] != null || sınıf[7] != null || sınıf[8] != null || sınıf[9] != null || sınıf[10] != null || sınıf[11] != null || sınıf[12] != null || sınıfVer[0] != null || sınıfVer[1] != null || sınıfVer[2] != null || sınıfVer[3] != null || sınıfVer[4] != null || sınıfVer[5] != null || sınıfVer[6] != null || sınıfVer[7] != null || sınıfVer[8] != null || sınıfVer[9] != null || sınıfVer[10] != null || sınıfVer[11] != null || sınıfVer[12] != null)
            {
                int i = random.Next(0, sınıf.Length);
                int j = random.Next(0, sınıf.Length);

                if (i != j && sınıf[i] != null && sınıfVer[j] != null)
                {
                    Console.WriteLine(sınıf[i] + "-" + sınıfVer[j]);
                    Array.Clear(sınıf, i, 1);
                    Array.Clear(sınıfVer, j, 1);
                }

            }

            Console.ReadLine();
        }
    }
}
