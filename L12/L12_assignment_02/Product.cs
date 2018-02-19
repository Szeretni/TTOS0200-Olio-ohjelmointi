using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_02
{
    class Product
    {
        //constructor
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        //method
        public string PrintProduct()
        {
            return name + " " + price + " e";
        }

        //properties
        private string name;
        private double price;
    }
}
