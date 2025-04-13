using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While.Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący od użytkownika liczbę rzeczywistą x.
            //Wczytuj tak długo wartość zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na ekranie.Użyj pętli do -while.
            int a;
            do
            {
                Console.WriteLine("Podaj a:");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a <= 0);
            Console.WriteLine("Wczytano liczbe a = {0}", a);
        }
    }
}
