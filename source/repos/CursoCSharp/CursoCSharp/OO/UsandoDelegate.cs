using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void imprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            
            //MeuImprimirSoma teste
            //var x =  MinhaSoma (2,3);
            //Console.WriteLine(x);

            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3));

            imprimirSoma op2 = MeuImprimirSoma;
            op2(5, 7);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(12.7, 13.2));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(25.8, 4.2);
        }
    }
}