using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While.Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n).Użyj pętli while//
            int a, ba, i;
            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            i = 0;
            while (++i <= a)
            {
                ba = 2 * i - 1;
                Console.WriteLine("a({0})={1}", i, ba);
            }
        }
    }
}
