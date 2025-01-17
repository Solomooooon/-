using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, u, l, n, y, x;

            Console.WriteLine("Введите значение u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            T = Math.Sin(2 * u) * l * n * (2 * Math.Pow(y, 2) + Math.Sqrt(x));
            Console.WriteLine($"T = {T}");
        }
    }
}
