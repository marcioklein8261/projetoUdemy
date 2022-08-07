using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
  public  class FilhoReconhecido : SubCelebridade
    {

        public  void MeusAcessos()
        {
            Console.WriteLine("Filho Reconhecido . . . ");

            Console.WriteLine(" ----" +InfoPublica);
            Console.WriteLine(CorDoOlha);
            Console.WriteLine(NumCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamiliar);
   // teve asesso privado:  Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
