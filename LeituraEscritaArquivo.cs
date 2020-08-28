using System;
using System.IO;
namespace estudo_c__tdd_selenium_nunit
{
    public class LeituraEscritaArquivo
    {
        private string dados;
        
        public LeituraEscritaArquivo()
        {
            this.dados = "LeituraEscrita.txt";
        }
        ~LeituraEscritaArquivo()
        {
            
        }
        public void EscreveDados(){

            try{
                StreamWriter arq = new StreamWriter(this.dados, true);
                string conteudo;
                Console.WriteLine("Escreva alguma coisa");
                conteudo = Console.ReadLine();
                arq.WriteLine(String.Format("{0} / {1}", conteudo, DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString()));
                arq.Close();
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
        public void LerArquivo(){
            try{
                StreamReader arq = new StreamReader(this.dados);
                while(!arq.EndOfStream){
                    Console.WriteLine(arq.ReadLine());
                }
                arq.Close();
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        }
    }
}