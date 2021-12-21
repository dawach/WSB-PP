using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIlna_własne_cyfry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba, silnia = 1;       
            Console.WriteLine("podaj cyfre z jakiej chcesz obliczyć silnie n!");
            liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)

                silnia *= i;

            Console.WriteLine("twój wynik to:");
            Console.WriteLine(silnia);


            Console.ReadKey();
        }
    }
    
    
}