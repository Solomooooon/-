using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, e, y, h;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Convert.ToDouble(Console.ReadLine());

            T = Math.Pow(e, y + h) + Math.Sqrt(Math.Abs(6.4 * y));
            Console.WriteLine($"T = {T}");
        }
    }
}
