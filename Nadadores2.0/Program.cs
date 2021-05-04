using System;

namespace Nadadores2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string classe = "";
            string checar;

            do
            {
            Console.WriteLine("Olá nadador, qual a sua idade?");
            int idadeNadador = int.Parse(Console.ReadLine());

                switch (idadeNadador)
                {
                    case 5:
                    case 6:
                    case 7:
                    classe = "infantil A";
                    
                        break;
                    case 8:
                    case 9:
                    case 10:
                    classe = "infantil B";
                    
                        break;
                    case 11:
                    case 12:
                    case 13:
                    classe = "Juvenil A";
                   
                        break;
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    classe = "Juvenil B";
                    
                        break;

                    default:
                    classe = "Infelizmente o indivíduo com essa idade não pode se inscrever na natação \n Digite uma idade valida \n";
                        break;
                }      

            Console.WriteLine(classe);
            Console.WriteLine("Você deseja checar mais uma idade? (sim/não)");
            checar = Console.ReadLine().ToLower();

            }while (checar == "sim");

            Console.WriteLine("Tudo bem então, Tenha um bom dia caro usuário \n Fim do sistema");
        }
    }
}
