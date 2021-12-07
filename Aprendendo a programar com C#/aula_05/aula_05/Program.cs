using System;   //Declaração das bibliotecas.

namespace aula_05 //Declaração do nosso programa.
{  //iniciar o do namespace
    internal class Program
    { //inicia o codigo da class 
        static void Main(string[] args)
        {

            Carro fusca = new Carro(); //copia do objeto carro e instancia na memoria.    



            Moto nova_moto = new Moto();
            nova_moto.placa = "xx";
            nova_moto



        }

        //CLASSE;   -> OBJETO. -> Físico / Abstrato

        //Representação do mundo real.


        //Finalizar da orientação a objeto é dividir
        // um programa grande em pequenos objetos.

        //facilita o nossso entendimento.


        //Um classe possui: 

        // propriedades (atributos)
        // métodos (ações)
        // eventos (o que é feito durante uma ação)

        //POO - Programação Orientada a Objetos.

        // 4 - PILARES OO.

        // ENCAPSULAMENTO,ABSTRAÇÃO,HERANÇA,POLIMORFISMO.


        //ENCAPSULAMENTO  - 
        // PRIMEIRO PILAR DO POO - AGRUPAR O QUE FAZ SENTIDO ESTAR JUNTO.

        //ABSTRAÇÃO -
        // ATO DE ESCONDER OS DETALHES, então podemos e devemos utilizar
        // na POO.


        //HERANÇA - 
         // CAPCIDADE DE UM OBJETO HERDAR , PROPRIEDADES , METODOS E EVENTOS DE 
           // DE OUTRO OBJETO.

        class Carro
        {
           

            //todas as variavel se tornam propriedades.
            //propriedades são as caracteriticas.
            private string placa;
            public string chassi;
            public string cor;

            //todas as funções se tornam métodos.
            public void Andar()
            {
                ConsultarQuantidadeCombistuvel();
            }

            void ConsultarQuantidadeCombistuvel() { }


            public void Buzinar()
            {

            }

            public void LigarSeta()
            {


            }

            private void AbrirPortaMala()
            {



            }



        }


        class Moto : Carro  //HERANÇA.
        {
            //temos caracteristicas semelhantes e caracteristicas que não sao;

            string guidao; 

             //para herdar utilizamos a palavra base.

            






        }


        static void ExercicioMaiorNumero()
        {
            // DEBUG! 

            //Ctrl + F5 =  Roda o programa normalmente, sem debug
            //F5  = Roda com debug

            //F9 = COLOCAMOS UM DEBUG, PONTO DE INTERRUPÇÃO. (BREAKPOINT)
            //F10 = EXECUTAR LINHA POR LINHA
            //F11 = ENTRAR NA FUNÇÃO
            //F5 = EXECUTAR ATÉ O FINAL OU ATÉ O PROXIMO BREAKPOINT.


            ///Faça um programa para ler três números inteiros e mostrar na tela o maior deles.

            Console.WriteLine("Digite três números:");

            //CTRL + D = copiar a linha atual e colar embaixo.
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);



        }
        static int Maior(int n1,int n2, int n3) 
        {

            //void = a função nao vai ter retorno.

            //int = representa que a função terá um retorno do tipo inteiro.
            //Maior = nome da função.

            //( ) = determinar quais são os parametros de entrada.
            //tipo e o nome separado por virgula.



            int maior;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }

            return maior; //retornar o valor.
        }

       


    }
} // finaliza o namespace
