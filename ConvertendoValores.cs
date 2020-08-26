using System;

namespace estudo_c__tdd_selenium_nunit
{
    public class ConvertendoValores
    {
        public void imprimeValores(){
            string nome;
            int idade;
            char sexo;
            double salario;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu sexo?(M ou F)");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salário?");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome: "+nome+"\n"+"Idade: "+idade+"\n"+"Sexo: "+sexo+"\n"+"Salário: "+salario);
        }
    }   
}