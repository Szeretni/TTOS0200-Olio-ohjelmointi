using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class TemperatureConverter
    {
        //staattisia metodeja voi käyttää ilman metodeja
        //eivät voi käyttää luokan propertyja, ellei nekin ole staattisia

        public double TempValue { get; set; }

        // convert Celsius to Fahrenheit.
        public static double CelsiusToFahrenheit(double celsius)
        {
            //ei toimi, koska TempValue ei ole staattinen
            //double tmp = TempValue;
            return (celsius * 9 / 5) + 32;
        }

        // convert Fahrenheit to Celsius.
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
