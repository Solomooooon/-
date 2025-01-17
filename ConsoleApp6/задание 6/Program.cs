using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double M, y, e, x;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            M = Math.Cos(2) * y + 3.6 * Math.Pow(e, x);
            Console.WriteLine($"M = {M}");
        }
    }
}
