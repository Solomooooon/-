using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W, v, e, x, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение v");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            W = 1.03 * v + Math.Pow(e, 2 * y) + Math.Tan(Math.Abs(x));

            Console.WriteLine($"W = {W}");

        }
    }
}
