using System;
using System.IO;


namespace CursoCSharp.API
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                 using (StreamWriter sw = File.CreateText(path)) 
              //  using (StreamWriter sw = File.AppendText(path)) --os dois comandos dão no mesmo
                {
                    sw.WriteLine("Produto;Preco;Qtda");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha branca;2.89;27");
                }

            }

            try
            {

            
                   using (StreamReader sr = new StreamReader(path))
                {
                    var x = sr.ReadToEnd();
                    Console.WriteLine(x);
                }

            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


}


            }
    }