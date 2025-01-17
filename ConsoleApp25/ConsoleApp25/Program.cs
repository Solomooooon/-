using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double G, e, f, y;

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение f");
            f = Convert.ToDouble(Console.ReadLine());

            G = Math.Pow(e, 2 * y) + Math.Sin(Math.Pow(f,2));

            Console.WriteLine($"G = {G}");



        }
    }
}
