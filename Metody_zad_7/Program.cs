using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_7
{
    class Program
    {
        static int pole_deltoidu (int p, int q)
        {
            return q * p / 2;
        }
        static void Main(string[] args)
        {
            int p, q;
            Console.Write("Podaj przekątną p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj przekątną q: ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pole deltoidu o tych przekatnych wynosi {0}.", pole_deltoidu(p, q));
            Console.ReadKey(true);
        }
    }
}
