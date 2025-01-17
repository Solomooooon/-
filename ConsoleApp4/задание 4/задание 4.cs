using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    internal class задание_4
    {
        private double _t;
        private double _a;

        public задание_4(double t, double a)
        {
            _t = t;
            _a = a;
        }
        public void D()
        {
            Console.WriteLine($"D = {9.8 * Math.Pow(_a, 2) + 5.52 * Math.Cos(Math.Pow(_t, 5))}");
        }
    }
}
