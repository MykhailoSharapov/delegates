using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass fc = new FirstClass();
            SecondClass sc = new SecondClass();
            Show(sc.Calc(fc.delegaDlyaPow, 5, 5));
            fc.delega = Show;

        }
        public static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }
}
