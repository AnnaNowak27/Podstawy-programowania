using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_8
{
    class Program
    {
        static int rok_przestepny(int rok)
        {
            if ((rok % 4 == 0) && ((rok % 100 != 0) || (rok % 400 == 0)))
                return 1;
            else
                return 0;

        }
        static void Main(string[] args)
        {
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            Console.Write("Czy rok {0} jest przestępny: {1}.", rok, rok_przestepny(rok));
            Console.ReadKey(true);
        }
    }
}
