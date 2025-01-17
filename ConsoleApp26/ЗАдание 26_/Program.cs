using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗАдание_26_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Z, p;

            Console.WriteLine("Введите значение p");
            p = Convert.ToDouble(Console.ReadLine());
            
            
            Z = Math.Pow(Math.Sin(Math.Pow(p, 2) + 0.4), 3);
            Console.WriteLine($"Z = {Z}");
        }
    }
}
