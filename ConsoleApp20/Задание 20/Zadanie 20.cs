using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    internal class Zadanie_20
    {
        private double _y;
        private double _x;
        private double _e;
        private double _k;

        public Zadanie_20(double y, double x, double e, double k)
        {
            _y = y;
            _x = x;
            _e = e;
            _k = k;
            
        }
        public void U()
        {
            Console.WriteLine($"U = {Math.Pow(_e, _k + _x) + Math.Tan(_x) * Math.Sqrt(_y)}");
        }
    }
}
