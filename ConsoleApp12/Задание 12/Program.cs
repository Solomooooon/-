using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, t, x;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            K = 7 * Math.Pow(t, 2) + 3 * Math.Pow(Math.Sin(x), 3) + 9.2;
            Console.WriteLine($"K = {K}");
        }
    }
}
