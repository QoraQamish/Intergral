using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intergral
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegralC integral = new IntegralC();
            string integralIfoda= "2*x^2+3*x^1+2*x^0";
            integral.Computation(integralIfoda, 1);
            Trapetsiya trapetsiya = new Trapetsiya();
            trapetsiya.Yuza(integralIfoda, 2, 4);
            Console.ReadKey();
        }
    }
}
