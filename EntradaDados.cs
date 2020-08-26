using System;
namespace estudo_c__tdd_selenium_nunit
{
    public class EntradaDados
    {
        public void imprimeDados(){
            String nome;
            Int32 idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nome: "+nome+"\n"+"Idade: "+idade);
        }
    }
}