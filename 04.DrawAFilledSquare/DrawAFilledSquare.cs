using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintDahshesLine(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintVLines(n);
            }
            PrintDahshesLine(n);
        
        }

        static void PrintDahshesLine(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintVLines(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
