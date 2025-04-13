using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace While.Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
            // Użyj pętli while.Np.: Dla liczby = 1342 trzeba obliczyć sumę 1 + 3 + 4 + 2.
            int n, suma = 0;
            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            Console.WriteLine("Suma cyfr wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
