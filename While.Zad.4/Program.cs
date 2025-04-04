using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While.Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt posiadający n wierszy i k kolumn. Użyj pętli while
            int a, b, i, j;
            Console.Write("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= a)
            {
                j = 1;
                while (j <= b)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
            }
        }
    }
}
