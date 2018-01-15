/*Hannu Oksman
Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment08
{
    class Program
    {
        static void Main(string[] args)
        {
            int arbitraryLenght = 5;
            char[] answer = new char[arbitraryLenght];
            Console.Write("Give a string: ");
            for (int i = 0; i < arbitraryLenght ; i++)
            {
                answer[i] = System.Convert.ToChar(Console.Read());
            }
            char[] compare = new char[arbitraryLenght];
            for (int i = 0; i < arbitraryLenght; i++)
            {
                //reverse copying
                //-1 because otherwise arbitraryLenght would be outside of array
                compare[arbitraryLenght - 1 - i] = answer[i];
            }
            for (int i = 0; i < arbitraryLenght; i++)
            {
                if (answer[i] != compare[i]) break;
                //if last round is reached, then no difference
                if (i == arbitraryLenght - 1) Console.WriteLine("The string is a palindrome.");
            }
        }
    }
}