using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtesting
{
    class SpeedTest
    {
        private int speed;
        public int Speed
        {
            get { return speed * 2; }
            set { speed = value; }
        }
    }
}
