using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_24
{
    internal class Zadanie_24
    {
        private double _y;
       

        public Zadanie_24(double y)
        {
            _y = y;
            
        }
        public void F()
        {
            Console.WriteLine($" = {2 * Math.Sin(0.214 * Math.Pow(_y, 5) + 1)}");
        }
    }
}
