using Rawfer.Repository;
using Rawfer.Shared;
using System.Collections.Generic;

namespace Rawfer.Business
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals();
        void AddAnimal(Animal animal);
    }

    public class AnimalService : IAnimalService
    {
        private IAnimalRepository animalRepo;

        public AnimalService(IAnimalRepository animalRepo)
        {
            this.animalRepo = animalRepo;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return animalRepo.GetAnimalsForUser();
        }

        public void AddAnimal(Animal animal)
        {
            animalRepo.AddAnimal(animal);
        }
    }
}
