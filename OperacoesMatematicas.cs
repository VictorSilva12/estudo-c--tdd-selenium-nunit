using System;
namespace estudo_c__tdd_selenium_nunit
{
    public class OperacoesMatematicas
    {
        public void OpsMatematica(){
            //Math: Fornece constantes e métodos estáticos para trigonométricas, logarítmicas e outras funções matemáticas comuns.
            //Ceiling()
            //Max() - retorna o maior de 2 numeros que serão comparados
            //Min() - retorna o menor de 2 numeros que serão comparados
            //Round() - retorna valor arredondado de um decimal
            //Pow() - retorna o valor de um numero elevado a potencia
            //Sqrt() - retorna a raiz quadrada de 1 numero

            double salario = 1200.59;
            Console.WriteLine(Math.Ceiling(salario));
            Console.WriteLine(Math.Max(salario, 2000));
            Console.WriteLine(Math.Min(salario, 2000));
            Console.WriteLine(Math.Round(salario));
            Console.WriteLine(Math.Pow(4, 3));
            Console.WriteLine(Math.Sqrt(35));

            double dv; 
            double numero = 10;
            double retorno = Divisao(numero, out dv);

            //como a variavel dv está sendo passada como um parametro de referencia
            //e esse parametro está sendo alterado dentro do metodo chamado, e sendo
            //passado por referencia, esses valores compartilham o mesmo endereço de memoria
            //com isso caso o valor de um seja alterado, o outro também será alterado
            Console.WriteLine("{0} / {1} = {2}", numero, dv, retorno);
        }     

        public static double Divisao(double d1, out double divisor){

            Random rd = new Random();
            divisor = rd.Next(1,10);//seleciona um numero aleatorio entre 1 e 10
            return d1 / divisor;

        }  
    }
}