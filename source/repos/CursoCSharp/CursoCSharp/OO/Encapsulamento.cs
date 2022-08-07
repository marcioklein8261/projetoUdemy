using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()

        {
            Console.WriteLine("Filho não Reconhecido . . .");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlha);
            // Console.WriteLine(NumCelular);
            Console.WriteLine(JeitoDeFalar);
            //   Console.WriteLine(SegredoFamiliar);
            //      Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public  SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amiga Distante . . .");

            Console.WriteLine(amiga.InfoPublica);
            //   Console.WriteLine(amiga.InfoPublica);
           // Console.WriteLine(amiga.NumCelular);
        //    Console.WriteLine(amiga.JeitoDeFalar);
            //  Console.WriteLine(amiga.SegredoFamiliar);
            //   Console.WriteLine(amiga.UsaMuitoPhotoshop););



        }
        
    }

    class Encapsulamento
    {
        public static void Executar()
        {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();


            new AmigoProximo().MeusAcessos();

            

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();
        

        }
    }
}
