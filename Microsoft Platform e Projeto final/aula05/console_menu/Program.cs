using System;

namespace console_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //USUARIO VAI INFORMAR O QUE FAZER E TERÁ 3 OPCOES. ok

            //PARA CADA OPCAO VAMOS RESPONDER ALGO DIFERENTE.

            //OPCAO PARA O USUARIO CONTUNUAR OU SAIR DO PROGRAMA.

            //true ou false;
            bool continuar = true;


            //fazer
            do
            {              
                
                Console.WriteLine(@" Escolha uma opção:
                                    1 - Carro 
                                    2 - Moto
                                    3 - Casar
                                    4 - Cadastrar
                                    5 - Sair
                          ");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();
              

                switch (opcaoEscolhida)
                {
                    case "1": Console.WriteLine("Você escolheu carro"); break;
                    case "2": Console.WriteLine("Você escolheu moto"); break;
                    case "3": Console.WriteLine("Você escolheu casar"); 
                   break;
                    case "4": Cadastrar(); break;
                    case "5": continuar = false; break;
                    default:
                        Console.WriteLine("Escolha não válida.");
                        break;
                }


            }

            while (continuar);
            // while (continuar == true); // mesma coisa.      

             

            //pergunta

        }


        public static void Cadastrar()
        {
            Console.WriteLine("Cadastrar");
        }
    }
}
