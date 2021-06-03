using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intergral
{
    public class IntegralC:Ifoda
    {
        public override double Computation(string resaltString, double x)
        {
            return base.Computation(CalculIntegral(resaltString), x);   
        }
        // a*x^n+b*x^n-1 ......+c*x^0 ko'rnishdagi ifoda uchun Integralni xisoblash
        public string CalculIntegral(string _ifoda)
        {
            this.ifoda = _ifoda;
            string result = "";
            string[] bolak = ifoda.Split('+');
            for (int i = 0; i < bolak.Length; i++)
            {
                if (bolak[i].Length > 0) result +="+"+ CalculPieceIntegral(bolak[i]);
            }
            result = result.Trim('+');
            Console.WriteLine("Ifodaning integral qiymati: "+result);
            return result;
        }
        // bo'lak uchun ajratilgan massiv
        private string[] pieces;
        // bo'lakdan ajratilgan argument qiymatini ushlaydi
        private double argument;
        // bo'lakdan ajratilgan darajani qiymatini ushlaydi
        private double daraja;
        // a*x^n kabi bo'lakning Integralni xisoblaymiz:
        private string CalculPieceIntegral(string piece)
        {
            pieces = piece.Split('*', '^');
            if (pieces.Length == 3)
            {
                argument = double.Parse(pieces[0].ToString());
                daraja = double.Parse(pieces[2].ToString())+1;
                return (1.0*argument/daraja).ToString()+"*x^"+daraja.ToString();
            }
            return "";
        }
    }
}
