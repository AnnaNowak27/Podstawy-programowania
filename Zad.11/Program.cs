using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0, j, n;
            Console.Write("Podaj liczbę naturalną:");
            n = Convert.ToInt32(Console.ReadLine());
            while ((n / 8 != 0) || ((n / 8 == 0) && (n % 8 != 0)))
            {
                tab[i++] = n % 8;
                n /= 8;
            }
            Console.Write("Liczba w systemie ósemkowym: ");
            for (j = i - 1; j >= 0; j--)
                Console.Write(tab[j]);
            Console.ReadKey(true);

        }
    }
}
