using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class MyTaskClass27
    {
        private double _e;
        private double _x;
        private double _y;
        private double _v;

        public MyTaskClass27(double e, double x, double y, double v)
        {
            _e = e;
            _x = x;
            _y = y;
            _v = v;
        }
        public void W()
        {
            Console.WriteLine($"W={1.03 * _v + Math.Pow(_e, 2 * _y) + Math.Tan(Math.Abs(_x))}");
        }
    }
}
