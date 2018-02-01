using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_ex_interface_example
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetConnection con = new InternetConnection();
            con.Connect(null);

            Dog internetAwareDog = new Dog();
            con.Connect(internetAwareDog);
        }
    }
}
