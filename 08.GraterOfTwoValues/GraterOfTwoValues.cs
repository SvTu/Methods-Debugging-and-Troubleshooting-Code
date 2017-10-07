using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GraterOfTwoValues
{
    class GraterOfTwoValues
    {
        static void Main(string[] args)
        {
            var typeOfInput = Console.ReadLine();

            if (typeOfInput == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMaxInt(first, second);
                Console.WriteLine(max);
            }
            else if (typeOfInput == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMaxChar(first, second);
                Console.WriteLine(max);
            }
            else if (typeOfInput == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMaxString(first, second);
                Console.WriteLine(max);
            }
        }

        static int GetMaxInt(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMaxChar(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        
        static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else 
            {
                return second;
            }
        }

    }
}
