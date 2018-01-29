using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment02
{
    class L06_02_Main
    {
        static void Main(string[] args)
        {
            BikeClass bike1 = new BikeClass();
            bike1.Name = "Jopo";
            bike1.Model = "Street";
            bike1.ModelYear = 2016;
            bike1.Color = "Blue";
            bike1.GearWheels = false;
            bike1.GearName = "";
            Console.WriteLine("{0} info\n- Name:{1} Model:{2} ModelYear:{3} Color:{4} GearWheels:{5} GearName:{6}\n",
                "Bike", bike1.Name,bike1.Model,bike1.ModelYear,bike1.Color,bike1.GearWheels,bike1.GearName);

            BoatClass boat1 = new BoatClass();
            boat1.Name = "Suvi";
            boat1.Model = "S900";
            boat1.ModelYear =1990;
            boat1.Color = "White";
            boat1.SeatCount = 3;
            boat1.BoatType = "RowBoat";
            Console.WriteLine("{0} info\n- Name:{1} Model:{2} ModelYear:{3} Color:{4} SeatCount:{5} BoatType:{6}\n",
                "Boat", boat1.Name, boat1.Model, boat1.ModelYear, boat1.Color, boat1.SeatCount, boat1.BoatType);
        }
    }
}
