using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb.//
            double a, b, c, d, e, min, max;
            Console.WriteLine("Wpisz pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wypisz trzecią liczbę:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz czwartą liczbę:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz piątą liczbę:");
            e = Convert.ToDouble(Console.ReadLine());
            //liczba najmniejsza//
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza.", min);
            //liczba największa//
            max = b;
            if (a > max) max = a;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest największa.", max);


        }
    }
}
