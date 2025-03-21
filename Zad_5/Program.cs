using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj pętli for. 
            int n, a, b;
            Console.WriteLine("Podaj liczbę naturalną n większą od 1:");
            n = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= n; a++)
            {
                for (b = 1; b <= a; b++)
                    Console.Write("-");
                Console.WriteLine("");
            }

        }
    }
}
