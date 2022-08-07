using System;
using System.Collections.Generic;
using System.Linq;
namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>(){

            new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
            new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
            new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.7 },
            new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
            new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 },
            new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
            new Aluno() { Nome = "André", Idade = 21, Nota = 4.3 },
        };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}  {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Aluno: {ana.Nome}  {ana.Nota}");

            var y = alunos.FirstOrDefault(y => y.Nome.Equals("nnn"));
            if (y == null)

            {
                Console.WriteLine("Aluno não encontrado");
            }

            var z = alunos.LastOrDefault(z => z.Nome.Equals("Ana"));
            if (z == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }
            else
            {
                Console.WriteLine($"{z.Nome}  {z.Nota}");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var r in exemploSkip)
            {
                Console.WriteLine($"{r.Nome}  {r.Idade}  {r.Nota}");
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);
            /// meu teste
            Console.WriteLine("Meu teste");
            var a = alunos;
            var v = a.First();
            Console.WriteLine(v.Nome);
            Console.WriteLine("fim do meu teste");
            var m= alunos;
            foreach (var w in m) { Console.WriteLine(w.Nome); }

            var somatoriaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatoriaNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
             Console.WriteLine(mediaDaTurma);
            //meus testes
            Console.WriteLine("Meus testes");
            var numeroDeAlunos = alunos.Count();
            Console.WriteLine(numeroDeAlunos);
            //fim do meu teste
            var mediaDosAprovados = alunos.Where(aluno => aluno.Nota >= 7).
                Average(aluno => aluno.Nota);
            Console.WriteLine("Media dos alunos aprovados: "+mediaDosAprovados);




        }

    }
}
