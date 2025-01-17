using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗАдание_26_
{
    internal class Zadanie_26
    {
        private double _p;
        

        public Zadanie_26(double p)
        {
            _p = p;
            
        }
        public void Z()
        {
            Console.WriteLine($"Z = {Math.Pow(Math.Sin(Math.Pow(_p, 2) + 0.4), 3)}");
        }
    }
}
