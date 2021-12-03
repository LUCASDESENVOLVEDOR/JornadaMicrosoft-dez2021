using System;

namespace aula04
{
    internal class Program
    {

        //void nao vai ter retorno.
        //Main classe principal do nosso principal.      


        /// <summary>
        /// Aqui se encontra a main e eu utilizei 3 / par abrir esse comentario.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //comentario em linha.

            /*
             * 
             * comentarios
             * mais
             * de
             * uma
             * linha
            
             */


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

        public static void Array()
        {

            //array  ("VETOR") = uma sequencia não ordenada de itens.

            //int numero = 4;
            //int numero2 = 8;

            int[] numero_loteria = { 4, 8, 15, 16, 23, 42 };
            //posicoes 0 , 1, 2, 3, 4,  5  

            Console.WriteLine("A posição 0 é: " + numero_loteria[0]);

            Console.WriteLine("A quantidade de itens é: " + numero_loteria.Length);


            // numero <= 5;
            for (int numero = 0; numero < numero_loteria.Length; numero++)
            {
                Console.WriteLine("Está na posição: " + numero);
                Console.WriteLine("Valor do numero_loteria: " + numero_loteria[numero]);
            }



        }

        public static void Foreach()
        {
            int[] numero_loteria = { 4, 8, 15, 16, 23, 42 };


            foreach (var numero in numero_loteria)
            {
                Console.WriteLine("O item do array é: " + numero);
            }
        }
    }
}
