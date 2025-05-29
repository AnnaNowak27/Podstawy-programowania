using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, dodatnie = 0, zero = 0, ujemne = 0;
            Console.Write("Podaj liczbe elem n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj element ciag[{0}]: ", i);
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i=0; i<n; i++)
            {
                if (liczby[i] > 0) dodatnie += 1;
                if (liczby[i] == 0) zero += 1;
                else ujemne += 1;
            }
            Console.Write("W tablicy jest {0} liczb dodatnich, {1} liczb ujemnych i {2} równych zero.", dodatnie, ujemne, zero);
            Console.ReadKey(true);
        }
    }
}
