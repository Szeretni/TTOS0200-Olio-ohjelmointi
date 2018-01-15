/*Hannu Oksman
Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean 
luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä 
artikkelista: Computers are lousy random number generators.

Esimerkkitoiminta:
Guess a number: 50 [Enter]
Number is bigger
Guess a number: 75 [Enter]
Number is smaller
Guess a number: 66 [Enter]
Great, it takes a 3 guesses!
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment06
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomInit = new Random();
            int randomNumber = randomInit.Next(0,100);
            int userNumber = 0;
            for (int i = 1; ; i++)
            {
                Console.Write("Guess a number: ");
                userNumber = System.Convert.ToInt32(Console.ReadLine());
                if (randomNumber < userNumber)
                {
                    Console.WriteLine("Number is smaller");
                }
                else if (randomNumber > userNumber)
                {
                    Console.WriteLine("Number is larger");
                }
                else if (randomNumber == userNumber)
                {
                    Console.WriteLine("Great, it took " + i + " guesses!");
                    break;
                }
            }
        }
    }
}