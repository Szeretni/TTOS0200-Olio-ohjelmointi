using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_01
{
    class Dice
    {
        //constructors
        public Dice()
        {
            Console.Write("How many times you want to throw a dice? ");
            int throws;
            bool parse = int.TryParse(Console.ReadLine(), out throws);
            if (!parse)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                //throws to list and print
                List<int> throwList = new List<int>();
                Random dice = new Random();
                for (int i = 0; i < throws; i++)
                {
                    throwList.Add(dice.Next(1, 7));
                }
                PrintResult(throwList);
            }
        }

        //methods
        private void PrintResult(List<int> throwList)
        {
            if (throwList.Count == 1)
            {
                Console.WriteLine("Dice, one test throw value is {0}", throwList[0]);
            }
            else
            {
                Console.WriteLine("Dice is now thrown {0} times", throwList.Count);
                Console.WriteLine("- average is {0}", throwList.Average());
                Console.WriteLine("- 1 count is {0}", throwList.FindAll(x => x == 1).Count());
                Console.WriteLine("- 2 count is {0}", throwList.FindAll(x => x == 2).Count());
                Console.WriteLine("- 3 count is {0}", throwList.FindAll(x => x == 3).Count());
                Console.WriteLine("- 4 count is {0}", throwList.FindAll(x => x == 4).Count());
                Console.WriteLine("- 5 count is {0}", throwList.FindAll(x => x == 5).Count());
                Console.WriteLine("- 6 count is {0}", throwList.FindAll(x => x == 6).Count());
            }
        }
        
        Random rand = new Random();
        private void ThrowDice()
        {

            int result = rand.Next(1, 6);
            switch (result)
            {
                case 1:
                    {
                        count1++;
                        break;
                    }
                case 2:
                    {
                        count2++;
                        break;
                    }
                case 3:
                    {
                        count3++;
                        break;
                    }
                case 4:
                    {
                        count4++;
                        break;
                    }
                case 5:
                    {
                        count5++;
                        break;
                    }
                case 6:
                    {
                        count6++;
                        break;
                    }
            }
        }

        //properties
        private int count1 = 0;
        private int count2 = 0;
        private int count3 = 0;
        private int count4 = 0;
        private int count5 = 0;
        private int count6 = 0;
    }
}
