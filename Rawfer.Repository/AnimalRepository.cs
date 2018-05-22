using Dapper;
using Rawfer.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Rawfer.Repository
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAnimalsForUser();
        void AddAnimal(Animal animal);
    }

    public class AnimalRepository : IAnimalRepository
    {
        private IConnectionWrapper connection;

        public AnimalRepository(IConnectionWrapper connection)
        {
            this.connection = connection;
        }

        public IEnumerable<Animal> GetAnimalsForUser()
        {
            var user = 1;
            return connection.GetConnection().Query<Animal>("GetAnimalsForUser", new {UserId = user }, commandType: CommandType.StoredProcedure);
        }

        public void AddAnimal(Animal animal)
        {
            connection.GetConnection().Execute("AddAnimalForUser", new {userId = 1, name = animal.Name, breed = animal.Breed, weight = animal.Weight, targetWeight = animal.TargetWeight }, commandType: CommandType.StoredProcedure);
        }
    }
}
