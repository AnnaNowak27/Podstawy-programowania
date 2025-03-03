using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            double a, b;
            Console.WriteLine("Wpisz a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obwód={0}", a+a+b+b);
            Console.WriteLine("Pole={0}", a*b);
            Console.ReadKey(true);//pauza

        }
    }
}
