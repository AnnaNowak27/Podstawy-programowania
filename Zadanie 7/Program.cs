using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący dwie liczbyb całkowite i wypisujący na ekranie iloraz tych liczb z uwzglednieniem czesci calkowitej i reszty z dzielenia//
            double a, b;
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2}R{3}", a, b, a / b, a % b);
        }
    }
}
