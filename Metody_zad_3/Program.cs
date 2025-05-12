using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_3
{//Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
 //obliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola.
    class Program
    {
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dla r=1,5 pole={0}", pole_kola(1.5));
            Console.ReadKey(true);
        }
    }
}
