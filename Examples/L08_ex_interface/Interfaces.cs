using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_ex_interface
{
    interface IAnimal
    {
        string Name { get; set; }
        string Talk();
    }
}
