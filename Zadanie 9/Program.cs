using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^2 + b^2 = {0}", a * a + b * b);
            Console.ReadKey(true);

        }
    }
}
