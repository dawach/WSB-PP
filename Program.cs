using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DAWID ACHREM 2021
            Console.WriteLine("Wpisz liczbę pierwszą");
            int liczbaA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę drugą");
            int liczbaB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Twój wynik mnożenia to:");

            Console.WriteLine(liczbaA * liczbaB);
            Console.ReadKey();
        }
    }
}
