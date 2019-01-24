using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaTekrarEtmeyenSayılar
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] rastgeleDizi = new int[5];

            for (int i = 0; i < 5; i++)
            {
                rastgeleDizi[i] = random.Next(1,10);
                int j = 0;
                for ( j = 0; j < i; j++)
                {
                    if (rastgeleDizi[i]==rastgeleDizi[j])
                    {
                        break;
                    }
                }
                if (i==j)
                {
                    Console.WriteLine(rastgeleDizi[i]);
                }
                else
                {
                    i--;
                }
            }
            Console.ReadLine();
      
        }
    }
}
