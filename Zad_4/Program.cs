using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt posiadający n wierszy i k kolumn. Użyj pętli for.
            double n, k, a, b;
            Console.WriteLine("Podaj liczbę dodatnią k:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Poaj liczbę dodatnią n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (a=1; a<=k; a++)
            {
                for (b = 1; b <= n; b++)
                    Console.Write("-");
                Console.WriteLine("");
            }
        }
    }
}
