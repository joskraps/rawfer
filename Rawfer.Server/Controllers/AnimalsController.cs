using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rawfer.Shared;

namespace Rawfer.Server.Controllers
{
    
    [Route("api/animals")]
    public class AnimalsController : Controller
    {
        [Produces("application/json")]
        [HttpGet("[action]")]
        public IEnumerable<Animal> GetAnimals()
        {
            var rng = new Random();

            return new List<Animal>()
            {
                new Animal
                {
                    Id = rng.Next(1,100),
                    Name="Auriel"
                }
            };
        }
    }
}