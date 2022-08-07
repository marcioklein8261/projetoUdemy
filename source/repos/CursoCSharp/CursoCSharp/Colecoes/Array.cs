using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniel";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
            double somatorio = 0.00;
            double[] notas = { 9.3, 4.8, 8.4, 8.5, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }
            

            double media = somatorio / notas.Length;
            Console.WriteLine($"A media é {media.ToString("0.00")}");


            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

         

        }


    }
}

