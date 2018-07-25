namespace Rawfer.Shared.Repositories
{
    using System.Collections.Generic;
    using System.Data;

    using Rawfer.Shared.Models;

    using Tiddly.Sql.DataAccess;

    public interface IFoodItemRepository
    {
        void AddFoodItem(FoodItem animal);

        IEnumerable<FoodItem> GetFoodForUsers();
    }

    public class FoodItemRepository : IFoodItemRepository
    {
        private readonly SqlDataAccess dataAccess;

        public FoodItemRepository(SqlDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public void AddFoodItem(FoodItem animal)
        {
            // SconnectionWrapper.GetConnection().Execute("AddAnimalForUser", new {userId = 1, name = animal.Name, breed = animal.Breed, weight = animal.Weight, targetWeight = animal.TargetWeight }, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<FoodItem> GetFoodForUsers()
        {
            return this.dataAccess.Fill<FoodItem>(
                new SqlDataAccessHelper().AddProcedure("GetFoodItemsForUser").AddParameter("UserId", 1, SqlDbType.Int));
        }
    }
}