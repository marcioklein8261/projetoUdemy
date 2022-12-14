using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("Idade Inserida: {0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);


        }
    }
}
