using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("Wpisz imie");
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!",imie);
            Console.ReadKey(true);//pauza

        }
    }
}
