using System;

namespace estudo_c__tdd_selenium_nunit
{
    public class Matriz
    {
        public void ImprimeMatriz(){
            string[,] matrizString = new string[2,2];
            matrizString[0,0] = "Linha 0 - Coluna 0";
            matrizString[0,1] = "Linha 0 - Coluna 1";
            matrizString[1,0] = "Linha 1 - Coluna 0";
            matrizString[1,1] = "Linha 1 - Coluna 1";

            foreach(string el in matrizString){
                Console.WriteLine(el);
            }

            int[,] matriz = new int[,] {{10, 2, 3}, {5, 4, 8}};
            foreach(int el in matriz){
                Console.WriteLine(el);
            }
        }
    }
}