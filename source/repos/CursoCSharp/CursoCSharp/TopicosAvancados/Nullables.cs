using CursoCSharp.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {

        public static void Executar()
        {
            Nullable<int> num1 = null;   // a função Nullabel faz com que aceire o valor nulo
            Console.WriteLine("Nulo: " + num1);

            int? num2 = null; // a interrogação após o int (int?) faz int aceitar o valor nulo
            Console.WriteLine("Nulo: " + num2);

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("Variável não possui valor");
            }



            int valor = num1 ?? 1000; // ?? faz aceitar o valor padrão 1000
            Console.WriteLine("Valor do valor = " + valor);
            //1000 passa a ser o valor padrão, pois valor,como int, não pode ser nulo


            bool? booleana = null; // ? faz aceitar o valor nulo
            bool resultado = booleana.GetValueOrDefault(); //  o valor default de uma variável int é falso
            Console.WriteLine(" O valor resultado é: " + resultado);

            try
            {
               int x = num1.GetValueOrDefault();
                //int y = num2.GetValueOrDefault();
             //   int x = num1.Value;
                int y = num2.GetValueOrDefault();

                Console.WriteLine(x + y);
            }
            catch (Exception xpto)
            {
                Console.WriteLine("Erro: "+xpto.Message);
            }
        }
    }
}
