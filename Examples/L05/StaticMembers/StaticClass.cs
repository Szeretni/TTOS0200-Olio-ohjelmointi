using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    class StaticClass
    {
        static public int Power2(int v)
        {
            return v * v;

            //ei toimi, koska static
            //return v * v + tempValue;
        }

        private int tempValue = 0;
    }
}
