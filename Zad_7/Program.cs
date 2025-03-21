using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spośród liczb od 1 do 100 wypisz na ekranie wszystkie liczby podzielne przez 13. Użyj pętli for.//
            int n;
            for (n = 1; n <= 100; n++)
                if (n % 13 == 0)
                    Console.WriteLine("{0},", n);

        }
    }
}
