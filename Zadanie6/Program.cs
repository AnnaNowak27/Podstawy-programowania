using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {//Napisz program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.//
            double a, b;
            Console.Write("Podaj a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Suma = {0}", a + b);
            Console.WriteLine("Różnica = {0}", a - b);
            Console.WriteLine("Iloczyn = {0}", a * b);
            Console.WriteLine("Iloraz = {0}", a / b);
            Console.ReadKey(true);
        }
    }
}
