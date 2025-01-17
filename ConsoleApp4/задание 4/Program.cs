using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double D, a, t;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());

            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));
            Console.WriteLine($"D = {D}");
        }
    }
}
