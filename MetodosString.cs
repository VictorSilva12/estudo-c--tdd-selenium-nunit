using System;
namespace estudo_c__tdd_selenium_nunit
{
    public class MetodosString
    {
        public void EstudoMetodoString(){
            
            string usuario = "wipes@auxiliar.com";
            string usuario2 = "BOLA";
            string senha = "123141 31234 12 31241 412 142 312 412 31 2541 16 23 4123 41";
            //IndexOf(): encontrar o index do elemento
            Console.WriteLine(usuario.IndexOf("@"));
            //ToString(): transforma o elemento em uma string
            Console.WriteLine(DateTime.Now.Month.ToString());
            //ToLower(): coloca todos os caracteres da string em letra minuscula
            Console.WriteLine(usuario2.ToLower());
            //ToUpper(): coloca todos os caracteres da string em letra maiscula
            Console.WriteLine(usuario.ToUpper());
            //Format(): serve para melhor formatar uma string para exibição, util pois elimina a necessidade
            //de realizar varias concatenações 
            Console.WriteLine(string.Format("Olá, {0}, agora são {1}:{2}", usuario, DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString()));
            //Trim(): remove espaços do inicio e do fim de uma string
            //Replace(): remove os elementos de acordo com o primeiro parametro passado, substituindo 
            // a ocorrencia dos valores.
            Console.WriteLine(senha.Trim().Replace(" ", string.Empty));
        }
    }
}