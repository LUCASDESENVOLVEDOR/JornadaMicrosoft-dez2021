using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jornada_ejogos_api_.Controllers
{
    //padrão de rota, DOMINIO/api/nomecontroller
    [Route("api/[controller]")]
    [ApiController]

                                    //herança ControllerBase funções ja prontas.
    public class EquipeController : ControllerBase
    {
        //VERBO (estará disponivel para a consulta.
        [HttpGet]
        public IActionResult qualquercoisa()
        {
            return Ok("Localizar equipes");
        }




    }
}
