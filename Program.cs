using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_finalna_wersja
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

            Console.WriteLine("kalkulator obsługuje dodawanie, odejmowanie, mnożenie oraz dzielenie!");
            Console.WriteLine("Jeśli chcesz dodać liczby wpisz +, jeśli chcesz odejmować wpisz -, jeśli chcesz mnożyć użyj gwiazdki *, jeśli chcesz dzielić użyj /");
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
                    if (liczbaA == 0 || liczbaB == 0)
                    {
                        Console.WriteLine("każda liczba pomnożona przez 0 daje 0!");
                    }
                    else
                    Console.WriteLine("twój wynik mnożenia to:");
                    Console.WriteLine(liczbaA * liczbaB);
                    break;

                case '/':

                    if (liczbaA == 0 || liczbaB == 0)
                    {
                        Console.WriteLine("Nie dziel przez 0!");
                    }
                    else
                    Console.WriteLine("twój wynik dzielenia to:");
                    Console.WriteLine(liczbaA / liczbaB);
                    break;
                    




            }
            Console.ReadKey();
        }
    }
}
