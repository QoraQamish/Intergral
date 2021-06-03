using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intergral
{
    public class Trapetsiya:IntegralC
    {
        //n=[0,..,n] qiymatlarda xi=a+i*h teng kattalik: 
        private double[] xi { get; set; }
        // h=(b-a)/n ga teng bo'lgan kattalik:
        private double h { get; set; }
        //Aniqlik darajasi:
        private int n { get; set; }
        public Trapetsiya(double _a,double _b, int n)
        {
            this.a = _a;
            this.b = _b;
            this.h = (b - a) / n;
            this.n = n;
            this.xi = new double[n+1];
        }        
        public override double Computation(string resaltString, double x=0)
        {
            InitionXi();
            return (h/2)*(Calcul(resaltString,xi[0])+SumIntergal(resaltString)+Calcul(resaltString,xi[n]));
        }
        private double SumIntergal(string fun)
        {
            double res = 0;
            for (int i = 1; i < n; i++)
            {
                res += Calcul(fun, xi[i]);
            }
            return 2*res;
        }
        private void InitionXi()
        {
            for (int i = 0; i <=n; i++)
            {
                xi[i] = a + h * i;
            }
        }
    }
}
