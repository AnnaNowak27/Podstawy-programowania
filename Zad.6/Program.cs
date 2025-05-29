using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] tydzien = new string[] {"pon", "wt", "śr", "czw", "pt", "sob", "ndz"};
            foreach (string elem in tydzien)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true);
        }
    }
}
