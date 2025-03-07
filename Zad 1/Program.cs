using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta.//
            int a;
            Console.WriteLine("Podaj liczbe calkowita");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) 
            Console.WriteLine("{0} to jest liczba parzysta", a);
            else
                Console.WriteLine("{0} to jest liczba nieparzysta", a);

        }
    }
}
