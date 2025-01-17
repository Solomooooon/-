using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, e, y, h;

            Console.WriteLine("Введите значение e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Convert.ToDouble(Console.ReadLine());

            P= Math.Pow(e,y+5.5)+9.1*Math.Pow(h,3);

            Console.WriteLine($"P = {P}");
        }
    }
}
