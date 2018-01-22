using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCreate
{
    class Cat
    {
        private static int instances = 0;

        public Cat()
        {
            instances++;
        }

        ~Cat()
        {
            instances--;
        }

        public static int CatCount()
        {
            return instances;
        }
    }


}
