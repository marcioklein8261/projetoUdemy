using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    
    class DesafioAtributo {

        int a = 10;
        public static void Executar() {

            // Acessar a variável 'a' dentro do método executar



             DesafioAtributo objeto1 = new DesafioAtributo();

             Console.WriteLine(objeto1.a);

            objeto1.a = 3;

            Console.WriteLine(objeto1.a);





        }
    }
}
