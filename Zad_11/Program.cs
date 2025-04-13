using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //12. Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for.
            //Oto wydruk dla wysokości h=6:
            //1
            //2 4
            //3 6 9
            //4 8 12 16
            //5 10 15 20 25
            //6 12 18 24 30 36
            int i, j, h;
            Console.Write("Podaj h=");
            h = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= h; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
