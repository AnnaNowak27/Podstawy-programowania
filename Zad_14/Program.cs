using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            for (i=0; i<=10; i++)
            {
                if (i > 0)
                    Console.WriteLine("Liczba dodatnia.", i);
                else if (i > 0)
                    Console.WriteLine("liczba ujemna.", i);
                else
                    Console.WriteLine("To jest zero.", i);

            }Console.ReadKey(true);
        }
    }
}
