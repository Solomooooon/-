using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));
           
            Console.WriteLine($"T = {T}");
        }
    }
}
