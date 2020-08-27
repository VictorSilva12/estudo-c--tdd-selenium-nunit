using System;
namespace estudo_c__tdd_selenium_nunit
{
    public class VetorSwitch
    {
        public void ImprimeVetor(){
            int dia;
            string[] dias = new string[7];
            dias[0] = "segunda-feira";
            dias[1] = "terça-feira";
            dias[2] = "quarta-feira";
            dias[3] = "quinta-feira";
            dias[4] = "sexta-feira";
            dias[5] = "sabádo";
            dias[6] = "domingo";
            int[] numeros = new int[] {1, 2, 3, 4, 5, 6, 7};

            foreach(string el in dias){
                int index = Array.IndexOf(dias, el);
                Console.WriteLine(numeros[index]+" - "+el);
            }
            /*
            foreach(int el in numeros){
                Console.WriteLine(el);
            }
            */
            Console.WriteLine("Informe um dia: ");
            int.TryParse(Console.ReadLine(), out dia);
            //o switch é uma alternativa a utilização de ifs parar criação de menus
            //diferente de if e else, o switch vai diretamente na escolha 
            switch(dia){
                case 1:
                        Console.WriteLine("Segunda-Feira");
                        break;
                case 2:
                        Console.WriteLine("Terça-Feira");
                        break;
                case 3:
                        Console.WriteLine("Quarta-Feira");
                        break;
                case 4:
                        Console.WriteLine("Quinta-Feira");
                        break;
                case 5:
                        Console.WriteLine("Sexta-Feira");
                        break;
                case 6:
                        Console.WriteLine("Sabádo");
                        break;
                case 7:
                        Console.WriteLine("Domingo");
                        break;
                default:
                        Console.WriteLine("Dia invalido");
                        break;

            }
            
        }
    }
}