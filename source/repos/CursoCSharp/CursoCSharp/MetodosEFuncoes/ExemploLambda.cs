using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net.Http;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#" + a);
            };

            algoNoConsole("!!!!");

            //meu exemplo

            Action<int> duplica = (a) => { Console.WriteLine(a * 2); };

            duplica(3);
            // fim do meu exemplo

            Func<int> jogarDados = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);

            };
            Console.WriteLine(jogarDados());

            // meu exemplo

            Func<int, int, int> soma= (a, b) => a + b;

            Console.WriteLine($"A soma de 2 + 3 é {soma(2,3)}");


            Func<int, string> conversoHex = numero => numero.ToString("X");

            Console.WriteLine(conversoHex(1234));

            //meu teste

            int num = 10;

            string s = num.ToString("X");

            Console.WriteLine(s);

            // fim do meu teste


            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
           String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(23, 07, 2020));

        }
    }
}
