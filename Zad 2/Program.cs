using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.//
            int a;
            Console.WriteLine("Podaj liczbe calkowita");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("{0} to jest liczba dodatnia", a);
            else if (a < 0)
                Console.WriteLine("{0} to jest liczba ujemna", a);
            else
                Console.WriteLine("{0} to jest liczba zero", a);
        }
    }
}
