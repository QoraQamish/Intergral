using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intergral
{
    public class SimSon:IntegralC
    {
        //n=[0,..,2n] qiymatlarda xi=a+i*h teng kattalik: 
        private double[] xi { get; set; }
        // h=(b-a)/n ga teng bo'lgan kattalik:
        private double h { get; set; }
        //Aniqlik darajasi:
        private int n { get; set; }
        public SimSon(double _a,double _b,int n)
        {
            this.a = _a;
            this.b = _b;
            this.h = (b - a) / (2*n);
            this.n = n;
            this.xi = new double[2*n + 1];

        }
        public override double Computation(string resaltString, double x=0)
        {
            InitionXi();
            return (h / 3) * (Calcul(resaltString, xi[0]) 
                + SumIntergal(resaltString,false)
                + SumIntergal(resaltString, true)
                + Calcul(resaltString, xi[2*n])); ;
        }
        private double SumIntergal(string fun,bool toq)
        {
            double res = 0;
            if (toq)
            {
                for (int i = 2; i <=2*n-2; i+=2)
                {
                    res += Calcul(fun, xi[i]);
                }
                return 2 * res;
            }
            else
            {
                for (int i = 1; i <=2*n-1; i+=2)
                {
                    res += Calcul(fun, xi[i]);
                }
                return 4 * res;
            }
        }
        private void InitionXi()
        {
            for (int i = 0; i <= 2*n; i++)
            {
                xi[i] = a + h * i;
            }
        }
    }
}
