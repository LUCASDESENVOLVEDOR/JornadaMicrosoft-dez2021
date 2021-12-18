using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jornada_ejogos_api_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        [HttpGet]
        public IActionResult localizar()
        {

            return Ok("Localizar as equipes");

        }

    }
}
