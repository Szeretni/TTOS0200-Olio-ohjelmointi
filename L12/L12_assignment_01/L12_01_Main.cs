///@author Hannu Oksman
///@version 2018-02-19
///<summary>
///Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella 
///heittokerralla. Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. 
///Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen 
///lukujen keskiarvo.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_01
{
    class L12_01_Main
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Dice dice = new Dice();
            DateTime stop = DateTime.Now;
            TimeSpan difference = stop - start;
            Console.WriteLine(difference);
        }
    }
}

/*
prints:
How many times you want to throw a dice? 99999999
Dice is now thrown 99999999 times
- average is 3,49994235499942
- 1 count is 16670768
- 2 count is 16658907
- 3 count is 16672691
- 4 count is 16665488
- 5 count is 16667245
- 6 count is 16664900
00:00:14.0054564
Press any key to continue . . .
*/