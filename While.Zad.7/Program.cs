using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While.Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.
            int n, i = 2;
            bool pierwsza = true;
            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Liczba nie jest pierwsza");
            }
            else
            {
                while (i <= Math.Sqrt(n))
                {
                    if (n % i == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                    i++;
                }
                if (pierwsza)
                {
                    Console.WriteLine("Liczba jest pierwsza");
                }
                else
                {
                    Console.WriteLine("Liczba nie jest pierwsza");
                }
            }Console.ReadKey(true);
        }
    }
}
