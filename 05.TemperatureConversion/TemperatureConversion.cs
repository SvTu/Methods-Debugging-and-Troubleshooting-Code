using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(input);
            Console.WriteLine("{0:f2}", celsius);

        }

        static double FahrenheitToCelsius(double input)
        {
            return (input - 32) * 5 / 9;
        }
    }
}