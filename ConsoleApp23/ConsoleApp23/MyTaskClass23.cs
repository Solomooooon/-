using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class MyTaskClass23
    {
        private double _e;
        private double _y;
        private double _f;

        public MyTaskClass23(double e, double y, double f)
        {
            _e = e;
            _y = y;
            _f = f;
        }
        public void G()
        {
            Console.WriteLine($"G={Math.Pow(_e, 2 * _y) + Math.Sin(_f)}");
        }
    }
}
