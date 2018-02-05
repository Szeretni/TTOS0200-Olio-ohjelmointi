using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_ex_queue
{
    class L09_ex_queue
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");

            string first = queue.Peek();
            Console.WriteLine("First in queue is {0}",first);
            Console.WriteLine("Queue count {0}", queue.Count());

            first = queue.Dequeue();
            Console.WriteLine("First in queue is {0}", first);
            Console.WriteLine("Queue count {0}", queue.Count());
        }
    }
}
