using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double W, e, y, r;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение r");
            r = Convert.ToDouble(Console.ReadLine());

            W = Math.Pow(e, y + r) + 7.2 * Math.Sin(r);
            Console.WriteLine($"W = {W}");
        }
    }
}
