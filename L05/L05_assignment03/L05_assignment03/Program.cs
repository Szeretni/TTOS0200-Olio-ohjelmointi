using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter integers and separate them by ','. Ie. 50,60,70,80,90.");
                Console.Write("Your input: ");
                string inputString = Console.ReadLine();
                int output = ItParser.Count(inputString);
                Console.WriteLine(output);
            }
            
        }
    }
}
