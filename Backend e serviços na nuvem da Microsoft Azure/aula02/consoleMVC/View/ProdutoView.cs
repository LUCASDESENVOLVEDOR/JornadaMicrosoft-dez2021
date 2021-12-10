using consoleMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.View
{
    internal class ProdutoView
    {
        //listar

        public void Listar(List<Produto> listaProduto)
        {

            foreach (Produto item in listaProduto)
            {
                Console.WriteLine($"\nCódigo: { item.Codigo}");
                Console.WriteLine($"Nome: { item.Nome}");
                Console.WriteLine($"Preço: { item.Preco:C2}");
            }   
        }

    }
}
