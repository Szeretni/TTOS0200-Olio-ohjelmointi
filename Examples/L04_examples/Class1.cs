using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_examples
{
    class Car
    {
        // max speed
        private int MaxSpeed = 200;
        // field
        public int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
    }
}
