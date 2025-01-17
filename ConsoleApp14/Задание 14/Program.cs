using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, y, e, x;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835 + Math.Pow(e, x)));
            Console.WriteLine($"R = {R}");
        }
    }
}
