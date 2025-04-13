using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZAd_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta
            // prostokątnego jak na poniższym przykładzie.Użyj pętli for.
            //Dla n = 5 powinien zostać narysowany trójkąt:
            //X
            //XX
            //X X
            //X X
            //XXXXX
            int i, j, n;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (i == n || j == 1 || i == j)
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);

        }
    }
}
