using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_stack
{
    class L09_ex_stack
    {
        static void Main(string[] args)
        {
            Stack<string> stackStrings = new Stack<string>();
            stackStrings.Push("first");
            stackStrings.Push("second");
            stackStrings.Push("third");

            Console.WriteLine(stackStrings.Peek());
            Console.WriteLine("");

            foreach(string s in stackStrings)
            {
                Console.WriteLine(s);
            }

            string temp = stackStrings.Pop();
            Console.WriteLine("Just popped: {0}", temp);
            Console.WriteLine("Stack count: {0}", stackStrings.Count());

            stackStrings.Push(temp);
            foreach (string s in stackStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
