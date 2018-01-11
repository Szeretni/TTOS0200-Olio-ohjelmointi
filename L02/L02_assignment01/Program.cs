/*Hannu Oksman
Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
    *
    **
    ***
    ****
    *****
 
Käyttäjä antaa syötteenä tähtirivien lukumäärän. Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
Esimerkkitoiminta:
    Give a number: 3 [Enter]
    *
    **
    ***
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int answer = int.Parse(Console.ReadLine());
            for (int i = 0; i < answer;i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
