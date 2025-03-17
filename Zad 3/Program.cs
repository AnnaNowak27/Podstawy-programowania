using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.//
            double a, b, c;
            Console.WriteLine("Wpisz pierwszą liczbę:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wypisz trzecią liczbę:");
            c = Convert.ToDouble(Console.ReadLine());
            //liczba najmniejsza//
            if ((a < b) && (a < c))
                Console.WriteLine("Liczba a jest najmniejsza.");
            else if ((b < a) && (b < c))
                Console.WriteLine("Liczba b jest najmniejsza.");
            else
                Console.WriteLine("Liczba c jest najmniejsza.");
            //liczba największa//
            if ((a > b) && (a > c))
                Console.WriteLine("Liczba a jest największa.");
            else if ((b > a) && (b > c))
                Console.WriteLine("Liczba b jest największa.");
            else 
            Console.WriteLine("Liczba c jest największa.");




        }
    }
}
