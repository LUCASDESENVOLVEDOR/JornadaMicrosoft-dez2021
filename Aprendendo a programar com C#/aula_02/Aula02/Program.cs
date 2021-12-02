using System;
using System.Globalization;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args) //classe pricipal;
        {
            //Para executar basta retirar o comentario da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas OperadorRelacional.
            

            //Inicio();
            //OperadorAritmetico();
            //OperadorAtribucao();
            OperadorRelacional();
            // OperadorLogico();
            //Entrada();
            //Saida();

        }


        public static void Inicio()
        {

            //COMO DECLARAR UMA VARIAVEL.
            // TIPO depois o NOME ; <- no final de todas as linhas.

            //linha verde = a variavel criada não esta sendo utilizada.

            //linha vermelha = esta falando algo, vai dar erro de compilação.

            // 1 sinal de igual representa atribuição.

            string nome = "Lucas";
            int idade = 28;

            //Console.WriteLine(nome);
            //Console.WriteLine(idade);
            Console.WriteLine(nome + " " + idade);


        }

        public static void OperadorAritmetico()
        {
            //tipo //nome da variavel // sinal de = representa atribuição;

            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            //soma de todas as variaveis do tipo int.
            Console.WriteLine("Soma de todos os números: " + (primeiro + segundo + terceiro));
            //subtração  de todas as variaveis do tipo int.
            Console.WriteLine("Subtração: " + (terceiro - segundo - primeiro));
            //multiplicação  de todas as variaveis do tipo int.
            Console.WriteLine("Multiplicação: " + (terceiro * segundo * primeiro));
            //divisão  de todas as variaveis do tipo int.
            Console.WriteLine("Divisão: " + (terceiro / segundo));
        }

        public static void OperadorAtribucao()
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("------------");


            //representa a atribuição de A para =>  A + 2;
            a += 2;
            Console.WriteLine(a);
            Console.WriteLine("------------");

            //representa a atribuição de ABC para =>  ABC + DEF;
            string alfabeto = "ABC";
            alfabeto += "DEF";
            Console.WriteLine(alfabeto);

            Console.WriteLine("------------");

            //voltamos a variavel a para o valor 10;
            a = 10; //receber 10.

            //representa a atribuicao de a para a * 3. (10*3)
            a *= 3; //10 * 3;
            Console.WriteLine(a);

        }

        public static void OperadorRelacional()
        {
            //bool => tipo de variavel que armazena informações TRUE OU FALSE.
             

            int a = 10;
            bool resposta = a >= 10; //resposta sempre será TRUE OU FALSE.

            Console.WriteLine("Valor da resposta:" + resposta);

                             
            bool menor = a < 10;  //menor
            bool maiorIgual = a >= 30; //maior ou igual
            bool igual = (a == 10);  //igualdade
            bool diferente = (a != 10); //diferente.


            Console.WriteLine("Valor da resposta menor :" + menor);
            Console.WriteLine("Valor da resposta maiorIgual :" + maiorIgual);
            Console.WriteLine("Valor da resposta igual :" + igual);
            Console.WriteLine("Valor da resposta diferente :" + diferente);

        }

        public static void OperadorLogico()
        {
            //&& = E
            // || = OU
            // ! = NOT (não)

            int salario1 = 100;
            int salario2 = 50;
            int salario3 = 200;

            //Quero saber se o salario1 é maior que o 2 e tbm maior que o 3.

            //&& significa E          //condicao 1      E  //condicao 2
            bool resultadoSalario = salario1 > salario2 && salario1 > salario3;

            // primeira condicao = (TRUE OU FALSE) E ( TRUE OU FALSE)

            //Console.WriteLine(resultadoSalario);


            //Quero saber se o salario 2 menor que o salario 1 ou maior que salario 3
            bool resultado2 = salario2 < salario1 || salario2 > salario3;
            //TRUE                 //FALSE


            //Console.WriteLine(resultado2);


            //Quero saber se o salario2  é maior que o salario 3
            bool resultado3 = !(salario2 > salario3);
            //! quer saber do contrario.

            //! = quero saber se é falso.


            Console.WriteLine(resultado3);


        }


        public static void Entrada()
        {
            Console.WriteLine("Entrada de dados");
            Console.WriteLine("Digite o seu nome");
                                   //leitura da linha ira atribuir a variavel após o usuario apertar ENTER.
            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("O nome digitado é: " + nomeDoUsuario);


        }

        public static void Saida()
        {

            int idade = 28;
            double saldo = 10.35784;
            string nome = "Maria";

            //Console.WriteLine("Maria tem 28 anos e tem saldo igual a 10.35784 reais.");

            //interpolação. { } representar a variavel.

            //o primeiro {} sempre inicia do zero.
            // o segundo {} vai na sequencia. 1 ,....

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo);

            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); //2 casas decimais e arredonda.

            Console.WriteLine(saldo.ToString("F4"));


            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            //NECESSARIO IMPORTAR using System.Globalization; nas primeiras linhas do codigo.




        }

        public static void Parse()
        {

            //string - toString().

            //parse


            double numero = 10.45;
            string numero2 = "20";

            //Parse

            Console.WriteLine(double.Parse(numero2) + numero);



        }

        public static void Exercicio()
        {
            /* Execicio 1  */

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            string forma = @"


                        Usando os valores das variáveis, produza a seguinte saída na tela do console:

                        Produtos:
                        Computador, cujo preço é $ 2100,00
                        Mesa de escritório, cujo preço é $ 650,20

                        Registro: 30 anos de idade, código 5290 e gênero M


                        Medida com oito casas decimais: 53,23456700
                        Arredondado (três casas decimais): 53,235
                        Separador decimal invariant culture: 53.235



                     ";


            //EXERCICIO 2 
            //Elabore um algoritmo que receba e calcule a idade média de 5 alunos.

        }


    }
}
