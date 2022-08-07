using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {

            /*
                        for (int i = 1; i <= 10; i++) {
                            Console.WriteLine($"O valor de i é: {i}");

                        }
            */
            double somatorio = 0;
            string entrada;

            Console.Write("Digite o tamanho da turma: ");
            entrada = Console.ReadLine();
           int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do {0}º aluno:  ",i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.Write("Media da turma: ");
            Console.WriteLine(media.ToString("##.#"));

        }

    }
}
