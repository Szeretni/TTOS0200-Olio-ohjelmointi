/*Hannu Oksman
Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
Esimerkkitoiminta:
    Give a number: 5 [Enter]
    Give a number: 15 [Enter]
    Give a number: 7 [Enter]
    The biggest number is 15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment08
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0, temp;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Give a number: ");
                temp = double.Parse(Console.ReadLine());
                if (temp > answer) answer = temp;
            }
            Console.WriteLine("The biggest number is " + answer);
        }
    }
}
