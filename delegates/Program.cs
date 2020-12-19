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
            fc.delega = Show;
            fc.delega.Invoke(sc.Calc(fc.delegaDlyaPow, 5, 5).Invoke(5));

        }
        public static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }
}
