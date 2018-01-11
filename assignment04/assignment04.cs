/*Hannu Oksman
Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment04
{
    class assignment04
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Please give your age: ");
            age = int.Parse(Console.ReadLine());
            if (age < 18) Console.WriteLine("Underaged.");
            else if (age > 65) Console.WriteLine("Senior.");
            else Console.WriteLine("Adult.");
        }
    }
}
