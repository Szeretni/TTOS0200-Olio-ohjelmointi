/*Hannu Oksman
Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
Algoritmi:
4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
Esimerkkitoiminta:
    Give a year: 1992 [Enter]
    Year is a leap year.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a year: ");
            int year = System.Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && !(year % 100 == 0)) || (year % 400 == 0)) Console.WriteLine("Year is a leap year.");
        }
    }
}
