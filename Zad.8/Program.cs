using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, an;
            Console.Write("Podaj n:");
            n = Convert.ToDouble(Console.ReadLine());
            an = 3 * n - 1;
            Console.WriteLine("a{0} = 3*n-1 = {1}", n, an);
            Console.ReadKey(true);

        }
    }
}
