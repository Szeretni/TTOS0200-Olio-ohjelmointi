using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment_01
{
    class OrderItem
    {
        public OrderItem()
        {
            Console.WriteLine("OrderItem created");
            
        }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
