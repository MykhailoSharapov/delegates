using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class SecondClass
    {
        double PowResult;

        Predicate<double> calcDelega;

        public Predicate<double> Calc(Func<double,double,double>deleg, double x,double y)
        {
            PowResult = deleg(x, y);
            calcDelega = Result;
            return calcDelega;
        }
        public bool Result(double x)
        {
            if (PowResult % x == 0)
                return true;
            else
                return false;
        }
    }
}
