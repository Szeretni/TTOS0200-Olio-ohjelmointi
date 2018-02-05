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
        private string Name { get; set; }
        private List<Order> orders = new List<Order>();

        //methods
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
    }
}
