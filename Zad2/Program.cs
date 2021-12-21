using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Silnia dla liczby 9 to:");
            long wynik = 1;
            long n = 9;

            for (long i = 1; i <= n; i++)

            {
                wynik *= i;
            }
            Console.WriteLine(wynik);


            Console.WriteLine("Silnia dla liczby 20 to:");
            ulong wynik2 = 1;
            ulong x = 20;
            for (ulong i = 1; i <= x; i++)

            {
                wynik2 *= i;
            }
            Console.WriteLine(wynik2);

            Console.WriteLine("Silnia dla liczby 243 to:");
            ulong wynik3 = 1;
            for (ulong i = 1; i <= 243; i++)

            {
                wynik3 *= i;
            }
            Console.WriteLine(wynik3);
            Console.ReadKey();
        }


            
    }
}
