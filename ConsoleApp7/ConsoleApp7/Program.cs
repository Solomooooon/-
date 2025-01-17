using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, m;

            Console.WriteLine("Введите значение m");
            m = Convert.ToDouble(Console.ReadLine());

            N= Math.Pow(m,2) + 2.8 * Math.Abs(m)+0.55;

            Console.WriteLine($"N = {N}");
        }
    }
}
