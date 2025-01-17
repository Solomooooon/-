using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, n, y;

            Console.WriteLine("Введите значение n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            G = n*(y+3.5)+Math.Sqrt(y);

            Console.WriteLine($"G = {G}");
        }
    }
}
