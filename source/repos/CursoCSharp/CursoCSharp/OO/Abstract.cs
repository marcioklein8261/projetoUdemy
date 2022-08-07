using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Ola, me nome é Ok Google";
        }

    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Meu nome é Bixby";
        }

    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Meu nome é Siri";
        }

    }


    class Abstract
    {
        public static void Executar()
        {

            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }

}
