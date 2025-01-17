using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
           

            F = 2 * Math.Sin(0.214 * Math.Pow(y, 5) + 1);
            Console.WriteLine($"F = {F}");
        }
    }
}
