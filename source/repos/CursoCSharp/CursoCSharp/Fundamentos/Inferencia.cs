using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {

            /* variáveis implicitas tem que ser declaradas na mesma 
             * linha da declaração 
             */

            var nome = "Marcio";
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a+b);

        }
    }
}
