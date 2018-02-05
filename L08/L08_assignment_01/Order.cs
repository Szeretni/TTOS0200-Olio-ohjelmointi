using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment_01
{
    class Order
    {
        public Order()
        {
            Console.WriteLine("Order created");
        }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> orderItems = new List<OrderItem>();
        public void CreateOrderItem()
        {
            orderItems.Add(new OrderItem());
        }
    }
}
