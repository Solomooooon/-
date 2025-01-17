using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double E, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 2) + 0.5 * y + 4));

            Console.WriteLine($"E = {E}");
        }
    }
}
