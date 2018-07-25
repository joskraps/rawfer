namespace Rawfer.Shared.Services
{
    using System.Collections.Generic;

    using Rawfer.Shared.Models;
    using Rawfer.Shared.Repositories;

    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository animalRepo;

        public AnimalService(IAnimalRepository animalRepo)
        {
            this.animalRepo = animalRepo;
        }

        public void AddAnimal(Animal animal)
        {
            this.animalRepo.AddAnimal(animal);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return this.animalRepo.GetAnimalsForUser();
        }
    }
}