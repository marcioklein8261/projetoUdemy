using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram";

        //herança
        protected string CorDoOlha = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumCelular = 5511999999;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Usa muitas gírias";

        // mesma classe ou herança no mesmo projeto  (C#  >= 7.2)
        private protected string SegredoFamiliar = "Bla bla";

        //privado é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Sub celebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlha);
            Console.WriteLine(NumCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamiliar);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
