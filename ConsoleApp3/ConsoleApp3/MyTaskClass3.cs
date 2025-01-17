using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MyTaskClass3
    {
        private double _y;
        private double _n;

        public MyTaskClass3(double y, double n)
        {
            _y = y;
            _n = n;
        }
        public void G()
        {
            Console.WriteLine($"G= {_n*(_y+3.5)+Math.Sqrt(_y)}");
        }
    }
}
