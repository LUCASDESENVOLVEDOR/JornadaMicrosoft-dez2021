using consoleMVC.Model;
using consoleMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Controller
{
    internal class ProdutoController
    {
        //produto classe.
        //view.

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            //List<Produto> produtos = produto.Ler();
           // produtoView.Listar(produtos);

           produtoView.Listar(produto.Ler());
        }
    }
}
