using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While.Zad._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do
            //napotkania zera. Wypisz otrzymaną sumę na ekranie.Użyj pętli do -while.
            int a, suma = 0;
            do
            {
                Console.Write("Podaj a:");
                a = Convert.ToInt32(Console.ReadLine());
                suma += a;
            }
            while (a != 0);
            Console.WriteLine("Suma wynosi {0}.", suma);
            Console.ReadKey(true);
        }
    }
}
