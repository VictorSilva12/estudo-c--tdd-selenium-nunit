using System;
using System.IO;
namespace estudo_c__tdd_selenium_nunit
{
    class Executar
    {
        static void Main(string[] args)
        {
            //Constantes estudoConstantes = new Constantes();
            //Variaveis estudoVariaveis = new Variaveis();
            //EntradaDados estudoEntradaDados = new EntradaDados();
            //ConvertendoValores estudoConvercaoValores = new ConvertendoValores();
            //Atividade01 atividade1 = new Atividade01();
            //EstruturasRepeticao estudoRepeticao = new EstruturasRepeticao();
            //Matriz estudoMatriz = new Matriz();
            //VetorSwitch estudoVetSwitch = new VetorSwitch();
            //MetodosString estudoString = new MetodosString();
            //OperacoesMatematicas estudoOpMath = new OperacoesMatematicas();
            LeituraEscritaArquivo estudoLeituraEscrita = new LeituraEscritaArquivo();
            //estudoVariaveis.ImprimeVariaveis();
            //estudoConstantes.ImprimeConstante();
            //estudoEntradaDados.imprimeDados();
            //estudoConvercaoValores.imprimeValores();
            //atividade1.Exercicio1();
            //atividade1.Exercicio2();
            //estudoRepeticao.EstudoForeach();
            //estudoRepeticao.EstudoFor();
            //estudoRepeticao.EstudoWhile();
            //estudoMatriz.ImprimeMatriz();
            //estudoVetSwitch.ImprimeVetor();
            //estudoString.EstudoMetodoString();
            //estudoOpMath.OpsMatematica();           
            //Pessoa p = new Pessoa("Victor", 25);
            //p.Rua = "Rua ruas";
            //p.Numero = 000;
            //p.Bairro = "Bairros";
            //Console.WriteLine("nome: "+p.Nome+"\n"+"idade: "+p.Idade+"\n"+"rua: "+p.Rua+"\n"+"numero: "+p.Numero+"\n"+"bairro: "+p.Bairro);
            //estudoLeituraEscrita.EscreveDados();
            estudoLeituraEscrita.LerArquivo();
        }
    }
}
