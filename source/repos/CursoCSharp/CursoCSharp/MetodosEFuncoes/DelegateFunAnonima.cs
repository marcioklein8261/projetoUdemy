using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate  string StringOperacao(string s);
        public static void Executar()
        {
          StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();

                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));

            // meu exemplo
            StringOperacao repetidor = delegate (string w)
              {
                  string s;
                  s = w +" "+ w;
                  return s;
              };
            Console.WriteLine(repetidor("teste"));
        }
    }
}
