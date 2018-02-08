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
        public Order(string Name,int Amount)
        {

            //orderItems.Add(new OrderItem(Name, Amount));
            int orderId = ID;
            OrderItem orderItem = new OrderItem(Name,Amount);
            Console.WriteLine("This order's id: " + orderId);
            Console.WriteLine("Items in this order: name {0}, amount {1}", orderItem.Name,orderItem.Amount);
        }

        //list
        public List<OrderItem> orderItems = new List<OrderItem>();

        //methods
        public void CreateOrderItem()
        {
            orderItems.Add(new OrderItem("temp"));
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id++;
            }
        }
        private DateTime Date { get; set; }

        //properties
        private int id = 0;
    }
}
