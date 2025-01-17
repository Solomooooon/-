using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class MyTaskClass1_
    {
        private double _x;
        private double _y;

        public MyTaskClass1_(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public void S()
        {
            Console.WriteLine($"S={9.765 * Math.Pow(_y, 7) + Math.Tan(_x)}");
        }
    }
}
