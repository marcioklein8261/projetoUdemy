using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParâmetros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }
        //meu teste
        public static int Multiplica(int a, int b)
        {
            return a * b;
        }
        // fim meu teste
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao,3, 2));

            Console.WriteLine(Calculadora(Soma, 3, 2));

            // meu teste
            Console.WriteLine(Calculadora( Multiplica,3,2));

            //fim meu teste


        }
    }
}
