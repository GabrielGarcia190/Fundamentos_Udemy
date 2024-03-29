﻿using CursoCSharp.API;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasdeControle;
using CursoCSharp.Excecoes;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using CursoCSharp.TopicosEpeciais;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios  - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormantandoNumeros.Executar},
                {"Convertendo Números - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura IF  & Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF  & Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBrake.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },


                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Contrutores - Classes e Metodos", Construtores.Executar },
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributos - Classes e Metodos", DesafioAtributos.Executar },
                {"Params - Classes e Metodos", Params.Executar },
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar },
                {"Get e Set - Classes e Metodos", GetSet.Executar },
                {"Props - Classes e Metodos", Props.Executar },
                {"Readonly - Classes e Metodos", Readonly.Executar },
                {"Enum - Classes e Metodos", ExemploEnum.Executar },
                {"Struct - Classes e Metodos", ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Metodos", StructvsClasse.Executar },
                {"Valor vs Referência - Classes e Metodos", ValorVsReferentecia.Executar },
                {"Parametro por Referência - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"Parametro com Valor Padrão - Classes e Metodos", ParametrosPadrao.Executar },

                //Coleções
                {"Arrays - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"HashSet - Coleções", ColecoesSet.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
             

                // OO
                {"Henraça - OO", Heranca.Executar},
                //{"Encapsulamento - OO", Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimofirsmo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Selead - OO", Sealed.Executar},
                
                
                //Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Delegate - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegate Funções Anônimas - Métodos & Funções", DelegateFunAnonima.Executar},
                {"Delegates como Paramêtros - Métodos & Funções", DelegatesComoParametros.Executar},

                //Execeções
                {"Execeções sem tratamento - Métodos & Funções", PrimeiraExececao.Executar},
                {"Execeções Personalizadas - Métodos & Funções", ExececoesPersonalizadas.Executar},

                //API
                {"Escrevendo - API", PrimeiroArquivo.Executar},
                {"Lendo arquivos - API", LendoArquivos.Executar},
                {"FileInfo - API", ExemploFiloInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},
                {"Path - API", ExemploPath.Executar},
                {"Date Time - API", ExemploDateTime.Executar},
                {"Time Span - API", ExemploDateTime.Executar},

                //Topicos Especiais
                {"Linq - Topicos Especiais", LINQ1.Executar},
                {"Linq 2 - Topicos Especiais", LINQ2.Executar},
                {"Nullables - Topicos Especiais", Nullables.Executar},
                {"Dynamics - Topicos Especiais", Dynamics.Executar},
                {"Genericos - Topicos Especiais", Genericos.Executar},




        });

            central.SelecionarEExecutar();
        }
    }
}