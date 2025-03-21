using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który nie jest trójkątem prostokątnym. Użyj pętli for.
            int n, a, b;
            Console.WriteLine("Podaj liczbę naturalną n większą od 1:");
            n = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)
            {
                for (b = 1; b <= n - a; b++)
                    Console.Write(" ");
                for (b = 1; b <= 2*a - 1; b++)
                    Console.Write("*");
                        Console.WriteLine("");

            }
        }
    }
}
