using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metody_zad_5
{//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
 //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
//utworzonej funkcji.
    class Program
    {
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % 1 == 0) return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 11 jest liczba pierwsza: {0}", czy_pierwsza(11));
            Console.WriteLine("Czy 15 jest liczba pierwsza: {0}", czy_pierwsza(15));
            Console.ReadKey(true);
        }
    }
}
