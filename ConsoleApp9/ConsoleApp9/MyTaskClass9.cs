using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class MyTaskClass9
    {
        private double _l;
        private double _n;
        private double _y;
        private double _x;

        public MyTaskClass9(double l, double n, double y, double x)
        {
            _l = l;
            _n = n;
            _y = y;
            _x = x;
        }

        public void V()
        {
            Console.WriteLine($"V={_l * _n * (_y + 0.95) + Math.Sin(Math.Pow(_x, 4))}");
        }
    }
}
