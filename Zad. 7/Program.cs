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
        {
            int[] ciag = new int[1000];
            int i, n;
            Console.Write("Podaj liczbe elem n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                Console.Write("Podaj element ciag[{0}]: ", i);
                ciag[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            for (i=0; i<n; i++)
            {
                if (ciag[i] < min)
                    min = ciag[i];
                if (ciag[i] > max)
                    max = ciag[i];
            }
            Console.Write("Najmniejszy element w tablicy to {0}, a największy to {1}.", min, max);
            Console.ReadKey(true);
        }
    }
}
