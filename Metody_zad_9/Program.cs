using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_9
{
    class Program
    {
        static int funkcja_kwadrat(int a, int b, int c)
        {
            if (b * b - 4 * a * c > 0)
                return 2;
            if (b * b - 4 * a * c == 0)
                return 1;
            else
                return 0;

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ta funkcja kwadratowa ma {1} miejsca zerowe.", funkcja_kwadrat(a, b, c));
            Console.ReadKey(true);

        }
    }
}
