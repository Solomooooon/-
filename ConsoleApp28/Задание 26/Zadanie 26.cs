using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    internal class Zadanie_26
    {
        private double _e;
        private double _y;
        private double _h;

        public Zadanie_26(double e, double y, double h)
        {
            _e = e;
            _y = y;
            _h = h;
        }
        public void T()
        {
            Console.WriteLine($"T = {Math.Pow(_e, _y + _h) + Math.Sqrt(Math.Abs(6.4 * _y))}");
        }
    }
}
