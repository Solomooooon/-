using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double U, e, k, y, x;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            U = Math.Pow(e, k + x) + Math.Tan(x) * Math.Sqrt(y);
            Console.WriteLine($"U = {U}");

        }
    }
}
