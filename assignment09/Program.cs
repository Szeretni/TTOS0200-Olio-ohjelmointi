/*
 * Hannu Oksman
 * Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa 
 * syötettyjen lukujen summa.
Esimerkkitoiminta:
    Give a number: 10 [Enter]
    Give a number: 20 [Enter]
    Give a number: 30 [Enter]
    Give a number: 0 [Enter]
    Sum is 60
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment09
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            while (true)
            {
                Console.Write("Give a number: ");
                string answer = Console.ReadLine();
                if (answer != "0") number += double.Parse(answer);
                else break;
            }
            Console.WriteLine("Sum is " + number + ".");
        }
    }
}
