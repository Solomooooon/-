using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    internal class Class1
    {
        private double _e;
        private double _y;
        private double _r;

        public Class1(double e, double y, double r)
        {
            _e = e;
            _y = y;
            _r = r;
        }
        public void W()
        {
            Console.WriteLine($"W = {Math.Pow(_e, _y + _r) + 7.2 * Math.Sin(_r)}");
        }
    }
}
