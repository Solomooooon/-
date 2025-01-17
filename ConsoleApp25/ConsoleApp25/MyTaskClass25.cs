using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public class MyTaskClass25
    {
        private double _e;
        private double _f;
        private double _y;

        public MyTaskClass25(double e, double f, double y)
        {
            _e = e;
            _f = f;
            _y = y;
        }
        public void G()
        {
            Console.WriteLine($"G={Math.Pow(_e, 2 * _y) + Math.Sin(Math.Pow(_f, 2))}");
        }
    }
}
