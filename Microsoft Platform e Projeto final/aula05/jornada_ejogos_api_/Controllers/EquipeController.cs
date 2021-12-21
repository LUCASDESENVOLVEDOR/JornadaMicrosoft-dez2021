using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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

          

            try  //TENTE EXECUTAR O CODIGO ABAIXO.
            {

                throw new Exception("ACONTECEU UM ERRO");
                return Ok("Localizar equipes");

            }
            catch (Exception) //Pegar -> 
            {
                return BadRequest("Consulte o administrador do sistema");
            }
            finally
            {
                //se entrou no try ou no catch ele vai executar o que estiver aqui.


            }
          
        }




    }
}
