using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreGizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "";
           
            Console.WriteLine("Lütfen kullanıcı adınızı ve parolanızı girin.");
            string isim = Console.ReadLine();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    Console.Write("*"); 
                }
                else
                {
                    pass = pass.Remove(pass.Length - 1);
                    Console.Write("\b \b");
                }
            }            
            while (key.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Kullanıcı Adı : " + isim);
            Console.WriteLine("*********PAROLA TEST : " + pass);
            

            Console.ReadKey();
        }
    }
}
