using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_modyfikacja_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę pierwszą");
            int liczba_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę drugą");
            int liczba_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wprowadz + aby dodać do siebie liczby lub - aby odjąć");
            char znak = Console.ReadLine()[0];

            
            if (znak == '+')
            {
                Console.WriteLine("twój wynik dodawania to:");
                Console.WriteLine(liczba_a + liczba_b);
            }

            else if (znak == '-')
            {
                Console.WriteLine("twój wynik odejmowania to:");
                Console.WriteLine(liczba_a - liczba_b);

            }

            else
            {
                Console.WriteLine("Podałęś niewłaściwy znak!");
            }
            Console.ReadKey();
        }
    }

}
    

