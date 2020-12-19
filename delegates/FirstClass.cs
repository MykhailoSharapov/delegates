using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class FirstClass
    {
        public FirstClass()
        {
            delegaDlyaPow = Pow;
        }
        public Func<double, double, double> delegaDlyaPow;
        public Action<bool> delega;
        public double Pow(double x, double y)
        {
            var result = x * y;
            return result;
        }
    }
}
