using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, x;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());

            L = 1.51*Math.Cos(Math.Pow(x,2))+2*Math.Pow(x,3);

            Console.WriteLine($"L = {L}");
        }
    }
}
