using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;

        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }


    class CalculadoraComum {

        public int Somar(int a,int b) {
            return a + b;
        }

        public int Subtrair (int a, int b) {
            return a - b;

        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {

            CalculadoraComum calcComum = new CalculadoraComum();
            var resultado = calcComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calcComum.Subtrair(2,7));
            Console.WriteLine(calcComum.Multiplicar(4,4));

            var calcCadeia = new CalculadoraCadeia();

            calcCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();

            resultado = calcCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);


        }
    }
}
