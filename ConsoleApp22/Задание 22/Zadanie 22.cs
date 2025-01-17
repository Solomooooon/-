using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    internal class Zadanie_22
    {
        private double _u;
        private double _l;
        private double _n;
        private double _y;
        private double _x;

        public Zadanie_22(double u, double l, double n, double y, double x)
        {
            _u = u;
            _l = l;
            _n = n;
            _y = y;
            _x = x;
        }
        public void T()
        {
            Console.WriteLine($"T = {Math.Sin(2 * _u) * _l * _n * (2 * Math.Pow(_y, 2) + Math.Sqrt(_x))}");
        }
    }
}
