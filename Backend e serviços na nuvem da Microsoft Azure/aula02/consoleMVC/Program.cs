using consoleMVC.Controller;
using consoleMVC.Model;
using System;

namespace consoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            produto.ListarProdutos();
        
        
        }
    }
}
