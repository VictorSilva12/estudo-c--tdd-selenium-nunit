using System;
using System.IO;
namespace estudo_c__tdd_selenium_nunit
{
    public class Atividade02
    {
        public void ParImpar(){
            int n;
            Console.WriteLine("Digite um numero: ");
            int.TryParse(Console.ReadLine(), out n);
            if((n % 2)== 0){
                Console.WriteLine("O numero é par");
            }
            else{
                Console.WriteLine("O numero é impar");
            }
        }

        public void CadCli(){
            int numcli;
            int clicad = 0;
            Console.WriteLine("Quantos clientes deseja cadastrar?");
            int.TryParse(Console.ReadLine(), out numcli);
            string[] clientes = new string[numcli];
            while(clicad != clientes.Length){
                Console.WriteLine("Qual o nome do cliente?");
                clientes[clicad] = Console.ReadLine();
                clicad++;
            }
            foreach(string el in clientes){
                Console.WriteLine(el);
            }
        }

        
    }
}