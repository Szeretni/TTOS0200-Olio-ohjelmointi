using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment02
{
    class Hissi
    {
        public void ElevatorMove()
        {
            Console.WriteLine("Elevator is now in floor: " + Level);
            Console.Write("Giva a new floor number (1-5) > ");
            int input;
            bool result = int.TryParse(Console.ReadLine(), out input);
            {
                if (result)
                {
                    if (input >= minimumLevel && input <= maximumLevel)
                    {
                        Level = input;
                    }
                    else
                    {
                        Console.WriteLine("Given floor is out of range.");
                    }
                }
                else
                {
                    Console.WriteLine("You gave invalid number.");
                }
            }
        }
        private int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        private int level = 1;
        private int minimumLevel = 1;
        private int maximumLevel = 5;
    }
}