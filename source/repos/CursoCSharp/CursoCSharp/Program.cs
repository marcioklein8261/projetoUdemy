using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesE_Metodos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpoção - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores de Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore de Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IfElse - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IfElseIf - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                //Classes é Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atibuto - Classes e Métodos", DesafioAtributo.Executar},
                {"Desafio Atibuto Sem Instancia - Classes e Métodos", DesafioSemInstancia.Executar},
                {"Desafio Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly     -      Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum     -      Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo de Struct     -      Classes e Métodos", ExemploStruct.Executar},
                {"Struct x Classe    -      Classes e Métodos", StructVsClasse.Executar},
                {"Variáveis x Referências    -      Classes e Métodos", ValorVsReferência.Executar},
                {"Parâmetros por Referência  -  Classes e Métodos", ParametorsPorReferencia.Executar},
                {"Parâmetros Padrão  -  Classes e Métodos", ParametroPadrao.Executar},
             
                //Coleções
                {"Array  -  Coleções", Colecoes.Array.Executar},
                {"List  -  Coleções ", ColecoesList.Executar},
                {"ArrayList  -  Coleções ", ColecoesArrayList.Executar},
                {"Set  -  Coleções ", ColecoesSet.Executar},
                {"Queue  -  Coleções ", ColecoesQueue.Executar},
                {"Igualdade  -  Coleções ", Igualdade.Executar},
                {"Stack  -  Coleções ", ColecaoStack.Executar},
                {"Dictionary     -     Coleções ",ColecoesDictionary.Executar},
              
                // Orientação a Objeto
                  {"Herança       -     Orientação a Objeto ",Heranca.Executar},
                  {"Construtor This     -     Orientação a Objeto ",ConstrutorThis.Executar},
                  {"Encapsulamento    -     Orientação a Objeto ",OO.Encapsulamento.Executar},
                  {"Polimorfismo    -     Orientação a Objeto ",Polimorfismo.Executar},
                  {"Classe Abstrata - Orientação a Objeto ",Abstract.Executar},
                  {"Interface - Orientação a Objeto ",Interface.Executar},
                  {"Sealed - Orientação a Objeto ",Sealed.Executar},

                  //   Métodos e Funções
                  {"Exemplo Lambda - Métodos e Funções ",ExemploLambda.Executar},
                  {"Lambda como Delegates - Métodos e Funções ",LambdaDelegate.Executar},
                   {"Usando Delegates - Métodos e Funções ",UsandoDelegate.Executar},
                  {"Delegates como Funções Anônimas - Métodos e Funções ",DelegateFunAnonima.Executar},
                  {"Delegates como Parâmetros  - Métodos e Funções ",DelegatesComoParâmetros.Executar},
                  {"Métodos de Extensão  - Métodos e Funções ",MetodosDeExtensão.Executar},

                  //   Excecoes
                  {"Primeira Exceção  -Exceções ",PrimeiraExcecao.Executar},
                  {"Exceção Personalizadas -Exceções ",ExcecoesPersonalizadas.Executar},

                  //AP
                  {"Meu Primeiro Arquivo - API ",PrimeiroArquivo.Executar},
                  {"Lendo Arquivos - API ",LendoArquivos.Executar},
                  {"Exempo File Info - API ",ExemploFileInfo.Executar},
                  {"Diretórios - API ",Diretorios.Executar},
                  {"Diretórios Info - API ",ExemploDirectoryInfo.Executar},
                  {"Exemplo Path - API ", ExemploPath.Executar},
                  {"Exemplo DateTime - API ", ExemploDateTime.Executar},
                  {"Exemplo Time Span - API ", ExemploTimeSpan.Executar},

                  // Tópicos Avançados
                  {"LINQ1 - Tópicos Avançados ", LINQ1.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}