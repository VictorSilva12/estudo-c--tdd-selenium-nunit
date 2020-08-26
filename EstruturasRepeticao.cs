using System;

namespace estudo_c__tdd_selenium_nunit
{
    public class EstruturasRepeticao
    {
        string[] letras = {"A", "B", "C", "D", "E", "F", "G", "H"};
            //ou string[] letras = new string[] {"A", "B", "C", "D", "E", "F", "G", "H"};
        int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //ou int[] numeros = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public void EstudoForeach(){

            foreach(string letra in letras){
                Console.WriteLine(letra);
            }

            foreach(int numero in numeros){
                Console.Write(numero+ " ");
            }
        }
        public void EstudoFor(){
            //for é usado quando se sabe quantas vezes a repetição acontecerá
            for(int i=0; i < letras.Length; i++){

                Console.Write(letras[i] + " ");//utilizo o i como index para imprimir os valores no vetor

            }
        }
        public void EstudoWhile(){
            //while é utilizado quando não se sabe quantas vezes a repetição acontecerá
            int opcao;
            Console.WriteLine("Escolha uma opção:\n1 - Bom dia\n2 - Boa noite\n3 - Sair");
            int.TryParse(Console.ReadLine(), out opcao);//tenta converter o que foi digitado para inteiro, caso não consiga 
            while(opcao!=3){

                switch(opcao){
                    case 1: Console.WriteLine("Bom dia!");
                            break;

                    case 2: Console.WriteLine("Boa tarde!");
                            break;
                    default: Console.WriteLine("Opcao invalida");
                            break;
                }
                Console.WriteLine("Enter para continuar");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Escolha uma opção:\n1 - Bom dia\n2 - Boa noite\n3 - Sair");
                int.TryParse(Console.ReadLine(), out opcao);//tenta converter o que foi digitado para inteiro, caso não consiga 
            
            }
        }
    }
}