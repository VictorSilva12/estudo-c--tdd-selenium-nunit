using System;
namespace estudo_c__tdd_selenium_nunit
{   
    public class Pessoa:Endereco
    {
        private string nome;
        private int idade;
        public Pessoa(string nome, int idade){
            this.nome = nome;
            this.idade = idade;
        }
        
        ~Pessoa(){
            //destrutor, sempre executa ao final da utlização de uma classe
            //exemplo de utilização: ao terminar uma conexão com o banco de dados
            Console.WriteLine("Finaliza classe");
        }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }
    public class Endereco
    {
        private string rua;
        private int numero;
        private string bairro;

        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
    }
}