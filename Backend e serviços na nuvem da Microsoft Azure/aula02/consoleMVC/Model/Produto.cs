using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Model
{
    internal class Produto
    {
        //Codigo, Nome, Preco.

        //prop tab tab

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //const valor único, não pode ser alterado.
        private const string Path = "Database/Produto.csv";

        //CSV (Valores separados por vírgula).

        //CONSTRUTOR.  <--- quando a classe for construida o que será 
        //executado.

        //CTOR TAB TAB

        public Produto() //CONSTRUTOR DA CLASSE.
        {
            //split -> responsavel por separar uma string
            /// a partir de um parametro., devolver um array.


            string pasta = Path.Split('/')[0];

            //SE NAO EXISTIR.
            if (!Directory.Exists(pasta))
            {
                //criar a pasta no projeto.
                Directory.CreateDirectory(pasta);
            }

            //SE NAO EXISTIR.
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }

        }

        //funcao vai ler todos os produtos.



        public List<Produto> Ler()
        {
            List<Produto> ListaProdutos = new List<Produto>();

            string[] linhas = File.ReadAllLines(Path);

            foreach (string item in linhas)
            {
                string [] atributos = item.Split(';');

                Produto produtoDaLinha = new Produto();
                produtoDaLinha.Codigo = int.Parse(atributos[0]);
                produtoDaLinha.Nome = atributos[1];
                produtoDaLinha.Preco = float.Parse(atributos[2]);

                //adicionando um novo produto na lista.
                ListaProdutos.Add(produtoDaLinha);
            }

            return ListaProdutos;
        }
    }
}
