using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                PrintLine(1, i);
            }

            for (int i = end - 1; i >= start; i--)
            {
                PrintLine(1, i);
            }
            
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i < end + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}