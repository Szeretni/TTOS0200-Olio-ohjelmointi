using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_assignment_01
{
    class OrderItem
    {
        //constructors
        public OrderItem(string Name)
        {
            this.Name = Name;
                        //Console.WriteLine("OrderItem {0} created",Name);
        }
        public OrderItem(string Name,int Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }


        //methods
        public void ListItems()
        {
            Console.WriteLine("Available item's name: " + Name);
        }
                    /*
                    public void ListItems(List<OrderItem> list)
                    {
                        foreach (OrderItem oi in list)
                        {
                            Console.WriteLine("Available item's name: " + oi.Name);
                        }
                    }
                    */
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
