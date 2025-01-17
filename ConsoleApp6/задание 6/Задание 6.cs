using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    internal class Задание_6
    {
        private double _y;
        private double _e;
        private double _x;
        

        public Задание_6(double y, double e ,double x)
        {
            _y = y;
            _e = e;
            _x = x;
        }
        public void M()
        {
            Console.WriteLine($"M = {Math.Cos(2) * _y + 3.6 * Math.Pow(_e, _x)}");
        }
    }
}
