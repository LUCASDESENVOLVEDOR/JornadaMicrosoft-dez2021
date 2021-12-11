using E_JOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP.

        Equipe equipeModel = new Equipe(); 


        //500 erro

        //200 OK
        public IActionResult Index()
        {
            //VIEW = responsavel pela exibição do frontend.
               

            //ViewBag = ARMAZENAS AS INFORMACOES DO BACKEND
            // PARA SEREM ACESSADAS NO FRONTEND. (CONTROLLER PARA A  VIEW)

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }



        //public IActionResult Cadastrar(IFormCollection form)
        //{






        //}







    }
}
