using System;

namespace estudo_c__tdd_selenium_nunit
{
    public class Constantes
    {
        public void ImprimeConstante(){
            //ao definir a variavel como constante, o valor a ela atribuido sempre será o mesmo durante
            //toda a execução do codigo.
            const string NOME = "Victor";

            Console.WriteLine(NOME);
            
        }
    }
}