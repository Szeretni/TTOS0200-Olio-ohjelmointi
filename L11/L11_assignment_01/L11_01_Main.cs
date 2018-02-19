///<summary>
///Tee delegaateilla ohjelma, jolla käyttäjä syöttää merkkijonon. Sen jälkeen käyttäjä voi valita yhden tai useamman toiminnon jota merkkijonolle tehdään. 
///Merkkijonolle pitää pystyä tekemään seuraavat toiminnot:
///- muuttaa merkkijonon kaikki kirjaimet isoiksi kirjaimiksi
///- muuttaa merkkijonon kaikki kirjaimet pieniksi kirjaimiksi
///- muuttaa merkkijonon Otsikko-tyyllin, eli ensimmäinen merkki isolla ja loput pienellä
///- kääntää merkkijonon toistepäin eli sanasta Teppo tulee oppeT.
///Eli toteuta kutakin muunnosta varten oma metodi (kaikilla metodeilla täytyy olla sama signature). 
///Luo delegaatista instanssi ja kiinnitä siihen tarvittavat metodit.Voilá.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_assignment_01
{
    class L11_01_Main
    {
        //delegate
        delegate void Formatter(string s);
        
        static void Main(string[] args)
        {
            //get an user input
            Console.Write("Write a string: ");
            string userInput = Console.ReadLine();

            //menu
            bool quit = false;
            do
            {
                //delegate
                Formatter formatter2 = new Formatter(Empty);
                Formatter formatter = null;
                Formatter formatter1 = delegate (string str) { };

                //separating each digit from input
                Console.WriteLine("1: Every letter to upper case.\n2: Every letter to lower case.\n3: First letter to upper case.\n4: Letters to reverse order.\n0: Quit");
                string order = Console.ReadLine();
                char[] cArray = order.ToArray();
                //to list
                List<int> selection = new List<int>();
                int valid;
                string s;
                foreach (char c in cArray)
                {
                    s = c.ToString();
                    bool result = int.TryParse(s, out valid);
                    selection.Add(valid);
                }

                //using delegate
                foreach (int i in selection)
                {
                    switch (i)
                    {
                        case 1:
                            formatter += Upper;
                            
                            break;
                        case 2:
                            formatter += Lower;
                            
                            break;
                        case 3:
                            formatter += Topic;
                            
                            break;
                        case 4:
                            formatter += Reverse;
                            
                            break;
                        case 0:
                            quit = true;
                            break;
                    }
                }
                //calling delegate
                formatter(userInput);
            } while (!quit);
        }

        //methods
        //needed to create delegate and add methods in loop
        static void Empty(string s)
        { 
        }

        static void Upper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }

        static void Lower(string s)
        {
            Console.WriteLine(s.ToLower());
        }

        static void Topic(string s)
        {
            s = s.ToLower();
            //syntax tip https://stackoverflow.com/questions/4135317/make-first-letter-of-a-string-upper-case-with-maximum-performance
            Console.WriteLine(s.First().ToString().ToUpper() + s.Substring(1));
        }

        static void Reverse(string s)
        {
            //syntax tip https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.reverse?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Linq.Enumerable.Reverse%60%601);k(SolutionItemsProject);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.2);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.1
            char[] reversed = s.Reverse().ToArray();
            Console.WriteLine(reversed);
        }
    }
}