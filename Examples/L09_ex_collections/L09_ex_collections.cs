using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_collections
{
    class L09_ex_collections
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            bool result = false;

            do
            {
                Console.WriteLine("Gimme a number: ");
                string line = Console.ReadLine();

                int number;
                result = int.TryParse(line, out number);
                if (result)
                {
                    list.Add(number);
                }
            } while (result);

            string print = "";

            int j = 0;
            foreach (int number in list)
            {
                if (++j == list.Count)
                {
                    print += number.ToString();
                }
                else
                {
                    print += number.ToString() + ",";
                }
            }

            Console.WriteLine(print);

            Console.WriteLine("Average: {0}", list.Average());
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Count: {0}", list.Count());

            list.Sort();
            //sisaanrakennettu action
            list.ForEach(item => Console.Write(item + ","));
        }
    }
}