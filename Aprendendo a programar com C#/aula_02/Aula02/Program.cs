using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args) //classe pricipal;
        {
            Console.WriteLine("Entrada de dados");
            Console.WriteLine("Digite o seu nome");

            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("O nome digitado é: " + nomeDoUsuario);


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

            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            Console.WriteLine("Soma de todos os números: " + (primeiro + segundo + terceiro));
            Console.WriteLine("Subtração: " + (terceiro - segundo - primeiro));
            Console.WriteLine("Multiplicação: " + (terceiro * segundo * primeiro));
            Console.WriteLine("Divisão: " + (terceiro / segundo));
        }

        public static void OperadorAtribucao()
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("------------");

            a += 2;
            Console.WriteLine(a);
            Console.WriteLine("------------");


            string alfabeto = "ABC";
            alfabeto += "DEF";
            Console.WriteLine(alfabeto);

            Console.WriteLine("------------");

            a = 10; //receber 10.
            a *= 3; //10 * 3;
            Console.WriteLine(a);

        }

        public static void OperadorRelacional()
        {


            int a = 10;
            bool resposta = a >= 10; //resposta sempre será TRUE OU FALSE.

            Console.WriteLine("Valor da resposta:" + resposta);


            bool menor = a < 10;
            bool maiorIgual = a >= 30;
            bool igual = (a == 10);  //igualdade
            bool diferente = (a != 10); //diferente.


            Console.WriteLine("Valor da resposta menor :" + menor);
            Console.WriteLine("Valor da resposta maiorIgual :" + maiorIgual);
            Console.WriteLine("Valor da resposta igual :" + igual);
            Console.WriteLine("Valor da resposta diferente :" + diferente);

        }

        public static void OperadorLogico()
        {


            int salario1 = 100;
            int salario2 = 50;
            int salario3 = 200;

            //Quero saber se o salario1 é maior que o 2 e tbm maior que o 3.

            //&& significa E
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



    }
}
