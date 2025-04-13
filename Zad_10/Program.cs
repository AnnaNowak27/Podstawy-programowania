using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać od użytkownika. Przykładowo dla n = 3 należy obliczyć sumę 1 + 3 + 5. Do obliczenia wartości sumy użyj pętli for.
            int i, n, wynik = 0;
            Console.WriteLine("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik += (2 * i - 1);
            Console.WriteLine("Suma {0} początkowych liczb nieparzystych wynosi {1}", n, wynik);
            Console.ReadKey(true);





        }
    }
}
