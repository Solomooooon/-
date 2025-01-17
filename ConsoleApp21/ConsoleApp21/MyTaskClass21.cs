using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class MyTaskClass21
    {
        private double _e;
        private double _y;
        private double _h;

        public MyTaskClass21(double e, double y, double h)
        {
            _e = e;
            _y = y;
            _h = h;
        }
        public void P()
        {
            Console.WriteLine($"P={Math.Pow(_e, _y + 5.5) + 9.1 * Math.Pow(_h, 3)}");
        }
    }
}
