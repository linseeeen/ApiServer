using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiServer.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Pikachu"},
            new Pokemon() {Name = "Charmander"}
        };

        [HttpGet]
        public ActionResult Get() 
        {
            return Ok(pokemons[0]);
        }
    }
}
