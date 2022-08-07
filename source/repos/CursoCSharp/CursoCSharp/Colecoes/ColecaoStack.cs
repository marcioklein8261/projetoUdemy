using System;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item}  ");

            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item}  ");

            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");

            Console.WriteLine($"\nNum. de elementos: {pilha.Count}");

            foreach (var item in pilha)
            {
                Console.Write($"{item}  ");

            }

        }
    }

       
   
    
}
