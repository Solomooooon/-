using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Zadanie_14
    {
        private double _y;
        private double _e;
        private double _x;

        public Zadanie_14(double y, double e, double x)
        {
            _y = y;
            _e = e;
            _x = x;
        }
        public void R()
        {
            Console.WriteLine($"R = {Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(_y), 2) + 6.835 + Math.Pow(_e, _x)))}");
        }
    }
}
