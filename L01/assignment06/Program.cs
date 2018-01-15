/*Hannu Oksman
Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla 
matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.

Esimerkkitoiminta:
    Give distance: 250 [Enter]
    Gasoline consume is 17,55 liters and cost is 17,99 euros
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give distance: ");
            int distance = int.Parse(Console.ReadLine());
            double consumption = 7.02 / 100 * distance;
            double price = 1.595 * consumption;
            int precision = 2;
            consumption = Math.Round(consumption, precision);
            //Math.Round from Double-types help
            price = Math.Round(price, precision);
            Console.WriteLine("Gasoline consume is " + consumption + " liters and cost is " + price + " euros.");
        }
    }
}
