using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, n, y, g;


            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение g");
            g = Convert.ToDouble(Console.ReadLine());

            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);

            Console.WriteLine($"P = {P}");
        }
    }
}
