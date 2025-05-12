using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_4
{//Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
 //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
    class Program
    { 
        static int ile_cyfr (int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 538 ma {0} cyfry", ile_cyfr(538));
            Console.ReadKey(true);
        }
    }
}
