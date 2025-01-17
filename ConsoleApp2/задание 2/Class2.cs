using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    internal class Class2
    {

        private double _l;
        private double _n;
        private double _p;
        private double _y;
        private double _e;

        public Class2(double l, double n, double p, double y, double e)
        { 
            _l = l;
            _n = n;
            _p = p; 
            _y = y;
            _e = e;
        }
        public void R()
        {
            Console.WriteLine($"R = {_l * _n * (Math.Pow(_p, 2) + Math.Pow(_y, 3) + Math.Pow(_e, _p))}");
        }
    }
}
