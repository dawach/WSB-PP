using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę pierwszą");
            int liczbaA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę drugą");
            //DAWID ACHREM 2021
            int liczbaB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kalkulator obsługuje dodawanie, odejmowanie i mnożenie");
            Console.WriteLine("Jeśli chcesz dodać liczby wpisz +, jeśli chcesz odejmować wpisz -, jeśli chcesz mnożyć użyj gwiazdki *");
            char symbol = Console.ReadLine()[0];


            switch (symbol)
            {
                case '+':

                    Console.WriteLine("twój wynik dodawania to:");
                    Console.WriteLine(liczbaA + liczbaB);
                    break;

                case '-':
                    Console.WriteLine("twój wynik odejmowania to:");
                    Console.WriteLine(liczbaA - liczbaB);
                    break;

                case '*':
                    Console.WriteLine("twój wynik mnożenia to:");
                    Console.WriteLine(liczbaA * liczbaB);
                    break;

                    

                    
            }
            Console.ReadKey();
        }
    }
}
    

