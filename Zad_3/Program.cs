using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy 1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.
            int i, n, wynik = 0;
            Console.WriteLine("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik += i;
            Console.WriteLine("1+..+{0}={1}", n, wynik);


        }
    }
}
