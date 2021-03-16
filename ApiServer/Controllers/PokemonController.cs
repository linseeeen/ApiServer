using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiServer.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        [HttpGet]
        public ActionResult Get() 
        {
            return Ok("Hej");
        }
    }
}
