using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Z, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
           

            Z = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);
            Console.WriteLine($"Z = {Z}");
        }
    }
}
