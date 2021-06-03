using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intergral
{
    public class Ifoda
    {
        public string ifoda { get; set; }
        public double x { get; set; }
        public virtual double Computation(string resaltString=null,double x=0) 
        {
            if (resaltString == null) return x; 
            return Calcul(resaltString,x);
        }
        // a*x^n+b*x^n-1 ......+c*x^0 ko'rnishdagi ifodani x=a dagi qiymatini topadi:
        public double Calcul(string _ifoda,double a)
        {
            this.ifoda = _ifoda;
            this.x = a;
            double result = 0;
            string[] bolak = ifoda.Split('+');
            for (int i = 0; i < bolak.Length; i++)
            {
                if(bolak[i].Length>0) result += CalculPiece(bolak[i]);
            }
            Console.WriteLine(" x={0} | f(x)={1} ",x,result);
            return result;
        }
        // bo'lak uchun ajratilgan massiv
        private string[] pieces;
        // bo'lakdan ajratilgan argument qiymatini ushlaydi
        private double argument;
        // bo'lakdan ajratilgan darajani qiymatini ushlaydi
        private double daraja;
        // a*x^n kabi bo'lakni hisoblaydi:
        private double CalculPiece(string piece)
        {
            pieces = piece.Split('*', '^');
            if (pieces.Length == 3)
            {
                argument = double.Parse(pieces[0].ToString());
                daraja = double.Parse(pieces[2].ToString());
                return argument * Math.Pow(x, daraja);
            }
              return 0;
        }
    }
}
