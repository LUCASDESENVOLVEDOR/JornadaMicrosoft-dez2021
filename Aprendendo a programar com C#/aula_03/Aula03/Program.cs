using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para executar basta retirar o comentario da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas Switch.


           // CondicaoIf();
           // CondicaoELSE();
           // CondicaoComElseIF();
           // CondicaoComElseIF();
            Switch();
           // While();
           // DoWhile();
           // For();

        }
        public static void CondicaoIf()
        {
            //IF (SE) -> Operador logico - TRUE OU FALSE.

            //IF (SE) .

            //ELSE -> SENAO;

            int hora = 10;

            if (hora > 12) //irá executar apenas se o resultado for TRUE. 
            {
                Console.WriteLine("Boa tarde!");
            }



        }

        public static void CondicaoELSE()
        {
            //IF (SE) -> Operador logico - TRUE OU FALSE.


            //IF (SE) .

            //ELSE -> SENAO;

            int hora = 10;

            if (hora > 12) //irá executar apenas se o resultado for TRUE. 
            {
                Console.WriteLine("Boa tarde!");
            }
            else //SENÃO; = FALSE PARA A CONDIÇÃO DE CIMA.
            {
                Console.WriteLine("Bom dia");
            }

        }

        public static void CondicaoComElseIF()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());


            if (hora < 12) //SE A HORA É MENOR QUE 12;
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }

            else //se nao acontecer nenhuma das condições acima.
            {
                Console.WriteLine("Boa noite!");
            }


            //DICA 
            if (hora < 12) //é menor que 12? 
                Console.WriteLine("Bom dia!");

            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");


        }

        public static void Switch()
        {
            //SWITCH
            //vai executar um bloco de comando de acordo coma correspondência.

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            switch (hora)
            {
                case < 12: Console.WriteLine("Bom dia!"); break;
                case < 18: Console.WriteLine("Boa tarde!"); break;
                default: Console.WriteLine("Boa noite!"); break;
            }


            //codição para string.
            string nome = "LUCAS";


            switch (nome)
            {
                case "IGOR": Console.WriteLine("nao vai entrar"); break;
                case "LUCAS": Console.WriteLine("Boa tarde! Lucas."); break;
                default: Console.WriteLine("nao vai entrar"); break;
            }




        }

        public static void While()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            //enquanto for diferente de 0, somar os valores.

            while (numero != 0)  //condicao verdeira.
            {
                soma += numero;
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
            };

            Console.WriteLine(soma);


        }

        public static void DoWhile()
        {

            //DO = faça.
            //WHILE = enquanto

            int numero = 1;

            do //faça
            {
                Console.WriteLine(numero);
                numero++; // ++ somar mais 1. 
            }
            while (numero <= 100);

            //-------------------------------------

            int numeroUsuario;

            //Console.ReadLine()  --> STRING.
            //numeroUsuario  --->INT. 
            //numeroUsuario = int.Parse()
            //Parse realiza a conversao de tipo.

            do
            {
                Console.WriteLine("Digite um número:");
                numeroUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}:", numeroUsuario);
            }
            while (numeroUsuario != 0);
        }

        public static void For()
        {
            //FOR 

            //i = 1 comecar no numero 1.
            // condicao <= 100 .
            // ++ (1 por 1)




            for (double numero = 1; numero <= 4; numero += 0.2)
            {
                Console.WriteLine(numero);
            }



        }


    }
}
