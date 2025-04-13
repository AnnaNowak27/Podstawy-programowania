using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zad_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału.
            //Np.: dla przedziału[3, 5] mamy jedną trójkę: 3, 4, 5(bo 3 ^ 2 + 4 ^ 2 = 5 ^ 2).
            int a, b, c;
            Console.WriteLine("Podaj początek przedziłu =");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj koniec przedziału =");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= c; j++)
                {
                    for (int k = j + 1; k <= c; k++)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine("{0}, {1}, {2}", i, j, k);
                        }
                    }
                }
            }Console.ReadKey(true);
        }
    }
}
