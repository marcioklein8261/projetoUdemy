using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{

    public static class ExtensaoInteiro
    {
        public static int Soma(this int num, int outroNum)
        {
            return num + outroNum;
        }

        public static int Subtracao(this int num, int outroNum)
        {
            return num - outroNum;
        }


    }



    class MetodosDeExtensão
    {
        //meu teste
          public static int x = 3333;
        // fim meu teste






        public static void Executar()
        {
            //meu teste
                Console.WriteLine(x);
            //fim meu teste
            int i = 3;
            Console.WriteLine(i.Soma(4));

            Console.WriteLine(i.Subtracao(4));

            Console.WriteLine(7.Soma(3));
            Console.WriteLine(7.Subtracao(3));
        }
    }
}
