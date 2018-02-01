using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_ex_interface
{
    class Cat : IAnimal
    {
        public string Name { get;set; }

        public string Talk()
        {
            return "Meow";
        }
    }
}
