using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_assignment_03
{
    class Player
    {
        //constructor
        public Player(string initName)
        {
            LastName = initName;
            //Console.WriteLine("Player {0} created", LastName);
        }
        //left-right hand validation
        public string StrongSide
        {
            get
            {
                return strongSide;
            }
            set
            {
                Console.WriteLine("Set stronger side (L/R): ");
                string answer = Console.ReadLine();
                if (answer == "L")
                {
                    strongSide = answer;
                }
                else if (answer == "R")
                {
                    strongSide = answer;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
        public string LastName { get; set; }
        private string FirstName { get; set; }
        private string Position { get; set; }
        private string strongSide;
    }
}
