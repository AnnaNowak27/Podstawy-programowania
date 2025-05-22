using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
            //najmniejszą i największą wczytaną liczbę.
            int[] liczby = new int[1000];
            int i, n;
            Console.Write("Podaj ilość elementów n<=1000:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj liczby[{0}]= ", i);
                liczby[i] = Convert.ToInt32(Console.ReadLine()); // Wczytaj każdą liczbę
            }
            int min = liczby[0];
            int max = liczby[0];

            foreach (int liczba in liczby)
            {
                if (liczba < min) min = liczba;
                if (liczba > max) max = liczba;
            }

            Console.WriteLine("Najmniejsza: ", min);
            Console.WriteLine("Największa: ",  max);
        }
    }
}
    

