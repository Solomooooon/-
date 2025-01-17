using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
          

            S = Math.Sqrt(Math.Cos(4) * Math.Pow(y, 2) + 7.151);
            Console.WriteLine($"S = {S}");
        }
    }
}
