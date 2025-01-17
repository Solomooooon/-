using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double H, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            H = Math.Sin(Math.Pow(y,2))-2.8*y+Math.Sqrt(Math.Abs(y));

            Console.WriteLine($"H = {H}");
        }
    }
}
