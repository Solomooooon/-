using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, l, n, p, y, e;

            Console.WriteLine("Введите значение l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());

            K = l * n * (Math.Pow(p, 2) + Math.Pow(y, 3) + Math.Pow(e, p));
            Console.WriteLine($"K = {K}");
        }
    }
}
