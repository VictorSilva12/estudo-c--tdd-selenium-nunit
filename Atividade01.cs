using System;
namespace estudo_c__tdd_selenium_nunit
{
    public class Atividade01
    {
        public void Exercicio1(){
            string nome;
            string sobrenome;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Primeiro nome: "+nome);
            Console.WriteLine("Segundo nome: "+sobrenome);
        }
        public void Exercicio2(){
            int a;
            int b;
            Console.WriteLine("Digite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" + "+b+" = "+Somar(a, b));
            Console.WriteLine(a+" - "+b+" = "+Subtrair(a, b));
            Console.WriteLine(a+" * "+b+" = "+Multiplicar(a, b));
            Console.WriteLine(a+" / "+b+" = "+Dividir(a, b));
        }
        public int Somar(int a, int b){
            return a + b;//soma os 2 valores e retorna o resultado
        }
        
        public int Subtrair(int a, int b){
            return a-b;
        }

        public int Multiplicar(int a, int b){
            return a*b;
        }

        public int Dividir(int a, int b){
            if(b == 0){
                Console.WriteLine("não é possivel fazer a divisão por 0");
                return 0;
            }
            else{
                return a/b;
            }
        }
    }
}