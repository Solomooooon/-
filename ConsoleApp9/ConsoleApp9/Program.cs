using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V, l, n, y, x;

            Console.WriteLine("Введите значение l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            V = l*n*(y+0.95)+Math.Sin(Math.Pow(x,4));

            Console.WriteLine($"V = {V}");
        }
    }
}
