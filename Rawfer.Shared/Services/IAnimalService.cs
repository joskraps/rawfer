namespace Rawfer.Shared.Services
{
    using System.Collections.Generic;

    using Rawfer.Shared.Models;

    public interface IAnimalService
    {
        void AddAnimal(Animal animal);

        IEnumerable<Animal> GetAnimals();
    }
}