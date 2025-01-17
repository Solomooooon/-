using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, e, y, k, x;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            U = Math.Pow(e, y) + 7.355 * Math.Pow(k, 2) + Math.Pow(Math.Sin(x), 2);
            Console.WriteLine($"U = {U}");
        }
    }
}
