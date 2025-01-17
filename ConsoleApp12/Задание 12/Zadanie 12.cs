using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Zadanie_12
    {
        private double _t;
        private double _x;

        public Zadanie_12(double t, double x)
        {
            _t = t;
            _x = x;
        }
        public void K()
        {
            Console.WriteLine($"K = {7 * Math.Pow(_t, 2) + 3 * Math.Pow(Math.Sin(_x), 3) + 9.2}");
        }
    }
}
