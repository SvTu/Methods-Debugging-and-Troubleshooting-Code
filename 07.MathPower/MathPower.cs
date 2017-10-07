using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(input, power));
        }

        static double RaiseToPower(double input, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                 result *= input; //result = result * input;
            }
            return result;
        }    
    }
}