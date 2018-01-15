using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number > ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is one");
                    break;
                case 2:
                    Console.WriteLine("Number is two");
                    break;
                case 3:
                    Console.WriteLine("Number is three");
                    break;
                default:
                    Console.WriteLine("Joku muu luku");
                    break;
            }
            Console.ReadKey();
        }
    }
}
