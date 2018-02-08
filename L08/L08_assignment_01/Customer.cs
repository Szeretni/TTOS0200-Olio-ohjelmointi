using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment_01
{
    class Customer
    {
        //constuctor
        public Customer()
        {
            Console.WriteLine("Customer created");
        }

        //properties
        public string Name { get; set; }
        public List<Order> orders = new List<Order>();

        //methods

        //listing buyable items
        public void AvailableItems(List<OrderItem> orderItemList)
        {
            foreach (OrderItem oi in orderItemList)
            {
                oi.ListItems();
            }
        }

        //creating order
        public void CreateOrder()
        {
            Console.Write("Add items to your order.\nGive item's name: ");
            string name = Console.ReadLine();
            Console.Write("How many pieces? ");
            int amount = 0;
            bool intParse = int.TryParse(Console.ReadLine(), out amount);
            Order order = new Order(name, amount);
        }
    }
        /*
        public void ShowOrders()
        {
            foreach (Order e in orders)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void CreateOrder()
        {
            orders.Add(new Order());
        }
        public void AddItemToOrder()
        {
            orders.Add(new Order());
        }
        */
}