using Dapper;
using Rawfer.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Rawfer.Repository
{
    public interface IFoodItemRepository
    {
        IEnumerable<FoodItem> GetFoodForUsers();
        void AddFoodItem(FoodItem animal);
    }

    public class FoodItemRepository : IFoodItemRepository
    {
        private IConnectionWrapper connectionWrapper;

        public FoodItemRepository(IConnectionWrapper connection)
        {
            connectionWrapper = connection;
        }

        public IEnumerable<FoodItem> GetFoodForUsers()
        {
            var user = 1;
            return connectionWrapper.GetConnection().Query<FoodItem>("GetFoodForUser", new {UserId = user }, commandType: CommandType.StoredProcedure);
        }

        public void AddFoodItem(FoodItem animal)
        {
            //SconnectionWrapper.GetConnection().Execute("AddAnimalForUser", new {userId = 1, name = animal.Name, breed = animal.Breed, weight = animal.Weight, targetWeight = animal.TargetWeight }, commandType: CommandType.StoredProcedure);
        }
    }
}
