using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class MyTaskClass29
    {
        private double _y;

        public MyTaskClass29(double y)
        {
            _y = y;
        }
        public void N()
        {
            Console.WriteLine($"W={3 * Math.Pow(_y, 2) + Math.Sqrt(Math.Abs(_y + 1))}");
        }
    }
}
