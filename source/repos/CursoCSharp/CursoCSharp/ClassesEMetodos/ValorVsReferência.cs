using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ValorVsReferência {
        public struct Dependente {
            public string Nome;
            public int Idade;
        }
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero}  {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero}  {copiaNumero}");

            Dependente dep= new Dependente();
            dep.Nome = "Beto";
            dep.Idade = 20;

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome}  {copiaDep.Nome}" );
            Console.WriteLine($"{dep.Idade}  {copiaDep.Idade}" );

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome}  {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}  {copiaDep.Idade}");


        }
    }
}
