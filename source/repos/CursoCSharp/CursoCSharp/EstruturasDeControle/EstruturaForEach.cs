using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var classe = new string[] { "Ana", "Luis", "Tabata" };

            foreach(string aluno in classe) {
                Console.WriteLine(aluno);
            }

        }
    }
}
