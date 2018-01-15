using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TemperatureConverter converter = new TemperatureConverter();
            double temp = converter.FahrenheitToCelsius(200);
            */
            double temp = TemperatureConverter.FahrenheitToCelsius(200);
            Console.WriteLine(temp);

            Car datsun = new Car("Datsun 100A", "red", 1.0, true, 2);
            Car porchse = new Car("Porsche 911 RS3", "silver", 3.2, false, 2);
            Car toyota = new Car("Camry", "red", 2.0, true, 4);

            datsun.Model = "Datsun 100A";
            datsun.Color = "red";
            datsun.EngineSize = 1.0;
            datsun.Speed = 0;
            datsun.FuzzyDices = true;
            datsun.DoorCount = 2;

            datsun.Speed = 100;
            porchse.Speed = 280;
            toyota.Speed = 160;

            // display car data
            datsun.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            porchse.PrintData();
            toyota.PrintData();
            Console.ReadLine();
        }
    }
}
