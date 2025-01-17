using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, t, l;

            Console.WriteLine("Введите значение t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение l");
            l = Convert.ToDouble(Console.ReadLine());
            
            R = 3*Math.Pow(t, 2)+3*Math.Pow(l,5) +4.9 ;
            Console.WriteLine($"R = {R}");
        }
    }
}
