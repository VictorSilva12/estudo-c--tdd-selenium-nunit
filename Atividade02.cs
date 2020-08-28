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
                Console.WriteLine("Cliente "+ (Array.IndexOf(clientes, el)+1)+": "+el);
            }
        }

        public void MaiorMenor(){

            int[] numeros = new int[10];
            int menor = 0, maior = 0;

            Console.WriteLine("Siga o que se pede");
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine("Digite 1 numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
         
            for(int i = 0; i < numeros.Length; i++){
                if(i == 0){
                    menor = numeros[i]; 
                    maior = numeros[i];
                }
                if(numeros[i] < menor){
                    menor = numeros[i];
                }
                else if(numeros[i] > maior){
                    maior = numeros[i];
                }
            }
            
            Console.WriteLine("Menor numero: " + menor);
            Console.WriteLine("Menor numero: " + maior);
        }

        public void Matriz4x4(){
            int[,] matriz = new int[4,4];
            //GetLength(0) pega o tamanho da linha 
            for(int i = 0; i < matriz.GetLength(0); i++){
                //GetLength(1) pega o tamanho da coluna
                for(int j = 0; j < matriz.GetLength(1); j++){
                    if(j!=3){
                        matriz[i,j] = 0;
                    }
                    else{
                        matriz[i,j] = 1;
                    }
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine("");
            }
        }
        public void Operacoes(){
            int op, n1, n2;
            
            Console.WriteLine("1 - Para somar\n2 - Para subtrair\n3 - Para multiplicar\n4 - Para dividir\n5 - Sair");
            int.TryParse(Console.ReadLine(), out op); 
            while(op!=5){
                Console.WriteLine("Qual o primeiro numero?");
                int.TryParse(Console.ReadLine(), out n1);
                Console.WriteLine("Qual o segundo numero?");
                int.TryParse(Console.ReadLine(), out n2);
                try{
                    switch(op){
                        case 1:
                                Console.WriteLine("{0} + {1} = {2}", n1, n2, n1+n2);
                                break;
                        case 2:
                                Console.WriteLine("{0} - {1} = {2}", n1, n2, n1-n2);
                                break;
                        case 3:
                                Console.WriteLine("{0} * {1} = {2}", n1, n2, n1*n2);
                                break;
                        case 4:
                                try
                                {
                                    Console.WriteLine("{0} / {1} = {2}", n1, n2, n1/n2);
                                }
                                catch (DivideByZeroException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                        default:
                                Console.WriteLine("Opção invalida");
                                break;
                    }
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("1 - Para somar\n2 - Para subtrair\n3 - Para multiplicar\n4 - Para dividir");
                int.TryParse(Console.ReadLine(), out op);
            }
        }
    }
}