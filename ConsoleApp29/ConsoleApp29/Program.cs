using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Abs(y + 1));

            Console.WriteLine($"N = {N}");
        }
    }
}
