using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_ex_aggregation
{
    public class Luser
    {
        public string Name;

        public Luser(string name)
        {
            this.Name = name;
        }

        ~Luser()
        {
            Console.WriteLine("Luser " + this.Name + " is destructed");
        }
    }
}
