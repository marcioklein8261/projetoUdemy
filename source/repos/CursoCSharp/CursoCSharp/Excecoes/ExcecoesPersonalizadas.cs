using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class ExcecaoNegativa : Exception
    {
        public ExcecaoNegativa() { }

        public ExcecaoNegativa(string mensagem) : base(mensagem) { }

        public ExcecaoNegativa(string mensagem, Exception inner)
            : base(mensagem, inner) { }

    }

    public class ExcecaoImpar : Exception
    {
        public ExcecaoImpar(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0){
                throw new ExcecaoNegativa("Número Negativo. . .");
            }

            if(valor % 2 == 1)
            {
                throw new ExcecaoImpar("Númeroímpar . . .");
            }

            return valor;
        }
        public static void Executar()
        {

            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch(ExcecaoNegativa e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ExcecaoImpar e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
