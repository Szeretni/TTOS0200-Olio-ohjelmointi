//Hannu Oksman
//Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give three numbers.");
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Give " + i + "st number: ");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is " + sum + " and average is " + sum / 3 + ".");
        }
    }
}
