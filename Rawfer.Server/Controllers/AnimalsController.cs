namespace Rawfer.Server.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Rawfer.Shared.Models;
    using Rawfer.Shared.Services;

    [Authorize]
    [Produces("application/json")]
    [Route("api/animals")]
    public class AnimalsController : Controller
    {
        private IAnimalService animalService;

        public AnimalsController(IAnimalService animalService)
        {
            this.animalService = animalService;
        }

        [HttpGet("")]
        public IEnumerable<Animal> GetAnimals()
        {
            return animalService.GetAnimals();
        }

        [HttpPost("")]
        public void AddAnimal([FromBody] Animal animal)
        {
            animalService.AddAnimal(animal);
        }
    }
}