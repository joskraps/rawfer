namespace Rawfer.Shared.Repositories
{
    using System.Collections.Generic;
    using System.Data;

    using Rawfer.Shared.Models;

    using Tiddly.Sql.DataAccess;

    public interface IAnimalRepository
    {
        void AddAnimal(Animal animal);

        IEnumerable<Animal> GetAnimalsForUser();
    }

    public class AnimalRepository : IAnimalRepository
    {
        private SqlDataAccess dataAccess;

        public AnimalRepository(SqlDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void AddAnimal(Animal animal)
        {
            // this.connection.GetConnection().Execute("AddAnimalForUser", new {userId = 1, name = animal.Name, breed = animal.Breed, weight = animal.Weight, targetWeight = animal.TargetWeight }, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<Animal> GetAnimalsForUser()
        {
            return this.dataAccess.Fill<Animal>(new SqlDataAccessHelper().AddProcedure("GetAnimalsForUser").AddParameter("UserId", 1, SqlDbType.Int));
        }
    }
}