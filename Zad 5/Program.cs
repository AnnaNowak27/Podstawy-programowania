using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny czy też nie.//
            int rok;
            Console.WriteLine("Podaj rok:");
            rok = Convert.ToInt32(Console.ReadLine());
            if (((rok % 4 == 0) & (rok % 100 != 0)) || (rok % 400 == 0))
            Console.WriteLine("{0} jest rokiem przestępnym.", rok);
            else
                Console.WriteLine("{0} nie jest rokiem przestępnym", rok);
        }
    }
}
