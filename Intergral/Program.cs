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
            
            Console.WriteLine("Matematik ifodani kirting, Misol: [Kayftsent]*[argument]^[daraja] qoydaga qatiy bo'ysin");
            Console.WriteLine("Shu kabi bo'lsin 2*x ^2+3*x^1+2*x^0 \n Iltmos matematik ifodani kirting");
            string integralIfoda = Console.ReadLine();
            Console.WriteLine("____________Ifoda class__________");
            Ifoda ifoda = new Ifoda();
            Console.WriteLine("Ifodani intgrali");
            ifoda.Computation(integralIfoda);
            Console.WriteLine("__________Integral Class___________");
            Console.WriteLine("Ifodani [a,b] oraliqda integralini hisoblaymiz");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            IntegralC integral = new IntegralC(a,b);
            Console.WriteLine("-----------Niton Lebnsov usulidagi integral qiymati---------------\n");
            Console.WriteLine(integral.Computation(integralIfoda));


            Console.WriteLine("Trapetsiya va Simson usularda integralni aniqlanish oraliq kerak");
            Console.WriteLine("Iltmos oraliq qiymatlar qanchalik aniq bo'lsa?");
            Console.Write("Jufat son kirting n=");
            int n = int.Parse(Console.ReadLine());
            //Trapetsiya usuli bilan Integral topildi:
            Console.WriteLine("\n-----------Trapetsiya usulidagi integral qiymati:---------------\n");
            Trapetsiya trapetsiya = new Trapetsiya(a, b, n);
            Console.WriteLine(" D="
                + trapetsiya.Computation(integralIfoda));

            //Simson usuli bilan Integral topildi:
            Console.WriteLine("\n------------Simson usulidagi integral qiymat:-------------------\n");
            SimSon simSon = new SimSon(a, b, n/2);
            Console.WriteLine(" D="
                + simSon.Computation(integralIfoda));

            
            Console.ReadKey();
        }
    }
}
