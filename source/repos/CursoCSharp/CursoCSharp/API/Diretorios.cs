using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/source/repos/CursoCSharp/CursoCSharp/Diretorio290720".ParseHome();
            var novoDirDestino = @"~/source/repos/CursoCSharp/CursoCSharp/MeuDiretorio290720".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp/".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);

            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("====Pastas==========");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n==Arquivos=============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("n\n===Diretório Raiz=====");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
