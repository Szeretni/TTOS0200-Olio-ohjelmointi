using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //parsing
            double number = 0;
            string line = Console.ReadLine();

            bool result = double.TryParse(line, out number);

            if (result)
            {
                Console.WriteLine("Success: " + number);
            }
            else
            {
                Console.WriteLine("NaN");
            }

            //casting
            int i = 54321;
            long n = i;
            byte c = (byte)n;

            Console.WriteLine("n: " + n);
            Console.WriteLine("c: " + c);

            double d = 654321.9987;
            int j = (int)(d+0.5);

            Console.WriteLine("d: " + d);
            Console.WriteLine("j: " + j);

            int k = Convert.ToInt32(d);
            Console.WriteLine("k: " + k);

            int ii = int.MaxValue;
            Console.WriteLine("ii: " + ii);

            int jj = int.MinValue;
            Console.WriteLine("jj: " + jj);

            double dd = double.MaxValue;
            Console.WriteLine("dd: " + dd);

            float f = float.MaxValue;
            Console.WriteLine("f: " + f);
        }
    }
}
