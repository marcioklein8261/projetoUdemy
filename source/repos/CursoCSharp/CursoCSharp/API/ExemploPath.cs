using System;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                //using (StreamWriter sw = File.CreateText(arquivo)) ;
                File.CreateText(arquivo);
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFullPath(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));

            Console.WriteLine("\n=======Diretório ================\n");

            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));
        }
    }
}
