using System;

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
            Atividade01 atividade1 = new Atividade01();
            //estudoVariaveis.ImprimeVariaveis();
            //estudoConstantes.ImprimeConstante();
            //estudoEntradaDados.imprimeDados();
            //estudoConvercaoValores.imprimeValores();
            atividade1.Exercicio1();
            atividade1.Exercicio2();
        }
    }
}
