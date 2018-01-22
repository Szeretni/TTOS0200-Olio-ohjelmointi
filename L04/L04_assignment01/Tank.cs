using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_assignment01
{
    class Tank
    {
        public float AccelerateTo(float inputSpeed)
        {
            if (inputSpeed >= Speed)
            {
                if (inputSpeed > SpeedMax)
                {
                    speed = speedMax;
                    Console.WriteLine("Speed set to max speed: " + SpeedMax);
                }
                else
                {
                    speed = inputSpeed;
                }
            }
            return speed;
        }

        public float SlowTo(float inputSpeed)
        {
            if (inputSpeed <= Speed)
            {
                if (inputSpeed < 0)
                {
                    speed = 0;
                    Console.WriteLine("Speed set to minimum speed: " + 0);
                }
                else
                {
                    speed = inputSpeed;
                }
            }
            return speed;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        private string name;
        private string type;
        private int crewCount;
        private float speed = 0;
        private float speedMax = 100;
                
        private int CrewCount
        {
            get
            {
                return crewCount;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    Console.WriteLine("Failed to set crew count.");
                }
                else
                {
                    crewCount = value;
                }
            }
        }
        private float Speed
        {
            get
            {
                return speed;
            }
        }
        private float SpeedMax
        {
            get
            {
                return speedMax;
            }
        }
    }
}
