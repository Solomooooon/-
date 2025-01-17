using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    internal class zadanie_10
    {
        private double _e;
        private double _y;
        private double _k;
        private double _x;


        public zadanie_10(double e, double y, double k, double x)
        {
            _e = e;
            _y = y;
            _k = k;
            _x = x;
        }
        public void U()
        {
            Console.WriteLine($"U = {Math.Pow(_e, _y) + 7.355 * Math.Pow(_k, 2) + Math.Pow(Math.Sin(_x), 2)}");
        }
    }
}
