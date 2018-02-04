using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_03
{
    class L07_03_Main
    {
        static void Main(string[] args)
        {
            Team team = new Team(25);
            Random rand = new Random();
            int howManyPrints = rand.Next(0, 5);
            Console.WriteLine("Prints {0} players' last name.", howManyPrints);
            for (int i = 0; i<howManyPrints;i++)
            {
                int printPlayer = rand.Next(0, 50);
                try
                {
                    Console.WriteLine("Last name: {0}", team.players[printPlayer].LastName);
                }
                catch
                {
                    Console.WriteLine("Unkown player");
                }
            }
        }
    }
}